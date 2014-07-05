Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ctx = New openABEntities
            Dim k = (From i In ctx.Kontakts)
            grd.DataSource = k.ToList
        End Using
    End Sub
End Class
