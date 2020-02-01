<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leiho1_InicioSesion
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
        Me.btnHasiSaioa = New System.Windows.Forms.Button()
        Me.txtBezeroa = New System.Windows.Forms.TextBox()
        Me.txtPasahitza = New System.Windows.Forms.TextBox()
        Me.lblKorreoa = New System.Windows.Forms.Label()
        Me.lblPasahitza = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblErrorea = New System.Windows.Forms.Label()
        Me.lblErrorea2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHasiSaioa
        '
        Me.btnHasiSaioa.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnHasiSaioa.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnHasiSaioa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.btnHasiSaioa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnHasiSaioa.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasiSaioa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHasiSaioa.Location = New System.Drawing.Point(66, 186)
        Me.btnHasiSaioa.Name = "btnHasiSaioa"
        Me.btnHasiSaioa.Size = New System.Drawing.Size(113, 34)
        Me.btnHasiSaioa.TabIndex = 0
        Me.btnHasiSaioa.Text = "Hasi saioa"
        Me.btnHasiSaioa.UseVisualStyleBackColor = False
        '
        'txtBezeroa
        '
        Me.txtBezeroa.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBezeroa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBezeroa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBezeroa.Location = New System.Drawing.Point(23, 51)
        Me.txtBezeroa.MaxLength = 8
        Me.txtBezeroa.Name = "txtBezeroa"
        Me.txtBezeroa.Size = New System.Drawing.Size(226, 22)
        Me.txtBezeroa.TabIndex = 1
        Me.txtBezeroa.Text = "11111111"
        '
        'txtPasahitza
        '
        Me.txtPasahitza.AllowDrop = True
        Me.txtPasahitza.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtPasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasahitza.Location = New System.Drawing.Point(23, 129)
        Me.txtPasahitza.Name = "txtPasahitza"
        Me.txtPasahitza.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasahitza.Size = New System.Drawing.Size(226, 29)
        Me.txtPasahitza.TabIndex = 2
        Me.txtPasahitza.Text = "ADMIN"
        '
        'lblKorreoa
        '
        Me.lblKorreoa.AutoSize = True
        Me.lblKorreoa.BackColor = System.Drawing.Color.Transparent
        Me.lblKorreoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKorreoa.Location = New System.Drawing.Point(2, 18)
        Me.lblKorreoa.Name = "lblKorreoa"
        Me.lblKorreoa.Size = New System.Drawing.Size(66, 25)
        Me.lblKorreoa.TabIndex = 3
        Me.lblKorreoa.Text = "NAN:"
        '
        'lblPasahitza
        '
        Me.lblPasahitza.AutoSize = True
        Me.lblPasahitza.BackColor = System.Drawing.Color.Transparent
        Me.lblPasahitza.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPasahitza.Location = New System.Drawing.Point(2, 96)
        Me.lblPasahitza.Name = "lblPasahitza"
        Me.lblPasahitza.Size = New System.Drawing.Size(123, 25)
        Me.lblPasahitza.TabIndex = 4
        Me.lblPasahitza.Text = "Pasahitza:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(65, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(121, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblErrorea)
        Me.Panel1.Controls.Add(Me.lblKorreoa)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnHasiSaioa)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtBezeroa)
        Me.Panel1.Controls.Add(Me.lblPasahitza)
        Me.Panel1.Controls.Add(Me.txtPasahitza)
        Me.Panel1.Location = New System.Drawing.Point(169, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 231)
        Me.Panel1.TabIndex = 8
        '
        'lblErrorea
        '
        Me.lblErrorea.AutoSize = True
        Me.lblErrorea.BackColor = System.Drawing.Color.Transparent
        Me.lblErrorea.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblErrorea.ForeColor = System.Drawing.Color.Red
        Me.lblErrorea.Location = New System.Drawing.Point(17, 161)
        Me.lblErrorea.Name = "lblErrorea"
        Me.lblErrorea.Size = New System.Drawing.Size(115, 22)
        Me.lblErrorea.TabIndex = 8
        Me.lblErrorea.Text = "errore mezua"
        Me.lblErrorea.Visible = False
        '
        'lblErrorea2
        '
        Me.lblErrorea2.AutoSize = True
        Me.lblErrorea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.lblErrorea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblErrorea2.ForeColor = System.Drawing.Color.Red
        Me.lblErrorea2.Location = New System.Drawing.Point(74, 277)
        Me.lblErrorea2.Name = "lblErrorea2"
        Me.lblErrorea2.Size = New System.Drawing.Size(469, 22)
        Me.lblErrorea2.TabIndex = 10
        Me.lblErrorea2.Text = "  Lanean gabiz, oraindik ezin zara sartu, webgunera joan. "
        Me.lblErrorea2.Visible = False
        '
        'Leiho1_InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._01_SartuBezeroa
        Me.ClientSize = New System.Drawing.Size(625, 357)
        Me.Controls.Add(Me.lblErrorea2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Leiho1_InicioSesion"
        Me.Text = "OstatuAgrad - Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHasiSaioa As Button
    Friend WithEvents txtBezeroa As TextBox
    Friend WithEvents txtPasahitza As TextBox
    Friend WithEvents lblKorreoa As Label
    Friend WithEvents lblPasahitza As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblErrorea As Label
    Friend WithEvents lblErrorea2 As Label
End Class
