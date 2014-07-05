Public Class frmEditKontakt



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSpeichern.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        Me.Close()
    End Sub
End Class