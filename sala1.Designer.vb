<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sala1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sala1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_sala1 = New System.Windows.Forms.DataGridView()
        Me.commumbox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_sala1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.commumbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_sala1
        '
        Me.dgv_sala1.AllowUserToAddRows = False
        Me.dgv_sala1.AllowUserToDeleteRows = False
        Me.dgv_sala1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_sala1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_sala1.BackgroundColor = System.Drawing.Color.White
        Me.dgv_sala1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_sala1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sala1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgv_sala1.Location = New System.Drawing.Point(25, 39)
        Me.dgv_sala1.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_sala1.Name = "dgv_sala1"
        Me.dgv_sala1.ReadOnly = True
        Me.dgv_sala1.RowHeadersWidth = 51
        Me.dgv_sala1.RowTemplate.Height = 24
        Me.dgv_sala1.Size = New System.Drawing.Size(967, 285)
        Me.dgv_sala1.TabIndex = 0
        '
        'commumbox
        '
        Me.commumbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.commumbox.BackgroundImage = CType(resources.GetObject("commumbox.BackgroundImage"), System.Drawing.Image)
        Me.commumbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.commumbox.Controls.Add(Me.Label1)
        Me.commumbox.Controls.Add(Me.dgv_sala1)
        Me.commumbox.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commumbox.ForeColor = System.Drawing.Color.White
        Me.commumbox.Location = New System.Drawing.Point(0, -15)
        Me.commumbox.Margin = New System.Windows.Forms.Padding(2)
        Me.commumbox.Name = "commumbox"
        Me.commumbox.Padding = New System.Windows.Forms.Padding(2)
        Me.commumbox.Size = New System.Drawing.Size(1017, 359)
        Me.commumbox.TabIndex = 13
        Me.commumbox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(298, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COTIDIANO DE TODOS OS PACIENTES DA SALA 1"
        '
        'Column1
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "Nº"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column3
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "NOME DO PACIENTE"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 169
        '
        'Column2
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "8:00 - 10:20"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 109
        '
        'Column4
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "10:20 - 12:40"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 117
        '
        'Column5
        '
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "12:40 - 15:00"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 117
        '
        'Column6
        '
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.HeaderText = "15:00 - 17:20"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 117
        '
        'Column7
        '
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column7.HeaderText = "17:20 - 19:40"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 117
        '
        'Column8
        '
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column8.HeaderText = "19:40 - 22:00"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 117
        '
        'sala1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 340)
        Me.Controls.Add(Me.commumbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "sala1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VETUS SOFT       ══════════════════════════════════════════════════════ • 『 SALA " &
    "1 』 • ══════════════════════════════════════════════════════"
        CType(Me.dgv_sala1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.commumbox.ResumeLayout(False)
        Me.commumbox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_sala1 As DataGridView
    Friend WithEvents commumbox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
