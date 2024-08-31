<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tela_recep
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tela_recep))
        Me.btn_rgs_idoso = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_info_idoso = New System.Windows.Forms.Button()
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_rgs_idoso
        '
        Me.btn_rgs_idoso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rgs_idoso.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_rgs_idoso.Image = CType(resources.GetObject("btn_rgs_idoso.Image"), System.Drawing.Image)
        Me.btn_rgs_idoso.Location = New System.Drawing.Point(129, 169)
        Me.btn_rgs_idoso.Name = "btn_rgs_idoso"
        Me.btn_rgs_idoso.Size = New System.Drawing.Size(189, 72)
        Me.btn_rgs_idoso.TabIndex = 1
        Me.btn_rgs_idoso.Text = "REGISTRAR PACIENTE"
        Me.btn_rgs_idoso.UseVisualStyleBackColor = True
        '
        'btn_voltar
        '
        Me.btn_voltar.BackColor = System.Drawing.Color.Transparent
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.Location = New System.Drawing.Point(371, 253)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(52, 53)
        Me.btn_voltar.TabIndex = 15
        Me.btn_voltar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(354, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 57)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'btn_info_idoso
        '
        Me.btn_info_idoso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_info_idoso.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_info_idoso.Image = CType(resources.GetObject("btn_info_idoso.Image"), System.Drawing.Image)
        Me.btn_info_idoso.Location = New System.Drawing.Point(129, 77)
        Me.btn_info_idoso.Name = "btn_info_idoso"
        Me.btn_info_idoso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_info_idoso.Size = New System.Drawing.Size(189, 72)
        Me.btn_info_idoso.TabIndex = 0
        Me.btn_info_idoso.Text = "VERIFICAR INFORMAÇÕES DOS PACIENTES"
        Me.btn_info_idoso.UseVisualStyleBackColor = True
        '
        'tela_recep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(435, 317)
        Me.Controls.Add(Me.btn_info_idoso)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.btn_rgs_idoso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "tela_recep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VETUS SOFT      ══ • 『 GERENCIAR PACIENTES 』 • ══"
        CType(Me.btn_voltar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_rgs_idoso As Button
    Friend WithEvents btn_voltar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_info_idoso As Button
End Class
