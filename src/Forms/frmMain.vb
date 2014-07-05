Public Class frmMain
    Private _ctx As New openABEntities
    Sub DataBind()
        Dim k = (From i In _ctx.Kontakts)
        grd.DataSource = k.ToList

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataBind()
    End Sub

    Private Sub NeuenKontaktErstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuenKontaktErstellenToolStripMenuItem.Click
        Using ctx = New openABEntities
            Dim neu As New Kontakt
            Dim frm As New frmEditKontakt(neu, ctx)
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
            Dim frm As New frmEditKontakt(k, _ctx)

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                _ctx.setLog()
                _ctx.SaveChanges()
            End If

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataBind()
    End Sub

    Private Sub grdview_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grdview.RowUpdated
        _ctx.SaveChanges()
    End Sub
End Class
