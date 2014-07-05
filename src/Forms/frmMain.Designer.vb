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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grd = New DevExpress.XtraGrid.GridControl()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grdview = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KontaktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuenKontaktErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LänderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkademischerTitelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BerufstitelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grd
        '
        Me.grd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd.Cursor = System.Windows.Forms.Cursors.Default
        Me.grd.DataSource = Me.KontaktBindingSource
        Me.grd.Location = New System.Drawing.Point(12, 77)
        Me.grd.MainView = Me.grdview
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(1019, 528)
        Me.grd.TabIndex = 0
        Me.grd.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grdview})
        '
        'KontaktBindingSource
        '
        Me.KontaktBindingSource.DataSource = GetType(src.Kontakt)
        '
        'grdview
        '
        Me.grdview.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colVorName, Me.colNachName, Me.colFK_Land, Me.colFK_Anrede, Me.colFK_AkademischerTitel, Me.colFK_Berufstitel, Me.colFK_Berufsfunktion, Me.colFK_Firma, Me.colFK_Institution, Me.colTelefon, Me.colMobilTelefon, Me.colAdresseStrasse, Me.colAdresseOrt, Me.colAdressePLZ, Me.colEmailPrivat, Me.colEmailFirma, Me.colHomePage, Me.colFirmas})
        Me.grdview.GridControl = Me.grd
        Me.grdview.Name = "grdview"
        Me.grdview.OptionsView.ShowAutoFilterRow = True
        Me.grdview.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 52
        '
        'colVorName
        '
        Me.colVorName.FieldName = "VorName"
        Me.colVorName.Name = "colVorName"
        Me.colVorName.Visible = True
        Me.colVorName.VisibleIndex = 1
        Me.colVorName.Width = 52
        '
        'colNachName
        '
        Me.colNachName.FieldName = "NachName"
        Me.colNachName.Name = "colNachName"
        Me.colNachName.Visible = True
        Me.colNachName.VisibleIndex = 2
        Me.colNachName.Width = 52
        '
        'colFK_Land
        '
        Me.colFK_Land.Caption = "Land"
        Me.colFK_Land.FieldName = "Land.Kuerzel"
        Me.colFK_Land.Name = "colFK_Land"
        Me.colFK_Land.Visible = True
        Me.colFK_Land.VisibleIndex = 3
        Me.colFK_Land.Width = 52
        '
        'colFK_Anrede
        '
        Me.colFK_Anrede.FieldName = "FK_Anrede"
        Me.colFK_Anrede.Name = "colFK_Anrede"
        Me.colFK_Anrede.Visible = True
        Me.colFK_Anrede.VisibleIndex = 4
        Me.colFK_Anrede.Width = 52
        '
        'colFK_AkademischerTitel
        '
        Me.colFK_AkademischerTitel.FieldName = "FK_AkademischerTitel"
        Me.colFK_AkademischerTitel.Name = "colFK_AkademischerTitel"
        Me.colFK_AkademischerTitel.Visible = True
        Me.colFK_AkademischerTitel.VisibleIndex = 5
        Me.colFK_AkademischerTitel.Width = 52
        '
        'colFK_Berufstitel
        '
        Me.colFK_Berufstitel.FieldName = "FK_Berufstitel"
        Me.colFK_Berufstitel.Name = "colFK_Berufstitel"
        Me.colFK_Berufstitel.Visible = True
        Me.colFK_Berufstitel.VisibleIndex = 7
        Me.colFK_Berufstitel.Width = 76
        '
        'colFK_Berufsfunktion
        '
        Me.colFK_Berufsfunktion.FieldName = "FK_Berufsfunktion"
        Me.colFK_Berufsfunktion.Name = "colFK_Berufsfunktion"
        Me.colFK_Berufsfunktion.Visible = True
        Me.colFK_Berufsfunktion.VisibleIndex = 8
        Me.colFK_Berufsfunktion.Width = 49
        '
        'colFK_Firma
        '
        Me.colFK_Firma.FieldName = "FK_Firma"
        Me.colFK_Firma.Name = "colFK_Firma"
        Me.colFK_Firma.Visible = True
        Me.colFK_Firma.VisibleIndex = 9
        Me.colFK_Firma.Width = 49
        '
        'colFK_Institution
        '
        Me.colFK_Institution.FieldName = "FK_Institution"
        Me.colFK_Institution.Name = "colFK_Institution"
        Me.colFK_Institution.Visible = True
        Me.colFK_Institution.VisibleIndex = 10
        Me.colFK_Institution.Width = 49
        '
        'colTelefon
        '
        Me.colTelefon.FieldName = "Telefon"
        Me.colTelefon.Name = "colTelefon"
        Me.colTelefon.Visible = True
        Me.colTelefon.VisibleIndex = 11
        Me.colTelefon.Width = 49
        '
        'colMobilTelefon
        '
        Me.colMobilTelefon.FieldName = "MobilTelefon"
        Me.colMobilTelefon.Name = "colMobilTelefon"
        Me.colMobilTelefon.Visible = True
        Me.colMobilTelefon.VisibleIndex = 12
        Me.colMobilTelefon.Width = 49
        '
        'colAdresseStrasse
        '
        Me.colAdresseStrasse.FieldName = "AdresseStrasse"
        Me.colAdresseStrasse.Name = "colAdresseStrasse"
        Me.colAdresseStrasse.Visible = True
        Me.colAdresseStrasse.VisibleIndex = 13
        Me.colAdresseStrasse.Width = 49
        '
        'colAdresseOrt
        '
        Me.colAdresseOrt.FieldName = "AdresseOrt"
        Me.colAdresseOrt.Name = "colAdresseOrt"
        Me.colAdresseOrt.Visible = True
        Me.colAdresseOrt.VisibleIndex = 14
        Me.colAdresseOrt.Width = 49
        '
        'colAdressePLZ
        '
        Me.colAdressePLZ.FieldName = "AdressePLZ"
        Me.colAdressePLZ.Name = "colAdressePLZ"
        Me.colAdressePLZ.Visible = True
        Me.colAdressePLZ.VisibleIndex = 15
        Me.colAdressePLZ.Width = 49
        '
        'colEmailPrivat
        '
        Me.colEmailPrivat.FieldName = "EmailPrivat"
        Me.colEmailPrivat.Name = "colEmailPrivat"
        Me.colEmailPrivat.Visible = True
        Me.colEmailPrivat.VisibleIndex = 16
        Me.colEmailPrivat.Width = 49
        '
        'colEmailFirma
        '
        Me.colEmailFirma.FieldName = "EmailFirma"
        Me.colEmailFirma.Name = "colEmailFirma"
        Me.colEmailFirma.Visible = True
        Me.colEmailFirma.VisibleIndex = 17
        Me.colEmailFirma.Width = 49
        '
        'colHomePage
        '
        Me.colHomePage.FieldName = "HomePage"
        Me.colHomePage.Name = "colHomePage"
        Me.colHomePage.Visible = True
        Me.colHomePage.VisibleIndex = 18
        Me.colHomePage.Width = 71
        '
        'colFirmas
        '
        Me.colFirmas.Caption = "Firma"
        Me.colFirmas.FieldName = "Firmas.Firma1"
        Me.colFirmas.Name = "colFirmas"
        Me.colFirmas.Visible = True
        Me.colFirmas.VisibleIndex = 6
        Me.colFirmas.Width = 52
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.KontaktToolStripMenuItem, Me.EinstellungenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1043, 24)
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
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LänderToolStripMenuItem, Me.AkademischerTitelToolStripMenuItem, Me.BerufstitelToolStripMenuItem})
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'LänderToolStripMenuItem
        '
        Me.LänderToolStripMenuItem.Name = "LänderToolStripMenuItem"
        Me.LänderToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.LänderToolStripMenuItem.Text = "Länder"
        '
        'AkademischerTitelToolStripMenuItem
        '
        Me.AkademischerTitelToolStripMenuItem.Name = "AkademischerTitelToolStripMenuItem"
        Me.AkademischerTitelToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AkademischerTitelToolStripMenuItem.Text = "Akademischer Titel"
        '
       'BerufstitelToolStripMenuItem
        '
        Me.BerufstitelToolStripMenuItem.Name = "BerufstitelToolStripMenuItem"
        Me.BerufstitelToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.BerufstitelToolStripMenuItem.Text = "Berufstitel"
        '

        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(956, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '

        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1043, 617)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Adress Manager"
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grd As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdview As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents EinstellungenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LänderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AkademischerTitelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BerufstitelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
