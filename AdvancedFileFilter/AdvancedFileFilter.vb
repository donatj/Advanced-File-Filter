Public Class AdvancedFileFilter

    Public Class jFilter
        Public raw, raw_excl, fold, fold_excl As Stack(Of String)
        Sub New(ByVal filter As String)
            raw = New Stack(Of String)
            raw_excl = New Stack(Of String)
            fold = New Stack(Of String)
            fold_excl = New Stack(Of String)
            _Explode(filter)
        End Sub

        Private Sub _Explode(ByVal filter As String)
            Dim filters As String() = filter.Split(";")
            For Each f As String In filters
                f = f.Trim()
                If (f.Length > 0) Then
                    If f.Contains("\") Then
                        If (f(0) = "-") Then
                            fold_excl.Push(f.Substring(1))
                        Else
                            fold.Push(f)
                        End If
                    Else
                        If (f(0) = "-") Then
                            raw_excl.Push(f.Substring(1))
                        Else
                            raw.Push(f)
                        End If
                    End If
                End If
            Next
        End Sub

        Overrides Function toString() As String
            Dim i As New List(Of String)
            i.AddRange(raw)
            i.AddRange(raw_excl)
            i.AddRange(fold)
            i.AddRange(fold_excl)
            Return String.Join(";", i.ToArray)
        End Function
    End Class

    Public Shared Function ScanAndFilterPath(ByVal directory As String, ByVal searchType As Microsoft.VisualBasic.FileIO.SearchOption, ByVal filter As String, Optional ByVal ignoreRoot As Boolean = False) As String()
        Dim wFilter As New jFilter(filter)
        Dim files As String() = My.Computer.FileSystem.GetFiles(directory, searchType, wFilter.raw.ToArray).ToArray
        wFilter.raw.Clear()
        If (ignoreRoot) Then
            Return _runFilter(files, wFilter)
        Else
            Return _runFilter(files, wFilter, directory)
        End If
    End Function

    Public Shared Function _runFilter(ByVal files() As String, ByVal wFilter As jFilter, Optional ByVal rootPath As String = "") As String()

        Dim r As IEnumerable(Of String) = From c As String In files

        Dim j As IEnumerable(Of String) = From a In r Where False 'hack hack hack
        For Each f As String In wFilter.raw
            Dim fe As String = f
            j = j.Union(From c As String In r Where IO.Path.GetFileName(c) Like fe)
        Next
        If (wFilter.raw.Count > 0) Then r = j.Distinct

        For Each f As String In wFilter.raw_excl
            Dim fe As String = f
            r = From c As String In r Where Not IO.Path.GetFileName(c) Like fe
        Next

        j = From a In r Where False 'hack hack hack
        For Each f As String In wFilter.fold
            Dim fe As String = f
            If (f(0) = "\") Then
                Debug.WriteLine("xa" & f)
                j = j.Union(From c As String In r Where c Like rootPath & fe & "*")
            Else
                Debug.WriteLine("xb" & f)
                j = j.Union(From c As String In r Where c Like rootPath & "*\" & fe & "*")
            End If
        Next
        If (wFilter.fold.Count > 0) Then r = j.Distinct

        For Each f As String In wFilter.fold_excl
            Dim fe As String = f

            If (f(0) = "\") Then
                Debug.WriteLine("a" & f)
                r = From c As String In r Where Not c Like rootPath & fe & "*"
            Else
                Debug.WriteLine("b" & f)
                r = From c As String In r Where Not c Like rootPath & "*\" & fe & "*"
            End If

        Next

        Return r.ToArray
    End Function

    Public Shared Function FileFilter(ByVal files() As String, ByVal filter As String, Optional ByVal rootPath As String = "") As String()
        Dim wFilter As New jFilter(filter)
        Return _runFilter(files, wFilter, rootPath)
    End Function

End Class
