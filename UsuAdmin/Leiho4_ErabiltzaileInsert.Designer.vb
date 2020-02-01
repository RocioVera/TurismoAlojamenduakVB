<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leiho4_ErabiltzaileInsert
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbBaimena = New System.Windows.Forms.ComboBox()
        Me.nan = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblNan = New System.Windows.Forms.Label()
        Me.lblIzena = New System.Windows.Forms.Label()
        Me.txtTlf = New System.Windows.Forms.TextBox()
        Me.lblAbizenak = New System.Windows.Forms.Label()
        Me.txtIzena = New System.Windows.Forms.TextBox()
        Me.lblBaimena = New System.Windows.Forms.Label()
        Me.txtAbizena = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefonoa = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Button1.Location = New System.Drawing.Point(12, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 33)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Ezeztatu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(89, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 28)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Erabiltzailea gehitu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pasahitza:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbBaimena)
        Me.Panel1.Controls.Add(Me.nan)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lblNan)
        Me.Panel1.Controls.Add(Me.lblIzena)
        Me.Panel1.Controls.Add(Me.txtTlf)
        Me.Panel1.Controls.Add(Me.lblAbizenak)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtIzena)
        Me.Panel1.Controls.Add(Me.lblBaimena)
        Me.Panel1.Controls.Add(Me.txtAbizena)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblTelefonoa)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Location = New System.Drawing.Point(357, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 359)
        Me.Panel1.TabIndex = 16
        '
        'cbBaimena
        '
        Me.cbBaimena.DisplayMember = "67"
        Me.cbBaimena.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbBaimena.FormattingEnabled = True
        Me.cbBaimena.Items.AddRange(New Object() {"Bezero normala", "Administratzailea"})
        Me.cbBaimena.Location = New System.Drawing.Point(106, 184)
        Me.cbBaimena.Name = "cbBaimena"
        Me.cbBaimena.Size = New System.Drawing.Size(151, 23)
        Me.cbBaimena.TabIndex = 84
        '
        'nan
        '
        Me.nan.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nan.Location = New System.Drawing.Point(106, 13)
        Me.nan.MaxLength = 8
        Me.nan.Name = "nan"
        Me.nan.Size = New System.Drawing.Size(151, 26)
        Me.nan.TabIndex = 10
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtPass.Location = New System.Drawing.Point(106, 143)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(151, 26)
        Me.txtPass.TabIndex = 13
        '
        'lblNan
        '
        Me.lblNan.AutoSize = True
        Me.lblNan.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblNan.Location = New System.Drawing.Point(58, 20)
        Me.lblNan.Name = "lblNan"
        Me.lblNan.Size = New System.Drawing.Size(38, 19)
        Me.lblNan.TabIndex = 0
        Me.lblNan.Text = "Nan:"
        '
        'lblIzena
        '
        Me.lblIzena.AutoSize = True
        Me.lblIzena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblIzena.Location = New System.Drawing.Point(57, 53)
        Me.lblIzena.Name = "lblIzena"
        Me.lblIzena.Size = New System.Drawing.Size(44, 19)
        Me.lblIzena.TabIndex = 1
        Me.lblIzena.Text = "Izena:"
        '
        'txtTlf
        '
        Me.txtTlf.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtTlf.Location = New System.Drawing.Point(106, 281)
        Me.txtTlf.MaxLength = 9
        Me.txtTlf.Name = "txtTlf"
        Me.txtTlf.Size = New System.Drawing.Size(151, 26)
        Me.txtTlf.TabIndex = 11
        '
        'lblAbizenak
        '
        Me.lblAbizenak.AutoSize = True
        Me.lblAbizenak.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblAbizenak.Location = New System.Drawing.Point(36, 100)
        Me.lblAbizenak.Name = "lblAbizenak"
        Me.lblAbizenak.Size = New System.Drawing.Size(69, 19)
        Me.lblAbizenak.TabIndex = 3
        Me.lblAbizenak.Text = "Abizenak:"
        '
        'txtIzena
        '
        Me.txtIzena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtIzena.Location = New System.Drawing.Point(106, 50)
        Me.txtIzena.MaxLength = 50
        Me.txtIzena.Name = "txtIzena"
        Me.txtIzena.Size = New System.Drawing.Size(151, 26)
        Me.txtIzena.TabIndex = 10
        '
        'lblBaimena
        '
        Me.lblBaimena.AutoSize = True
        Me.lblBaimena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblBaimena.Location = New System.Drawing.Point(40, 188)
        Me.lblBaimena.Name = "lblBaimena"
        Me.lblBaimena.Size = New System.Drawing.Size(64, 19)
        Me.lblBaimena.TabIndex = 4
        Me.lblBaimena.Text = "Baimena:"
        '
        'txtAbizena
        '
        Me.txtAbizena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtAbizena.Location = New System.Drawing.Point(106, 97)
        Me.txtAbizena.MaxLength = 50
        Me.txtAbizena.Name = "txtAbizena"
        Me.txtAbizena.Size = New System.Drawing.Size(151, 26)
        Me.txtAbizena.TabIndex = 9
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(55, 235)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 19)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblTelefonoa
        '
        Me.lblTelefonoa.AutoSize = True
        Me.lblTelefonoa.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblTelefonoa.Location = New System.Drawing.Point(34, 284)
        Me.lblTelefonoa.Name = "lblTelefonoa"
        Me.lblTelefonoa.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefonoa.TabIndex = 6
        Me.lblTelefonoa.Text = "Telefonoa:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(106, 232)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(151, 26)
        Me.txtEmail.TabIndex = 7
        '
        'Leiho4_ErabiltzaileInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._04_Insert
        Me.ClientSize = New System.Drawing.Size(675, 379)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.Name = "Leiho4_ErabiltzaileInsert"
        Me.Text = "OstatuAgrad - Administratzailea  - Erabiltzailea gehitu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNan As Label
    Friend WithEvents lblIzena As Label
    Friend WithEvents txtTlf As TextBox
    Friend WithEvents lblAbizenak As Label
    Friend WithEvents txtIzena As TextBox
    Friend WithEvents lblBaimena As Label
    Friend WithEvents txtAbizena As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefonoa As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents nan As TextBox
    Friend WithEvents cbBaimena As ComboBox
End Class
