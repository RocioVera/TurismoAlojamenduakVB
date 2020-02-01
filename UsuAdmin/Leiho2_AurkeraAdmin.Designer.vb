<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leiho2_AurkeraAdmin
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Button1.Location = New System.Drawing.Point(48, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 44)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Erabiltzaileak"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Button2.Location = New System.Drawing.Point(48, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ostatuak"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(314, 356)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 83)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "BUKATU"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.Button4.Location = New System.Drawing.Point(48, 185)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(209, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Erreserbak"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(176, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 256)
        Me.Panel1.TabIndex = 9
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAtzera.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtzera.Location = New System.Drawing.Point(12, 19)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(76, 28)
        Me.btnAtzera.TabIndex = 4
        Me.btnAtzera.Text = "Hasi saioa"
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'Leiho2_AurkeraAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._01_SartuBezeroa
        Me.ClientSize = New System.Drawing.Size(625, 357)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.MaximizeBox = False
        Me.Name = "Leiho2_AurkeraAdmin"
        Me.Text = "OstatuAgrad - Administratzailea"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAtzera As Button
End Class
