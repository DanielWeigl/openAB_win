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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.KontaktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSpeichern = New System.Windows.Forms.Button()
        Me.btnAbbrechen = New System.Windows.Forms.Button()
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vorname"
        '
        'tbName
        '
        Me.tbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KontaktBindingSource, "VorName", True))
        Me.tbName.Location = New System.Drawing.Point(78, 18)
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
        'frmEditKontakt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 272)
        Me.Controls.Add(Me.btnAbbrechen)
        Me.Controls.Add(Me.btnSpeichern)
        Me.Controls.Add(Me.tbName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEditKontakt"
        Me.Text = "Kontakt bearbeiten"
        CType(Me.KontaktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbName As System.Windows.Forms.TextBox
    Friend WithEvents KontaktBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSpeichern As System.Windows.Forms.Button
    Friend WithEvents btnAbbrechen As System.Windows.Forms.Button
End Class
