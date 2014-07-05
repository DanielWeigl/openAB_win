<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.grd = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontaktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuenKontaktErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNachName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Land = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Anrede = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_AkademischerTitel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Berufstitel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Berufsfunktion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Firma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFK_Institution = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMobilTelefon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdresseStrasse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdresseOrt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAdressePLZ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailPrivat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmailFirma = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHomePage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirmas = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.Cursor = System.Windows.Forms.Cursors.Default
        Me.grd.DataSource = Me.KontaktBindingSource
        Me.grd.Location = New System.Drawing.Point(12, 100)
        Me.grd.MainView = Me.GridView1
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(1065, 449)
        Me.grd.TabIndex = 0
        Me.grd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colVorName, Me.colNachName, Me.colFK_Land, Me.colFK_Anrede, Me.colFK_AkademischerTitel, Me.colFK_Berufstitel, Me.colFK_Berufsfunktion, Me.colFK_Firma, Me.colFK_Institution, Me.colTelefon, Me.colMobilTelefon, Me.colAdresseStrasse, Me.colAdresseOrt, Me.colAdressePLZ, Me.colEmailPrivat, Me.colEmailFirma, Me.colHomePage, Me.colFirmas})
        Me.GridView1.GridControl = Me.grd
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.KontaktToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1089, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'KontaktToolStripMenuItem
        '
        Me.KontaktToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuenKontaktErstellenToolStripMenuItem})
        Me.KontaktToolStripMenuItem.Name = "KontaktToolStripMenuItem"
        Me.KontaktToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.KontaktToolStripMenuItem.Text = "Kontakt"
        '
        'NeuenKontaktErstellenToolStripMenuItem
        '
        Me.NeuenKontaktErstellenToolStripMenuItem.Name = "NeuenKontaktErstellenToolStripMenuItem"
        Me.NeuenKontaktErstellenToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.NeuenKontaktErstellenToolStripMenuItem.Text = "Neuen Kontakt erstellen"
        '
        'KontaktBindingSource
        '
        Me.KontaktBindingSource.DataSource = GetType(src.Kontakt)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colVorName
        '
        Me.colVorName.FieldName = "VorName"
        Me.colVorName.Name = "colVorName"
        Me.colVorName.Visible = True
        Me.colVorName.VisibleIndex = 1
        '
        'colNachName
        '
        Me.colNachName.FieldName = "NachName"
        Me.colNachName.Name = "colNachName"
        Me.colNachName.Visible = True
        Me.colNachName.VisibleIndex = 2
        '
        'colFK_Land
        '
        Me.colFK_Land.FieldName = "FK_Land"
        Me.colFK_Land.Name = "colFK_Land"
        Me.colFK_Land.Visible = True
        Me.colFK_Land.VisibleIndex = 3
        '
        'colFK_Anrede
        '
        Me.colFK_Anrede.FieldName = "FK_Anrede"
        Me.colFK_Anrede.Name = "colFK_Anrede"
        Me.colFK_Anrede.Visible = True
        Me.colFK_Anrede.VisibleIndex = 4
        '
        'colFK_AkademischerTitel
        '
        Me.colFK_AkademischerTitel.FieldName = "FK_AkademischerTitel"
        Me.colFK_AkademischerTitel.Name = "colFK_AkademischerTitel"
        Me.colFK_AkademischerTitel.Visible = True
        Me.colFK_AkademischerTitel.VisibleIndex = 5
        '
        'colFK_Berufstitel
        '
        Me.colFK_Berufstitel.FieldName = "FK_Berufstitel"
        Me.colFK_Berufstitel.Name = "colFK_Berufstitel"
        Me.colFK_Berufstitel.Visible = True
        Me.colFK_Berufstitel.VisibleIndex = 7
        '
        'colFK_Berufsfunktion
        '
        Me.colFK_Berufsfunktion.FieldName = "FK_Berufsfunktion"
        Me.colFK_Berufsfunktion.Name = "colFK_Berufsfunktion"
        Me.colFK_Berufsfunktion.Visible = True
        Me.colFK_Berufsfunktion.VisibleIndex = 8
        '
        'colFK_Firma
        '
        Me.colFK_Firma.FieldName = "FK_Firma"
        Me.colFK_Firma.Name = "colFK_Firma"
        Me.colFK_Firma.Visible = True
        Me.colFK_Firma.VisibleIndex = 9
        '
        'colFK_Institution
        '
        Me.colFK_Institution.FieldName = "FK_Institution"
        Me.colFK_Institution.Name = "colFK_Institution"
        Me.colFK_Institution.Visible = True
        Me.colFK_Institution.VisibleIndex = 10
        '
        'colTelefon
        '
        Me.colTelefon.FieldName = "Telefon"
        Me.colTelefon.Name = "colTelefon"
        Me.colTelefon.Visible = True
        Me.colTelefon.VisibleIndex = 11
        '
        'colMobilTelefon
        '
        Me.colMobilTelefon.FieldName = "MobilTelefon"
        Me.colMobilTelefon.Name = "colMobilTelefon"
        Me.colMobilTelefon.Visible = True
        Me.colMobilTelefon.VisibleIndex = 12
        '
        'colAdresseStrasse
        '
        Me.colAdresseStrasse.FieldName = "AdresseStrasse"
        Me.colAdresseStrasse.Name = "colAdresseStrasse"
        Me.colAdresseStrasse.Visible = True
        Me.colAdresseStrasse.VisibleIndex = 13
        '
        'colAdresseOrt
        '
        Me.colAdresseOrt.FieldName = "AdresseOrt"
        Me.colAdresseOrt.Name = "colAdresseOrt"
        Me.colAdresseOrt.Visible = True
        Me.colAdresseOrt.VisibleIndex = 14
        '
        'colAdressePLZ
        '
        Me.colAdressePLZ.FieldName = "AdressePLZ"
        Me.colAdressePLZ.Name = "colAdressePLZ"
        Me.colAdressePLZ.Visible = True
        Me.colAdressePLZ.VisibleIndex = 15
        '
        'colEmailPrivat
        '
        Me.colEmailPrivat.FieldName = "EmailPrivat"
        Me.colEmailPrivat.Name = "colEmailPrivat"
        Me.colEmailPrivat.Visible = True
        Me.colEmailPrivat.VisibleIndex = 16
        '
        'colEmailFirma
        '
        Me.colEmailFirma.FieldName = "EmailFirma"
        Me.colEmailFirma.Name = "colEmailFirma"
        Me.colEmailFirma.Visible = True
        Me.colEmailFirma.VisibleIndex = 17
        '
        'colHomePage
        '
        Me.colHomePage.FieldName = "HomePage"
        Me.colHomePage.Name = "colHomePage"
        Me.colHomePage.Visible = True
        Me.colHomePage.VisibleIndex = 18
        '
        'colFirmas
        '
        Me.colFirmas.Caption = "Firma"
        Me.colFirmas.FieldName = "Firmas.Firma1"
        Me.colFirmas.Name = "colFirmas"
        Me.colFirmas.Visible = True
        Me.colFirmas.VisibleIndex = 6
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 561)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Adress Manager"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KontaktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNachName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Land As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Anrede As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_AkademischerTitel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Berufstitel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Berufsfunktion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Firma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFK_Institution As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMobilTelefon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdresseStrasse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdresseOrt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAdressePLZ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailPrivat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmailFirma As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHomePage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirmas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KontaktToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuenKontaktErstellenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
