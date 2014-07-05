<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLaender
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource()
        Me.grd = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colKuerzel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBezeichnung = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOkay.Location = New System.Drawing.Point(469, 337)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(115, 28)
        Me.btnOkay.TabIndex = 0
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataSource = GetType(src.Land)
        '
        'grd
        '
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.Cursor = System.Windows.Forms.Cursors.Default
        Me.grd.DataSource = Me.LandBindingSource
        Me.grd.Location = New System.Drawing.Point(12, 12)
        Me.grd.MainView = Me.GridView1
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(572, 307)
        Me.grd.TabIndex = 1
        Me.grd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKuerzel, Me.colBezeichnung})
        Me.GridView1.GridControl = Me.grd
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colKuerzel
        '
        Me.colKuerzel.FieldName = "Kuerzel"
        Me.colKuerzel.Name = "colKuerzel"
        Me.colKuerzel.Visible = True
        Me.colKuerzel.VisibleIndex = 0
        Me.colKuerzel.Width = 103
        '
        'colBezeichnung
        '
        Me.colBezeichnung.FieldName = "Bezeichnung"
        Me.colBezeichnung.Name = "colBezeichnung"
        Me.colBezeichnung.Visible = True
        Me.colBezeichnung.VisibleIndex = 1
        Me.colBezeichnung.Width = 392
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.Location = New System.Drawing.Point(348, 337)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(115, 28)
        Me.btnAbbrechen.TabIndex = 2
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'frmLaender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 377)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.btnOkay)
        Me.Name = "frmLaender"
        Me.Text = "Länder"
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents LandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grd As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colKuerzel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBezeichnung As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
End Class
