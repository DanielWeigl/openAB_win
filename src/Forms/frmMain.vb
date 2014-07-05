Public Class frmMain

    Sub DataBind()
        Using ctx = New openABEntities
            Dim k = (From i In ctx.Kontakts)
            grd.DataSource = k.ToList
        End Using
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataBind()
    End Sub

    Private Sub NeuenKontaktErstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuenKontaktErstellenToolStripMenuItem.Click
        Using ctx = New openABEntities
            Dim neu As New Kontakt
            Dim frm As New frmEditKontakt(neu)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                ctx.Kontakts.Add(neu)
                ctx.SaveChanges()
                grd.RefreshDataSource()
            End If

        End Using
    End Sub
   

    Private Sub grd_DoubleClick(sender As Object, e As EventArgs) Handles grdview.DoubleClick
        Dim k As Kontakt = grdview.GetFocusedRow
        If k IsNot Nothing Then
            Using ctx = New openABEntities
                Dim frm As New frmEditKontakt(k)

                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    ctx.SaveChanges()
                    DataBind()
                End If
            End Using
        End If
    End Sub

    Private Sub LänderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LänderToolStripMenuItem.Click
        Dim frm As New frmLaender
        frm.ShowDialog()
        DataBind()
    End Sub

    Private Sub AkademischerTitelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkademischerTitelToolStripMenuItem.Click
        Dim frm As New frmAkademischerTitel
        frm.ShowDialog()
        DataBind()
    End Sub
End Class
