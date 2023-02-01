<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label5.Font = New System.Drawing.Font("Sitka Subheading", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(267, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 47)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cliente"
        '
        'btn_mostrar
        '
        Me.btn_mostrar.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_mostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mostrar.Location = New System.Drawing.Point(285, 426)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(84, 23)
        Me.btn_mostrar.TabIndex = 13
        Me.btn_mostrar.Text = "Mostrar"
        Me.btn_mostrar.UseVisualStyleBackColor = False
        '
        'dtg1
        '
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.Location = New System.Drawing.Point(54, 148)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.Size = New System.Drawing.Size(537, 242)
        Me.dtg1.TabIndex = 12
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.Location = New System.Drawing.Point(54, 73)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(84, 23)
        Me.btn_buscar.TabIndex = 21
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(173, 76)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(291, 20)
        Me.txt_nombre.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Anthony_Abal.My.Resources.Resources._11
        Me.PictureBox1.Location = New System.Drawing.Point(492, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(673, 476)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.dtg1)
        Me.Name = "cliente"
        Me.Text = "cliente"
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
