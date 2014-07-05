Public Class frmEditKontakt

    Sub New(k As Kontakt)
        InitializeComponent()

        Me.KontaktBindingSource.DataSource = k
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class