Public Class frmLaender
    Private _ctx As openABEntities = New openABEntities

    Private Sub frmLaender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LandBindingSource.DataSource = _ctx.Lands.ToList
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim k = GridView1.GetRow(e.RowHandle)
        _ctx.Lands.Add(k)
    End Sub

    Private Sub btnAbbrechen_Click(sender As Object, e As EventArgs) Handles btnAbbrechen.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        _ctx.SaveChanges()
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

  
End Class