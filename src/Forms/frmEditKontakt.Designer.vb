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
        Dim AdresseOrtLabel1 As System.Windows.Forms.Label
        Dim AdressePLZLabel As System.Windows.Forms.Label
        Dim AdresseStrasseLabel As System.Windows.Forms.Label
        Dim VorNameLabel1 As System.Windows.Forms.Label
        Dim NachNameLabel As System.Windows.Forms.Label
        Dim MobilTelefonLabel As System.Windows.Forms.Label
        Dim EmailFirmaLabel As System.Windows.Forms.Label
        Dim EmailPrivatLabel As System.Windows.Forms.Label
        Dim TelefonLabel As System.Windows.Forms.Label
        Dim HomePageLabel As System.Windows.Forms.Label
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.AdresseOrtTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.AdressePLZTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AdresseStrasseTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VorNameTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.NachNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MobilTelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmailFirmaTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.EmailPrivatTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TelefonTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HomePageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource()
        AdresseOrtLabel1 = New System.Windows.Forms.Label()
        AdressePLZLabel = New System.Windows.Forms.Label()
        AdresseStrasseLabel = New System.Windows.Forms.Label()
        VorNameLabel1 = New System.Windows.Forms.Label()
        NachNameLabel = New System.Windows.Forms.Label()
        MobilTelefonLabel = New System.Windows.Forms.Label()
        EmailFirmaLabel = New System.Windows.Forms.Label()
        EmailPrivatLabel = New System.Windows.Forms.Label()
        TelefonLabel = New System.Windows.Forms.Label()
        HomePageLabel = New System.Windows.Forms.Label()
        CType(Me.AdresseOrtTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdressePLZTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresseStrasseTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorNameTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NachNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobilTelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmailFirmaTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmailPrivatTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'VorNameLabel1
        '
        VorNameLabel1.AutoSize = True
        VorNameLabel1.Location = New System.Drawing.Point(51, 29)
        VorNameLabel1.Name = "VorNameLabel1"
        VorNameLabel1.Size = New System.Drawing.Size(57, 13)
        VorNameLabel1.TabIndex = 21
        VorNameLabel1.Text = "Vor Name:"
        '
        'NachNameLabel
        '
        NachNameLabel.AutoSize = True
        NachNameLabel.Location = New System.Drawing.Point(41, 59)
        NachNameLabel.Name = "NachNameLabel"
        NachNameLabel.Size = New System.Drawing.Size(67, 13)
        NachNameLabel.TabIndex = 22
        NachNameLabel.Text = "Nach Name:"
        '
        'MobilTelefonLabel
        '
        MobilTelefonLabel.AutoSize = True
        MobilTelefonLabel.Location = New System.Drawing.Point(34, 122)
        MobilTelefonLabel.Name = "MobilTelefonLabel"
        MobilTelefonLabel.Size = New System.Drawing.Size(74, 13)
        MobilTelefonLabel.TabIndex = 23
        MobilTelefonLabel.Text = "Mobil Telefon:"
        '
        'btnSpeichern
        '
        Me.btnSpeichern.Location = New System.Drawing.Point(525, 232)
        Me.btnSpeichern.Name = "btnSpeichern"
        Me.btnSpeichern.Size = New System.Drawing.Size(107, 28)
        Me.btnSpeichern.TabIndex = 2
        Me.btnSpeichern.Text = "Speichern"
        Me.btnSpeichern.UseVisualStyleBackColor = True
        '
        'btnAbbrechen
        '
        Me.btnAbbrechen.Location = New System.Drawing.Point(412, 232)
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
        Me.AdresseOrtTextEdit1.Size = New System.Drawing.Size(160, 20)
        Me.AdresseOrtTextEdit1.TabIndex = 19
        '
        'AdressePLZTextEdit
        '
        Me.AdressePLZTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdressePLZ", True))
        Me.AdressePLZTextEdit.Location = New System.Drawing.Point(111, 94)
        Me.AdressePLZTextEdit.Name = "AdressePLZTextEdit"
        Me.AdressePLZTextEdit.Size = New System.Drawing.Size(78, 20)
        Me.AdressePLZTextEdit.TabIndex = 20
        '
        'AdresseStrasseTextEdit
        '
        Me.AdresseStrasseTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdresseStrasse", True))
        Me.AdresseStrasseTextEdit.Location = New System.Drawing.Point(111, 36)
        Me.AdresseStrasseTextEdit.Name = "AdresseStrasseTextEdit"
        Me.AdresseStrasseTextEdit.Size = New System.Drawing.Size(160, 20)
        Me.AdresseStrasseTextEdit.TabIndex = 21
        '
        'VorNameTextEdit1
        '
        Me.VorNameTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "VorName", True))
        Me.VorNameTextEdit1.Location = New System.Drawing.Point(114, 26)
        Me.VorNameTextEdit1.Name = "VorNameTextEdit1"
        Me.VorNameTextEdit1.Size = New System.Drawing.Size(166, 20)
        Me.VorNameTextEdit1.TabIndex = 22
        '
        'NachNameTextEdit
        '
        Me.NachNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "NachName", True))
        Me.NachNameTextEdit.Location = New System.Drawing.Point(114, 56)
        Me.NachNameTextEdit.Name = "NachNameTextEdit"
        Me.NachNameTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.NachNameTextEdit.TabIndex = 23
        '
        'MobilTelefonTextEdit
        '
        Me.MobilTelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "MobilTelefon", True))
        Me.MobilTelefonTextEdit.Location = New System.Drawing.Point(114, 119)
        Me.MobilTelefonTextEdit.Name = "MobilTelefonTextEdit"
        Me.MobilTelefonTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.MobilTelefonTextEdit.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AdresseOrtTextEdit1)
        Me.GroupBox1.Controls.Add(AdresseOrtLabel1)
        Me.GroupBox1.Controls.Add(Me.AdressePLZTextEdit)
        Me.GroupBox1.Controls.Add(AdressePLZLabel)
        Me.GroupBox1.Controls.Add(Me.AdresseStrasseTextEdit)
        Me.GroupBox1.Controls.Add(AdresseStrasseLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(412, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 182)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adressdaten"
        '
        'EmailFirmaLabel
        '
        EmailFirmaLabel.AutoSize = True
        EmailFirmaLabel.Location = New System.Drawing.Point(45, 151)
        EmailFirmaLabel.Name = "EmailFirmaLabel"
        EmailFirmaLabel.Size = New System.Drawing.Size(63, 13)
        EmailFirmaLabel.TabIndex = 25
        EmailFirmaLabel.Text = "Email Firma:"
        '
        'EmailFirmaTextEdit
        '
        Me.EmailFirmaTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "EmailFirma", True))
        Me.EmailFirmaTextEdit.Location = New System.Drawing.Point(114, 148)
        Me.EmailFirmaTextEdit.Name = "EmailFirmaTextEdit"
        Me.EmailFirmaTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.EmailFirmaTextEdit.TabIndex = 26
        '
        'EmailPrivatLabel
        '
        EmailPrivatLabel.AutoSize = True
        EmailPrivatLabel.Location = New System.Drawing.Point(43, 181)
        EmailPrivatLabel.Name = "EmailPrivatLabel"
        EmailPrivatLabel.Size = New System.Drawing.Size(65, 13)
        EmailPrivatLabel.TabIndex = 26
        EmailPrivatLabel.Text = "Email Privat:"
        '
        'EmailPrivatTextEdit
        '
        Me.EmailPrivatTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "EmailPrivat", True))
        Me.EmailPrivatTextEdit.Location = New System.Drawing.Point(114, 178)
        Me.EmailPrivatTextEdit.Name = "EmailPrivatTextEdit"
        Me.EmailPrivatTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.EmailPrivatTextEdit.TabIndex = 27
        '
        'TelefonLabel
        '
        TelefonLabel.AutoSize = True
        TelefonLabel.Location = New System.Drawing.Point(62, 92)
        TelefonLabel.Name = "TelefonLabel"
        TelefonLabel.Size = New System.Drawing.Size(46, 13)
        TelefonLabel.TabIndex = 27
        TelefonLabel.Text = "Telefon:"
        '
        'TelefonTextEdit
        '
        Me.TelefonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "Telefon", True))
        Me.TelefonTextEdit.Location = New System.Drawing.Point(114, 89)
        Me.TelefonTextEdit.Name = "TelefonTextEdit"
        Me.TelefonTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.TelefonTextEdit.TabIndex = 28
        '
        'HomePageLabel
        '
        HomePageLabel.AutoSize = True
        HomePageLabel.Location = New System.Drawing.Point(42, 207)
        HomePageLabel.Name = "HomePageLabel"
        HomePageLabel.Size = New System.Drawing.Size(66, 13)
        HomePageLabel.TabIndex = 28
        HomePageLabel.Text = "Home Page:"
        '
        'HomePageTextEdit
        '
        Me.HomePageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "HomePage", True))
        Me.HomePageTextEdit.Location = New System.Drawing.Point(114, 204)
        Me.HomePageTextEdit.Name = "HomePageTextEdit"
        Me.HomePageTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.HomePageTextEdit.TabIndex = 29
        '
        'KontaktBindingSource
        '
        Me.KontaktBindingSource.DataSource = GetType(src.Kontakt)
        '
        'frmEditKontakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 283)
        Me.Controls.Add(HomePageLabel)
        Me.Controls.Add(Me.HomePageTextEdit)
        Me.Controls.Add(TelefonLabel)
        Me.Controls.Add(Me.TelefonTextEdit)
        Me.Controls.Add(EmailPrivatLabel)
        Me.Controls.Add(Me.EmailPrivatTextEdit)
        Me.Controls.Add(EmailFirmaLabel)
        Me.Controls.Add(Me.EmailFirmaTextEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(MobilTelefonLabel)
        Me.Controls.Add(Me.MobilTelefonTextEdit)
        Me.Controls.Add(NachNameLabel)
        Me.Controls.Add(Me.NachNameTextEdit)
        Me.Controls.Add(VorNameLabel1)
        Me.Controls.Add(Me.VorNameTextEdit1)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Name = "frmEditKontakt"
        Me.Text = "Kontakt bearbeiten"
        CType(Me.AdresseOrtTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdressePLZTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresseStrasseTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorNameTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NachNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobilTelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmailFirmaTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmailPrivatTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TelefonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomePageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KontaktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents AdresseOrtTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdressePLZTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdresseStrasseTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VorNameTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NachNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MobilTelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents EmailFirmaTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmailPrivatTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TelefonTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HomePageTextEdit As DevExpress.XtraEditors.TextEdit
End Class
