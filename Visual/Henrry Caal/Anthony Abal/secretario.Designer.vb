<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class secretario
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_roll = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_mostrar = New System.Windows.Forms.Button()
        Me.dtg1 = New System.Windows.Forms.DataGridView()
        Me.btn_regresar = New System.Windows.Forms.Button()
        Me.btn_insertar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.OliveDrab
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Roll"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.OliveDrab
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre"
        '
        'btn_buscar
        '
        Me.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_buscar.Location = New System.Drawing.Point(273, 410)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(84, 23)
        Me.btn_buscar.TabIndex = 20
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(216, 77)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(174, 20)
        Me.txt_nombre.TabIndex = 18
        '
        'txt_roll
        '
        Me.txt_roll.Location = New System.Drawing.Point(216, 151)
        Me.txt_roll.Name = "txt_roll"
        Me.txt_roll.Size = New System.Drawing.Size(174, 20)
        Me.txt_roll.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Subheading", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(211, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 50)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Secretario"
        '
        'btn_mostrar
        '
        Me.btn_mostrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mostrar.Location = New System.Drawing.Point(518, 410)
        Me.btn_mostrar.Name = "btn_mostrar"
        Me.btn_mostrar.Size = New System.Drawing.Size(84, 23)
        Me.btn_mostrar.TabIndex = 13
        Me.btn_mostrar.Text = "Mostrar"
        Me.btn_mostrar.UseVisualStyleBackColor = True
        '
        'dtg1
        '
        Me.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg1.Location = New System.Drawing.Point(65, 193)
        Me.dtg1.Name = "dtg1"
        Me.dtg1.Size = New System.Drawing.Size(537, 211)
        Me.dtg1.TabIndex = 12
        '
        'btn_regresar
        '
        Me.btn_regresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_regresar.Location = New System.Drawing.Point(575, 12)
        Me.btn_regresar.Name = "btn_regresar"
        Me.btn_regresar.Size = New System.Drawing.Size(71, 25)
        Me.btn_regresar.TabIndex = 23
        Me.btn_regresar.Text = "Regresar"
        Me.btn_regresar.UseVisualStyleBackColor = True
        '
        'btn_insertar
        '
        Me.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_insertar.Location = New System.Drawing.Point(65, 410)
        Me.btn_insertar.Name = "btn_insertar"
        Me.btn_insertar.Size = New System.Drawing.Size(84, 23)
        Me.btn_insertar.TabIndex = 24
        Me.btn_insertar.Text = "Insertar"
        Me.btn_insertar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.OliveDrab
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(105, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Contraseña"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(216, 115)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(174, 20)
        Me.txt_contraseña.TabIndex = 25
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Anthony_Abal.My.Resources.Resources._360473
        Me.PictureBox3.Location = New System.Drawing.Point(460, 75)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(114, 95)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'secretario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(667, 466)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.btn_insertar)
        Me.Controls.Add(Me.btn_regresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.txt_roll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_mostrar)
        Me.Controls.Add(Me.dtg1)
        Me.Name = "secretario"
        Me.Text = "secretario"
        CType(Me.dtg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_roll As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_mostrar As Button
    Friend WithEvents dtg1 As DataGridView
    Friend WithEvents btn_regresar As Button
    Friend WithEvents btn_insertar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_contraseña As TextBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
