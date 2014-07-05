<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditKontakt
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
        Dim AdresseOrtLabel1 As System.Windows.Forms.Label
        Dim AdressePLZLabel As System.Windows.Forms.Label
        Dim AdresseStrasseLabel As System.Windows.Forms.Label
        Dim HomePageLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim EmailPrivatLabel As System.Windows.Forms.Label
        Dim EmailFirmaLabel As System.Windows.Forms.Label
        Dim MobilTelefonLabel As System.Windows.Forms.Label
        Dim NachNameLabel As System.Windows.Forms.Label
        Dim VorNameLabel1 As System.Windows.Forms.Label
        Dim AkademischerTitel1Label As System.Windows.Forms.Label
        Dim BezeichnungLabel As System.Windows.Forms.Label
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.AdresseOrtTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdressePLZTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresseStrasseTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbLand = New System.Windows.Forms.ComboBox()
        Me.LandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.AkademischerTitel1ComboBox = New System.Windows.Forms.ComboBox()
        Me.AkademischerTitelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HomePageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailPrivatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailFirmaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MobilTelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NachNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VorNameTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        AdresseOrtLabel1 = New System.Windows.Forms.Label()
        AdressePLZLabel = New System.Windows.Forms.Label()
        AdresseStrasseLabel = New System.Windows.Forms.Label()
        HomePageLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        EmailPrivatLabel = New System.Windows.Forms.Label()
        EmailFirmaLabel = New System.Windows.Forms.Label()
        MobilTelefonLabel = New System.Windows.Forms.Label()
        NachNameLabel = New System.Windows.Forms.Label()
        VorNameLabel1 = New System.Windows.Forms.Label()
        AkademischerTitel1Label = New System.Windows.Forms.Label()
        BezeichnungLabel = New System.Windows.Forms.Label()
        CType(Me.AdresseOrtTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdressePLZTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresseStrasseTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AkademischerTitelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailPrivatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailFirmaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobilTelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NachNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorNameTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdresseOrtLabel1
        '
        AdresseOrtLabel1.AutoSize = True
        AdresseOrtLabel1.Location = New System.Drawing.Point(40, 69)
        AdresseOrtLabel1.Name = "AdresseOrtLabel1"
        AdresseOrtLabel1.Size = New System.Drawing.Size(65, 13)
        AdresseOrtLabel1.TabIndex = 18
        AdresseOrtLabel1.Text = "Adresse Ort:"
        '
        'AdressePLZLabel
        '
        AdressePLZLabel.AutoSize = True
        AdressePLZLabel.Location = New System.Drawing.Point(34, 97)
        AdressePLZLabel.Name = "AdressePLZLabel"
        AdressePLZLabel.Size = New System.Drawing.Size(71, 13)
        AdressePLZLabel.TabIndex = 19
        AdressePLZLabel.Text = "Adresse PLZ:"
        '
        'AdresseStrasseLabel
        '
        AdresseStrasseLabel.AutoSize = True
        AdresseStrasseLabel.Location = New System.Drawing.Point(19, 39)
        AdresseStrasseLabel.Name = "AdresseStrasseLabel"
        AdresseStrasseLabel.Size = New System.Drawing.Size(86, 13)
        AdresseStrasseLabel.TabIndex = 20
        AdresseStrasseLabel.Text = "Adresse Strasse:"
        '
        'HomePageLabel
        '
        HomePageLabel.AutoSize = True
        HomePageLabel.Location = New System.Drawing.Point(46, 184)
        HomePageLabel.Name = "HomePageLabel"
        HomePageLabel.Size = New System.Drawing.Size(66, 13)
        HomePageLabel.TabIndex = 41
        HomePageLabel.Text = "Home Page:"
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(66, 80)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 39
        TelefonLabel.Text = "Telefon:"
        '
        'EmailPrivatLabel
        '
        EmailPrivatLabel.AutoSize = True
        EmailPrivatLabel.Location = New System.Drawing.Point(47, 158)
        EmailPrivatLabel.Name = "EmailPrivatLabel"
        EmailPrivatLabel.Size = New System.Drawing.Size(65, 13)
        EmailPrivatLabel.TabIndex = 37
        EmailPrivatLabel.Text = "Email Privat:"
        '
        'EmailFirmaLabel
        '
        EmailFirmaLabel.AutoSize = True
        EmailFirmaLabel.Location = New System.Drawing.Point(49, 132)
        EmailFirmaLabel.Name = "EmailFirmaLabel"
        EmailFirmaLabel.Size = New System.Drawing.Size(63, 13)
        EmailFirmaLabel.TabIndex = 36
        EmailFirmaLabel.Text = "Email Firma:"
        '
        'MobilTelefonLabel
        '
        MobilTelefonLabel.AutoSize = True
        MobilTelefonLabel.Location = New System.Drawing.Point(38, 106)
        MobilTelefonLabel.Name = "MobilTelefonLabel"
        MobilTelefonLabel.Size = New System.Drawing.Size(74, 13)
        MobilTelefonLabel.TabIndex = 33
        MobilTelefonLabel.Text = "Mobil Telefon:"
        '
        'NachNameLabel
        '
        NachNameLabel.AutoSize = True
        NachNameLabel.Location = New System.Drawing.Point(45, 54)
        NachNameLabel.Name = "NachNameLabel"
        NachNameLabel.Size = New System.Drawing.Size(67, 13)
        NachNameLabel.TabIndex = 31
        NachNameLabel.Text = "Nach Name:"
        '
        'VorNameLabel1
        '
        VorNameLabel1.AutoSize = True
        VorNameLabel1.Location = New System.Drawing.Point(55, 28)
        VorNameLabel1.Name = "VorNameLabel1"
        VorNameLabel1.Size = New System.Drawing.Size(57, 13)
        VorNameLabel1.TabIndex = 30
        VorNameLabel1.Text = "Vor Name:"
        '
        'AkademischerTitel1Label
        '
        AkademischerTitel1Label.AutoSize = True
        AkademischerTitel1Label.Location = New System.Drawing.Point(6, 210)
        AkademischerTitel1Label.Name = "AkademischerTitel1Label"
        AkademischerTitel1Label.Size = New System.Drawing.Size(100, 13)
        AkademischerTitel1Label.TabIndex = 43
        AkademischerTitel1Label.Text = "Akademischer Titel:"
        '
        'BezeichnungLabel
        '
        BezeichnungLabel.AutoSize = True
        BezeichnungLabel.Location = New System.Drawing.Point(71, 127)
        BezeichnungLabel.Name = "BezeichnungLabel"
        BezeichnungLabel.Size = New System.Drawing.Size(34, 13)
        BezeichnungLabel.TabIndex = 23
        BezeichnungLabel.Text = "Land:"
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSpeichern.Location = New System.Drawing.Point(645, 276)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(107, 28)
        Me.btnSpeichern.TabIndex = 2
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAbbrechen.Location = New System.Drawing.Point(532, 276)
        Me.btnAbbrechen.Name = "btnAbbrechen"
        Me.btnAbbrechen.Size = New System.Drawing.Size(107, 28)
        Me.btnAbbrechen.TabIndex = 3
        Me.btnAbbrechen.Text = "Abbrechen"
        Me.btnAbbrechen.UseVisualStyleBackColor = True
        '
        'AdresseOrtTextEdit1
        '
        Me.AdresseOrtTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdresseOrt", True))
        Me.AdresseOrtTextEdit1.Location = New System.Drawing.Point(111, 66)
        Me.AdresseOrtTextEdit1.Name = "AdresseOrtTextEdit1"
        Me.AdresseOrtTextEdit1.Size = New System.Drawing.Size(161, 20)
        Me.AdresseOrtTextEdit1.TabIndex = 19
        '
        'KontaktBindingSource
        '
        Me.KontaktBindingSource.DataSource = GetType(src.Kontakt)
        '
        'AdressePLZTextEdit
        '
        Me.AdressePLZTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdressePLZ", True))
        Me.AdressePLZTextEdit.Location = New System.Drawing.Point(111, 94)
        Me.AdressePLZTextEdit.Name = "AdressePLZTextEdit"
        Me.AdressePLZTextEdit.Size = New System.Drawing.Size(161, 20)
        Me.AdressePLZTextEdit.TabIndex = 20
        '
        'AdresseStrasseTextEdit
        '
        Me.AdresseStrasseTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdresseStrasse", True))
        Me.AdresseStrasseTextEdit.Location = New System.Drawing.Point(111, 36)
        Me.AdresseStrasseTextEdit.Name = "AdresseStrasseTextEdit"
        Me.AdresseStrasseTextEdit.Size = New System.Drawing.Size(161, 20)
        Me.AdresseStrasseTextEdit.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(BezeichnungLabel)
        Me.GroupBox1.Controls.Add(Me.cmbLand)
        Me.GroupBox1.Controls.Add(Me.AdresseOrtTextEdit1)
        Me.GroupBox1.Controls.Add(AdresseOrtLabel1)
        Me.GroupBox1.Controls.Add(Me.AdressePLZTextEdit)
        Me.GroupBox1.Controls.Add(AdressePLZLabel)
        Me.GroupBox1.Controls.Add(Me.AdresseStrasseTextEdit)
        Me.GroupBox1.Controls.Add(AdresseStrasseLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(421, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 224)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adressdaten"
        '
        'cmbLand
        '
        Me.cmbLand.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.KontaktBindingSource, "FK_Land", True))
        Me.cmbLand.DataSource = Me.LandBindingSource
        Me.cmbLand.DisplayMember = "Bezeichnung"
        Me.cmbLand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLand.FormattingEnabled = True
        Me.cmbLand.Location = New System.Drawing.Point(111, 124)
        Me.cmbLand.Name = "cmbLand"
        Me.cmbLand.Size = New System.Drawing.Size(161, 21)
        Me.cmbLand.TabIndex = 24
        Me.cmbLand.ValueMember = "ID"
        '
        'LandBindingSource
        '
        Me.LandBindingSource.DataSource = GetType(src.Land)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(AkademischerTitel1Label)
        Me.GroupBox2.Controls.Add(Me.AkademischerTitel1ComboBox)
        Me.GroupBox2.Controls.Add(HomePageLabel)
        Me.GroupBox2.Controls.Add(Me.HomePageTextEdit)
        Me.GroupBox2.Controls.Add(TelefonLabel)
        Me.GroupBox2.Controls.Add(Me.TelefonTextEdit)
        Me.GroupBox2.Controls.Add(EmailPrivatLabel)
        Me.GroupBox2.Controls.Add(Me.EmailPrivatTextEdit)
        Me.GroupBox2.Controls.Add(EmailFirmaLabel)
        Me.GroupBox2.Controls.Add(Me.EmailFirmaTextEdit)
        Me.GroupBox2.Controls.Add(MobilTelefonLabel)
        Me.GroupBox2.Controls.Add(Me.MobilTelefonTextEdit)
        Me.GroupBox2.Controls.Add(NachNameLabel)
        Me.GroupBox2.Controls.Add(Me.NachNameTextEdit)
        Me.GroupBox2.Controls.Add(VorNameLabel1)
        Me.GroupBox2.Controls.Add(Me.VorNameTextEdit1)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 253)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Personendaten"
        '
        'AkademischerTitel1ComboBox
        '
        Me.AkademischerTitel1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AkademischerTitelBindingSource, "AkademischerTitel1", True))
        Me.AkademischerTitel1ComboBox.FormattingEnabled = True
        Me.AkademischerTitel1ComboBox.Location = New System.Drawing.Point(118, 207)
        Me.AkademischerTitel1ComboBox.Name = "AkademischerTitel1ComboBox"
        Me.AkademischerTitel1ComboBox.Size = New System.Drawing.Size(166, 21)
        Me.AkademischerTitel1ComboBox.TabIndex = 44
        '
        'AkademischerTitelBindingSource
        '
        Me.AkademischerTitelBindingSource.DataSource = GetType(src.AkademischerTitel)
        '
        'HomePageTextEdit
        '
        Me.HomePageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "HomePage", True))
        Me.HomePageTextEdit.Location = New System.Drawing.Point(118, 181)
        Me.HomePageTextEdit.Name = "HomePageTextEdit"
        Me.HomePageTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.HomePageTextEdit.TabIndex = 43
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "Telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(118, 77)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.TelefonTextEdit.TabIndex = 42
        '
        'EmailPrivatTextEdit
        '
        Me.EmailPrivatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "EmailPrivat", True))
        Me.EmailPrivatTextEdit.Location = New System.Drawing.Point(118, 155)
        Me.EmailPrivatTextEdit.Name = "EmailPrivatTextEdit"
        Me.EmailPrivatTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.EmailPrivatTextEdit.TabIndex = 40
        '
        'EmailFirmaTextEdit
        '
        Me.EmailFirmaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "EmailFirma", True))
        Me.EmailFirmaTextEdit.Location = New System.Drawing.Point(118, 129)
        Me.EmailFirmaTextEdit.Name = "EmailFirmaTextEdit"
        Me.EmailFirmaTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.EmailFirmaTextEdit.TabIndex = 38
        '
        'MobilTelefonTextEdit
        '
        Me.MobilTelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "MobilTelefon", True))
        Me.MobilTelefonTextEdit.Location = New System.Drawing.Point(118, 103)
        Me.MobilTelefonTextEdit.Name = "MobilTelefonTextEdit"
        Me.MobilTelefonTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.MobilTelefonTextEdit.TabIndex = 35
        '
        'NachNameTextEdit
        '
        Me.NachNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "NachName", True))
        Me.NachNameTextEdit.Location = New System.Drawing.Point(118, 51)
        Me.NachNameTextEdit.Name = "NachNameTextEdit"
        Me.NachNameTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.NachNameTextEdit.TabIndex = 34
        '
        'VorNameTextEdit1
        '
        Me.VorNameTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "VorName", True))
        Me.VorNameTextEdit1.Location = New System.Drawing.Point(118, 25)
        Me.VorNameTextEdit1.Name = "VorNameTextEdit1"
        Me.VorNameTextEdit1.Size = New System.Drawing.Size(166, 20)
        Me.VorNameTextEdit1.TabIndex = 32
        '
        'frmEditKontakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 316)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.GroupBox2)
        Me.MinimumSize = New System.Drawing.Size(698, 310)
        Me.Name = "frmEditKontakt"
        Me.Text = "Kontakt bearbeiten"
        CType(Me.AdresseOrtTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdressePLZTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresseStrasseTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.LandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AkademischerTitelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailPrivatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailFirmaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobilTelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NachNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorNameTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KontaktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents AdresseOrtTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdressePLZTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresseStrasseTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents HomePageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailPrivatTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailFirmaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MobilTelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NachNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VorNameTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AkademischerTitel1ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AkademischerTitelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LandBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbLand As System.Windows.Forms.ComboBox
End Class
