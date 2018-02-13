<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Instalacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Instalacao))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lb_Inicio = New System.Windows.Forms.Label()
        Me.Lb_Sub = New System.Windows.Forms.Label()
        Me.Btn_Iniciar_Instalacao = New System.Windows.Forms.Button()
        Me.Pn1 = New System.Windows.Forms.Panel()
        Me.Lab_Validacao = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Txt_Produt_Key = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Avancar = New System.Windows.Forms.Button()
        Me.Pn2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Local2 = New System.Windows.Forms.TextBox()
        Me.Check_Data = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Folder_Pesq = New System.Windows.Forms.FolderBrowserDialog()
        Me.Btn_Avancar2 = New System.Windows.Forms.Button()
        Me.Pn3 = New System.Windows.Forms.Panel()
        Me.Progress_Instalacao = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Folder_Pesq2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Bt_Cancelar = New System.Windows.Forms.Button()
        Me.Bt_Iniciar = New System.Windows.Forms.Button()
        Me.Pn_Fechar = New System.Windows.Forms.Panel()
        Me.Pn_Mini = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pn3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(198, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Lb_Inicio
        '
        Me.Lb_Inicio.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Inicio.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Inicio.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lb_Inicio.Location = New System.Drawing.Point(131, 180)
        Me.Lb_Inicio.Name = "Lb_Inicio"
        Me.Lb_Inicio.Size = New System.Drawing.Size(342, 55)
        Me.Lb_Inicio.TabIndex = 1
        Me.Lb_Inicio.Text = "Olá, obrigado por adquirir um dos produtos Fourkey"
        Me.Lb_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lb_Sub
        '
        Me.Lb_Sub.BackColor = System.Drawing.Color.Transparent
        Me.Lb_Sub.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Sub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Lb_Sub.Location = New System.Drawing.Point(91, 228)
        Me.Lb_Sub.Name = "Lb_Sub"
        Me.Lb_Sub.Size = New System.Drawing.Size(405, 35)
        Me.Lb_Sub.TabIndex = 2
        Me.Lb_Sub.Text = "Vamos começar? Clique no botão 'Iniciar Instalação' abaixo"
        Me.Lb_Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Iniciar_Instalacao
        '
        Me.Btn_Iniciar_Instalacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Iniciar_Instalacao.Location = New System.Drawing.Point(499, 313)
        Me.Btn_Iniciar_Instalacao.Name = "Btn_Iniciar_Instalacao"
        Me.Btn_Iniciar_Instalacao.Size = New System.Drawing.Size(105, 23)
        Me.Btn_Iniciar_Instalacao.TabIndex = 3
        Me.Btn_Iniciar_Instalacao.Text = "Iniciar Instalação"
        Me.Btn_Iniciar_Instalacao.UseVisualStyleBackColor = True
        '
        'Pn1
        '
        Me.Pn1.BackColor = System.Drawing.Color.White
        Me.Pn1.Controls.Add(Me.Lab_Validacao)
        Me.Pn1.Controls.Add(Me.PictureBox2)
        Me.Pn1.Controls.Add(Me.Txt_Produt_Key)
        Me.Pn1.Controls.Add(Me.Label3)
        Me.Pn1.Location = New System.Drawing.Point(30, 6)
        Me.Pn1.Name = "Pn1"
        Me.Pn1.Size = New System.Drawing.Size(14, 17)
        Me.Pn1.TabIndex = 4
        Me.Pn1.Visible = False
        '
        'Lab_Validacao
        '
        Me.Lab_Validacao.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Validacao.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lab_Validacao.Location = New System.Drawing.Point(18, 170)
        Me.Lab_Validacao.Name = "Lab_Validacao"
        Me.Lab_Validacao.Size = New System.Drawing.Size(555, 40)
        Me.Lab_Validacao.TabIndex = 5
        Me.Lab_Validacao.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 19)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Txt_Produt_Key
        '
        Me.Txt_Produt_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Produt_Key.Location = New System.Drawing.Point(18, 146)
        Me.Txt_Produt_Key.MaxLength = 34
        Me.Txt_Produt_Key.Name = "Txt_Produt_Key"
        Me.Txt_Produt_Key.Size = New System.Drawing.Size(555, 21)
        Me.Txt_Produt_Key.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(14, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 46)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Entre com o Product Key fornecido, para a validação do seu sistema"
        '
        'Btn_Avancar
        '
        Me.Btn_Avancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Avancar.Enabled = False
        Me.Btn_Avancar.Location = New System.Drawing.Point(499, 313)
        Me.Btn_Avancar.Name = "Btn_Avancar"
        Me.Btn_Avancar.Size = New System.Drawing.Size(105, 23)
        Me.Btn_Avancar.TabIndex = 5
        Me.Btn_Avancar.Text = "Avançar"
        Me.Btn_Avancar.UseVisualStyleBackColor = True
        Me.Btn_Avancar.Visible = False
        '
        'Pn2
        '
        Me.Pn2.BackColor = System.Drawing.Color.White
        Me.Pn2.Controls.Add(Me.Button3)
        Me.Pn2.Controls.Add(Me.Label9)
        Me.Pn2.Controls.Add(Me.Txt_Local2)
        Me.Pn2.Controls.Add(Me.Check_Data)
        Me.Pn2.Controls.Add(Me.CheckBox1)
        Me.Pn2.Controls.Add(Me.Label7)
        Me.Pn2.Controls.Add(Me.Label6)
        Me.Pn2.Controls.Add(Me.PictureBox4)
        Me.Pn2.Controls.Add(Me.PictureBox3)
        Me.Pn2.Controls.Add(Me.Label5)
        Me.Pn2.Location = New System.Drawing.Point(12, 29)
        Me.Pn2.Name = "Pn2"
        Me.Pn2.Size = New System.Drawing.Size(78, 40)
        Me.Pn2.TabIndex = 6
        Me.Pn2.Visible = False
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(533, 184)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(303, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Escolha o local onde os arquivos serão salvos"
        '
        'Txt_Local2
        '
        Me.Txt_Local2.Enabled = False
        Me.Txt_Local2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Local2.Location = New System.Drawing.Point(17, 184)
        Me.Txt_Local2.MaxLength = 34
        Me.Txt_Local2.Name = "Txt_Local2"
        Me.Txt_Local2.Size = New System.Drawing.Size(511, 21)
        Me.Txt_Local2.TabIndex = 13
        Me.Txt_Local2.Text = "C:\Walle"
        '
        'Check_Data
        '
        Me.Check_Data.AutoSize = True
        Me.Check_Data.Checked = True
        Me.Check_Data.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Check_Data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Check_Data.Location = New System.Drawing.Point(365, 123)
        Me.Check_Data.Name = "Check_Data"
        Me.Check_Data.Size = New System.Drawing.Size(15, 14)
        Me.Check_Data.TabIndex = 10
        Me.Check_Data.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(221, 123)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(321, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Walle Client Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Walle Client"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(330, 63)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(81, 38)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(186, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(81, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(145, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Selecione os aplicativos de instalação"
        '
        'Btn_Avancar2
        '
        Me.Btn_Avancar2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Avancar2.Location = New System.Drawing.Point(236, 313)
        Me.Btn_Avancar2.Name = "Btn_Avancar2"
        Me.Btn_Avancar2.Size = New System.Drawing.Size(169, 23)
        Me.Btn_Avancar2.TabIndex = 7
        Me.Btn_Avancar2.Text = "Iniciar Instalação"
        Me.Btn_Avancar2.UseVisualStyleBackColor = True
        Me.Btn_Avancar2.Visible = False
        '
        'Pn3
        '
        Me.Pn3.BackColor = System.Drawing.Color.White
        Me.Pn3.Controls.Add(Me.Progress_Instalacao)
        Me.Pn3.Controls.Add(Me.Label8)
        Me.Pn3.Location = New System.Drawing.Point(12, 12)
        Me.Pn3.Name = "Pn3"
        Me.Pn3.Size = New System.Drawing.Size(12, 14)
        Me.Pn3.TabIndex = 13
        Me.Pn3.Visible = False
        '
        'Progress_Instalacao
        '
        Me.Progress_Instalacao.Location = New System.Drawing.Point(18, 126)
        Me.Progress_Instalacao.Maximum = 10
        Me.Progress_Instalacao.Name = "Progress_Instalacao"
        Me.Progress_Instalacao.Size = New System.Drawing.Size(555, 23)
        Me.Progress_Instalacao.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Instalando Walle Client"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(94, 313)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 19)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Bt_Cancelar
        '
        Me.Bt_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Cancelar.Location = New System.Drawing.Point(12, 313)
        Me.Bt_Cancelar.Name = "Bt_Cancelar"
        Me.Bt_Cancelar.Size = New System.Drawing.Size(173, 23)
        Me.Bt_Cancelar.TabIndex = 15
        Me.Bt_Cancelar.Text = "Finalizar"
        Me.Bt_Cancelar.UseVisualStyleBackColor = True
        Me.Bt_Cancelar.Visible = False
        '
        'Bt_Iniciar
        '
        Me.Bt_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bt_Iniciar.Location = New System.Drawing.Point(430, 313)
        Me.Bt_Iniciar.Name = "Bt_Iniciar"
        Me.Bt_Iniciar.Size = New System.Drawing.Size(173, 23)
        Me.Bt_Iniciar.TabIndex = 16
        Me.Bt_Iniciar.Text = "Iniciar Walle"
        Me.Bt_Iniciar.UseVisualStyleBackColor = True
        Me.Bt_Iniciar.Visible = False
        '
        'Pn_Fechar
        '
        Me.Pn_Fechar.BackColor = System.Drawing.Color.Transparent
        Me.Pn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pn_Fechar.Location = New System.Drawing.Point(598, 2)
        Me.Pn_Fechar.Name = "Pn_Fechar"
        Me.Pn_Fechar.Size = New System.Drawing.Size(16, 18)
        Me.Pn_Fechar.TabIndex = 17
        '
        'Pn_Mini
        '
        Me.Pn_Mini.BackColor = System.Drawing.Color.Transparent
        Me.Pn_Mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pn_Mini.Location = New System.Drawing.Point(576, 2)
        Me.Pn_Mini.Name = "Pn_Mini"
        Me.Pn_Mini.Size = New System.Drawing.Size(16, 18)
        Me.Pn_Mini.TabIndex = 18
        '
        'Frm_Instalacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(616, 345)
        Me.Controls.Add(Me.Pn_Mini)
        Me.Controls.Add(Me.Pn_Fechar)
        Me.Controls.Add(Me.Bt_Iniciar)
        Me.Controls.Add(Me.Bt_Cancelar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Pn3)
        Me.Controls.Add(Me.Btn_Avancar2)
        Me.Controls.Add(Me.Pn2)
        Me.Controls.Add(Me.Btn_Avancar)
        Me.Controls.Add(Me.Pn1)
        Me.Controls.Add(Me.Btn_Iniciar_Instalacao)
        Me.Controls.Add(Me.Lb_Sub)
        Me.Controls.Add(Me.Lb_Inicio)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Instalacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instalador Walle"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn1.ResumeLayout(False)
        Me.Pn1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn2.ResumeLayout(False)
        Me.Pn2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pn3.ResumeLayout(False)
        Me.Pn3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lb_Inicio As System.Windows.Forms.Label
    Friend WithEvents Lb_Sub As System.Windows.Forms.Label
    Friend WithEvents Btn_Iniciar_Instalacao As System.Windows.Forms.Button
    Friend WithEvents Pn1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Produt_Key As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Avancar As System.Windows.Forms.Button
    Friend WithEvents Lab_Validacao As System.Windows.Forms.Label
    Friend WithEvents Pn2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Check_Data As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Folder_Pesq As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Btn_Avancar2 As System.Windows.Forms.Button
    Friend WithEvents Pn3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Progress_Instalacao As System.Windows.Forms.ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_Local2 As TextBox
    Friend WithEvents Folder_Pesq2 As FolderBrowserDialog
    Friend WithEvents Bt_Cancelar As Button
    Friend WithEvents Bt_Iniciar As Button
    Friend WithEvents Pn_Fechar As Panel
    Friend WithEvents Pn_Mini As Panel
End Class
