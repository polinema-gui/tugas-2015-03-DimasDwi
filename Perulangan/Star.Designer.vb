<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Star
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
        Me.combo_pola = New System.Windows.Forms.ComboBox()
        Me.textbox_hasil = New System.Windows.Forms.TextBox()
        Me.tombol_proses = New System.Windows.Forms.Button()
        Me.textbox_baris = New System.Windows.Forms.TextBox()
        Me.label_baris = New System.Windows.Forms.Label()
        Me.label_pola = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'combo_pola
        '
        Me.combo_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_pola.FormattingEnabled = True
        Me.combo_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.combo_pola.Location = New System.Drawing.Point(59, 11)
        Me.combo_pola.Name = "combo_pola"
        Me.combo_pola.Size = New System.Drawing.Size(386, 21)
        Me.combo_pola.TabIndex = 7
        '
        'textbox_hasil
        '
        Me.textbox_hasil.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textbox_hasil.Location = New System.Drawing.Point(22, 108)
        Me.textbox_hasil.Multiline = True
        Me.textbox_hasil.Name = "textbox_hasil"
        Me.textbox_hasil.Size = New System.Drawing.Size(423, 305)
        Me.textbox_hasil.TabIndex = 11
        '
        'tombol_proses
        '
        Me.tombol_proses.Location = New System.Drawing.Point(374, 61)
        Me.tombol_proses.Name = "tombol_proses"
        Me.tombol_proses.Size = New System.Drawing.Size(71, 23)
        Me.tombol_proses.TabIndex = 10
        Me.tombol_proses.Text = "PROSES"
        Me.tombol_proses.UseVisualStyleBackColor = True
        '
        'textbox_baris
        '
        Me.textbox_baris.Location = New System.Drawing.Point(63, 63)
        Me.textbox_baris.Name = "textbox_baris"
        Me.textbox_baris.Size = New System.Drawing.Size(305, 20)
        Me.textbox_baris.TabIndex = 9
        '
        'label_baris
        '
        Me.label_baris.AutoSize = True
        Me.label_baris.Location = New System.Drawing.Point(12, 65)
        Me.label_baris.Name = "label_baris"
        Me.label_baris.Size = New System.Drawing.Size(45, 13)
        Me.label_baris.TabIndex = 8
        Me.label_baris.Text = "BARIS :"
        '
        'label_pola
        '
        Me.label_pola.AutoSize = True
        Me.label_pola.Location = New System.Drawing.Point(12, 14)
        Me.label_pola.Name = "label_pola"
        Me.label_pola.Size = New System.Drawing.Size(41, 13)
        Me.label_pola.TabIndex = 6
        Me.label_pola.Text = "POLA :"
        '
        'Star
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.combo_pola)
        Me.Controls.Add(Me.textbox_hasil)
        Me.Controls.Add(Me.tombol_proses)
        Me.Controls.Add(Me.textbox_baris)
        Me.Controls.Add(Me.label_baris)
        Me.Controls.Add(Me.label_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Star"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_pola As System.Windows.Forms.ComboBox
    Friend WithEvents textbox_hasil As System.Windows.Forms.TextBox
    Friend WithEvents tombol_proses As System.Windows.Forms.Button
    Friend WithEvents textbox_baris As System.Windows.Forms.TextBox
    Friend WithEvents label_baris As System.Windows.Forms.Label
    Friend WithEvents label_pola As System.Windows.Forms.Label
End Class
