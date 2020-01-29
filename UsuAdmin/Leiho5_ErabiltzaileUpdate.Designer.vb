<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leiho5_ErabiltzaileUpdate
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNan = New System.Windows.Forms.Label()
        Me.lblIzena = New System.Windows.Forms.Label()
        Me.lblAbizena = New System.Windows.Forms.Label()
        Me.lblBaimena = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefonoa = New System.Windows.Forms.Label()
        Me.abizena = New System.Windows.Forms.TextBox()
        Me.izena = New System.Windows.Forms.TextBox()
        Me.btnGorde = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbBaimena = New System.Windows.Forms.ComboBox()
        Me.nan = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lblIzena.Location = New System.Drawing.Point(57, 65)
        Me.lblIzena.Name = "lblIzena"
        Me.lblIzena.Size = New System.Drawing.Size(44, 19)
        Me.lblIzena.TabIndex = 1
        Me.lblIzena.Text = "Izena:"
        '
        'lblAbizena
        '
        Me.lblAbizena.AutoSize = True
        Me.lblAbizena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblAbizena.Location = New System.Drawing.Point(40, 112)
        Me.lblAbizena.Name = "lblAbizena"
        Me.lblAbizena.Size = New System.Drawing.Size(61, 19)
        Me.lblAbizena.TabIndex = 3
        Me.lblAbizena.Text = "Abizena:"
        '
        'lblBaimena
        '
        Me.lblBaimena.AutoSize = True
        Me.lblBaimena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblBaimena.Location = New System.Drawing.Point(40, 160)
        Me.lblBaimena.Name = "lblBaimena"
        Me.lblBaimena.Size = New System.Drawing.Size(64, 19)
        Me.lblBaimena.TabIndex = 4
        Me.lblBaimena.Text = "Baimena:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(55, 207)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 19)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'lblTelefonoa
        '
        Me.lblTelefonoa.AutoSize = True
        Me.lblTelefonoa.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblTelefonoa.Location = New System.Drawing.Point(34, 256)
        Me.lblTelefonoa.Name = "lblTelefonoa"
        Me.lblTelefonoa.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefonoa.TabIndex = 6
        Me.lblTelefonoa.Text = "Telefonoa:"
        '
        'abizena
        '
        Me.abizena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.abizena.Location = New System.Drawing.Point(106, 109)
        Me.abizena.MaxLength = 50
        Me.abizena.Name = "abizena"
        Me.abizena.Size = New System.Drawing.Size(271, 26)
        Me.abizena.TabIndex = 9
        '
        'izena
        '
        Me.izena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.izena.Location = New System.Drawing.Point(106, 62)
        Me.izena.MaxLength = 50
        Me.izena.Name = "izena"
        Me.izena.Size = New System.Drawing.Size(271, 26)
        Me.izena.TabIndex = 10
        '
        'btnGorde
        '
        Me.btnGorde.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnGorde.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnGorde.Location = New System.Drawing.Point(143, 294)
        Me.btnGorde.Name = "btnGorde"
        Me.btnGorde.Size = New System.Drawing.Size(138, 35)
        Me.btnGorde.TabIndex = 12
        Me.btnGorde.Text = "Erabiltzailea aldatu"
        Me.btnGorde.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(11, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 26)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Ezeztatu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbBaimena)
        Me.Panel1.Controls.Add(Me.nan)
        Me.Panel1.Controls.Add(Me.lblNan)
        Me.Panel1.Controls.Add(Me.btnGorde)
        Me.Panel1.Controls.Add(Me.lblIzena)
        Me.Panel1.Controls.Add(Me.telefono)
        Me.Panel1.Controls.Add(Me.lblAbizena)
        Me.Panel1.Controls.Add(Me.izena)
        Me.Panel1.Controls.Add(Me.lblBaimena)
        Me.Panel1.Controls.Add(Me.abizena)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblTelefonoa)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Location = New System.Drawing.Point(257, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 342)
        Me.Panel1.TabIndex = 14
        '
        'cbBaimena
        '
        Me.cbBaimena.DisplayMember = "67"
        Me.cbBaimena.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbBaimena.FormattingEnabled = True
        Me.cbBaimena.Items.AddRange(New Object() {"Bezero normala", "Administratzailea", "Gonbidatua"})
        Me.cbBaimena.Location = New System.Drawing.Point(106, 156)
        Me.cbBaimena.Name = "cbBaimena"
        Me.cbBaimena.Size = New System.Drawing.Size(271, 23)
        Me.cbBaimena.TabIndex = 85
        '
        'nan
        '
        Me.nan.AutoSize = True
        Me.nan.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.nan.Location = New System.Drawing.Point(102, 20)
        Me.nan.Name = "nan"
        Me.nan.Size = New System.Drawing.Size(35, 19)
        Me.nan.TabIndex = 12
        Me.nan.Text = "Nan"
        '
        'telefono
        '
        Me.telefono.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.telefono.Location = New System.Drawing.Point(106, 253)
        Me.telefono.MaxLength = 9
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(271, 26)
        Me.telefono.TabIndex = 11
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.email.Location = New System.Drawing.Point(106, 204)
        Me.email.MaxLength = 50
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(271, 26)
        Me.email.TabIndex = 7
        '
        'Leiho5_ErabiltzaileUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._04_Aldatu
        Me.ClientSize = New System.Drawing.Size(662, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.Name = "Leiho5_ErabiltzaileUpdate"
        Me.Text = "OstatuAgrad - Erabiltzaile aldaketa"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNan As Label
    Friend WithEvents lblIzena As Label
    Friend WithEvents lblAbizena As Label
    Friend WithEvents lblBaimena As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefonoa As Label
    Friend WithEvents abizena As TextBox
    Friend WithEvents izena As TextBox
    Friend WithEvents btnGorde As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents telefono As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents nan As Label
    Friend WithEvents cbBaimena As ComboBox
End Class
