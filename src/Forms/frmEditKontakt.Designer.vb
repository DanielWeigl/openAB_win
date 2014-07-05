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
        Dim AdresseOrtLabel As System.Windows.Forms.Label
        Dim VorNameLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Berufstitel = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.AdresseOrtTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VorNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        AdresseOrtLabel = New System.Windows.Forms.Label()
        VorNameLabel = New System.Windows.Forms.Label()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdresseOrtTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vorname"
        '
        'tbName
        '
        Me.tbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontaktBindingSource, "VorName", True))
        Me.tbName.Location = New System.Drawing.Point(134, 55)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(169, 20)
        Me.tbName.TabIndex = 1
        '
        'KontaktBindingSource
        '
        Me.KontaktBindingSource.DataSource = GetType(src.Kontakt)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nachname"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(133, 88)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Anrede"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(133, 122)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(170, 20)
        Me.TextBox2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Akademischer Titel"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(133, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(169, 20)
        Me.TextBox3.TabIndex = 9
        '
        'Berufstitel
        '
        Me.Berufstitel.AutoSize = True
        Me.Berufstitel.Location = New System.Drawing.Point(74, 159)
        Me.Berufstitel.Name = "Berufstitel"
        Me.Berufstitel.Size = New System.Drawing.Size(53, 13)
        Me.Berufstitel.TabIndex = 10
        Me.Berufstitel.Text = "Berufstitel"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(134, 154)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(167, 20)
        Me.TextBox4.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Berufsfunktion"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(133, 189)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(169, 20)
        Me.TextBox5.TabIndex = 13
        '
        'AdresseOrtLabel
        '
        AdresseOrtLabel.AutoSize = True
        AdresseOrtLabel.Location = New System.Drawing.Point(407, 111)
        AdresseOrtLabel.Name = "AdresseOrtLabel"
        AdresseOrtLabel.Size = New System.Drawing.Size(65, 13)
        AdresseOrtLabel.TabIndex = 14
        AdresseOrtLabel.Text = "Adresse Ort:"
        '
        'AdresseOrtTextEdit
        '
        Me.AdresseOrtTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "AdresseOrt", True))
        Me.AdresseOrtTextEdit.Location = New System.Drawing.Point(478, 108)
        Me.AdresseOrtTextEdit.Name = "AdresseOrtTextEdit"
        Me.AdresseOrtTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AdresseOrtTextEdit.TabIndex = 15
        '
        'VorNameLabel
        '
        VorNameLabel.AutoSize = True
        VorNameLabel.Location = New System.Drawing.Point(415, 137)
        VorNameLabel.Name = "VorNameLabel"
        VorNameLabel.Size = New System.Drawing.Size(57, 13)
        VorNameLabel.TabIndex = 16
        VorNameLabel.Text = "Vor Name:"
        '
        'VorNameTextEdit
        '
        Me.VorNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.KontaktBindingSource, "VorName", True))
        Me.VorNameTextEdit.Location = New System.Drawing.Point(478, 134)
        Me.VorNameTextEdit.Name = "VorNameTextEdit"
        Me.VorNameTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.VorNameTextEdit.TabIndex = 17
        '
        'frmEditKontakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 280)
        Me.Controls.Add(VorNameLabel)
        Me.Controls.Add(Me.VorNameTextEdit)
        Me.Controls.Add(AdresseOrtLabel)
        Me.Controls.Add(Me.AdresseOrtTextEdit)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Berufstitel)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditKontakt"
        Me.Text = "Kontakt bearbeiten"
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdresseOrtTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents KontaktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Berufstitel As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents AdresseOrtTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VorNameTextEdit As DevExpress.XtraEditors.TextEdit
End Class
