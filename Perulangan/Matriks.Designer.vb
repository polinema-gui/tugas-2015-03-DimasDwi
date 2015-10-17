<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
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
        Me.tombol_proses = New System.Windows.Forms.Button()
        Me.label_hasil = New System.Windows.Forms.Label()
        Me.textbox_hasil = New System.Windows.Forms.TextBox()
        Me.textbox_matrik2 = New System.Windows.Forms.TextBox()
        Me.label_matrik2 = New System.Windows.Forms.Label()
        Me.combo_operasi = New System.Windows.Forms.ComboBox()
        Me.label_operasi = New System.Windows.Forms.Label()
        Me.textbox_matrik1 = New System.Windows.Forms.TextBox()
        Me.label_matrik1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tombol_proses
        '
        Me.tombol_proses.Location = New System.Drawing.Point(370, 357)
        Me.tombol_proses.Name = "tombol_proses"
        Me.tombol_proses.Size = New System.Drawing.Size(70, 23)
        Me.tombol_proses.TabIndex = 17
        Me.tombol_proses.Text = "PROSES"
        Me.tombol_proses.UseVisualStyleBackColor = True
        '
        'label_hasil
        '
        Me.label_hasil.AutoSize = True
        Me.label_hasil.Location = New System.Drawing.Point(28, 264)
        Me.label_hasil.Name = "label_hasil"
        Me.label_hasil.Size = New System.Drawing.Size(38, 13)
        Me.label_hasil.TabIndex = 16
        Me.label_hasil.Text = "HASIL"
        '
        'textbox_hasil
        '
        Me.textbox_hasil.Location = New System.Drawing.Point(72, 264)
        Me.textbox_hasil.Multiline = True
        Me.textbox_hasil.Name = "textbox_hasil"
        Me.textbox_hasil.Size = New System.Drawing.Size(368, 76)
        Me.textbox_hasil.TabIndex = 15
        '
        'textbox_matrik2
        '
        Me.textbox_matrik2.Location = New System.Drawing.Point(72, 169)
        Me.textbox_matrik2.Multiline = True
        Me.textbox_matrik2.Name = "textbox_matrik2"
        Me.textbox_matrik2.Size = New System.Drawing.Size(368, 76)
        Me.textbox_matrik2.TabIndex = 14
        '
        'label_matrik2
        '
        Me.label_matrik2.AutoSize = True
        Me.label_matrik2.Location = New System.Drawing.Point(6, 172)
        Me.label_matrik2.Name = "label_matrik2"
        Me.label_matrik2.Size = New System.Drawing.Size(64, 13)
        Me.label_matrik2.TabIndex = 13
        Me.label_matrik2.Text = "MATRIKS 2"
        '
        'combo_operasi
        '
        Me.combo_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_operasi.FormattingEnabled = True
        Me.combo_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.combo_operasi.Location = New System.Drawing.Point(72, 122)
        Me.combo_operasi.Name = "combo_operasi"
        Me.combo_operasi.Size = New System.Drawing.Size(368, 21)
        Me.combo_operasi.TabIndex = 12
        '
        'label_operasi
        '
        Me.label_operasi.AutoSize = True
        Me.label_operasi.Location = New System.Drawing.Point(12, 125)
        Me.label_operasi.Name = "label_operasi"
        Me.label_operasi.Size = New System.Drawing.Size(54, 13)
        Me.label_operasi.TabIndex = 11
        Me.label_operasi.Text = "OPERASI"
        '
        'textbox_matrik1
        '
        Me.textbox_matrik1.Location = New System.Drawing.Point(72, 24)
        Me.textbox_matrik1.Multiline = True
        Me.textbox_matrik1.Name = "textbox_matrik1"
        Me.textbox_matrik1.Size = New System.Drawing.Size(368, 76)
        Me.textbox_matrik1.TabIndex = 10
        '
        'label_matrik1
        '
        Me.label_matrik1.AutoSize = True
        Me.label_matrik1.Location = New System.Drawing.Point(7, 27)
        Me.label_matrik1.Name = "label_matrik1"
        Me.label_matrik1.Size = New System.Drawing.Size(64, 13)
        Me.label_matrik1.TabIndex = 9
        Me.label_matrik1.Text = "MATRIKS 1"
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 402)
        Me.Controls.Add(Me.tombol_proses)
        Me.Controls.Add(Me.label_hasil)
        Me.Controls.Add(Me.textbox_hasil)
        Me.Controls.Add(Me.textbox_matrik2)
        Me.Controls.Add(Me.label_matrik2)
        Me.Controls.Add(Me.combo_operasi)
        Me.Controls.Add(Me.label_operasi)
        Me.Controls.Add(Me.textbox_matrik1)
        Me.Controls.Add(Me.label_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tombol_proses As System.Windows.Forms.Button
    Friend WithEvents label_hasil As System.Windows.Forms.Label
    Friend WithEvents textbox_hasil As System.Windows.Forms.TextBox
    Friend WithEvents textbox_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents label_matrik2 As System.Windows.Forms.Label
    Friend WithEvents combo_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents label_operasi As System.Windows.Forms.Label
    Friend WithEvents textbox_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents label_matrik1 As System.Windows.Forms.Label
End Class
