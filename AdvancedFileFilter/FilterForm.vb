Imports System.Windows.Forms
Imports JesseDonat.AdvancedFileFilter
Public Class FilterForm

    Dim workingFilter As jFilter

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AdvancedFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal j As jFilter)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        populateTextboxes(j)
        workingFilter = j
        textFilter.Text = workingFilter.toString
    End Sub

    Sub populateTextboxes(ByVal j As jFilter)
        textRaw.Text = String.Join(vbCrLf, j.raw.ToArray)
        textRaw_excl.Text = String.Join(vbCrLf, j.raw_excl.ToArray)
        textFold.Text = String.Join(vbCrLf, j.fold.ToArray)
        textFold_excl.Text = String.Join(vbCrLf, j.fold_excl.ToArray)
    End Sub

    Sub makeFilterOfIt() Handles textRaw.KeyUp, textRaw_excl.KeyUp, textFold.KeyUp, textFold_excl.KeyUp
        workingFilter.raw = New Stack(Of String)(textRaw.Text.Split(vbCrLf))
        workingFilter.raw_excl = New Stack(Of String)(textRaw_excl.Text.Split(vbCrLf))
        workingFilter.fold = New Stack(Of String)(textFold.Text.Split(vbCrLf))
        workingFilter.fold_excl = New Stack(Of String)(textFold_excl.Text.Split(vbCrLf))
        textFilter.Text = workingFilter.toString
    End Sub


End Class
