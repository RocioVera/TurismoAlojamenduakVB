<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leiho2_AukeraBezeroNormala
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
        Me.components = New System.ComponentModel.Container()
        Me.btnOstatuakIkusi = New System.Windows.Forms.Button()
        Me.btnErabiltzaileakIkusi = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOstatuakIkusi
        '
        Me.btnOstatuakIkusi.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnOstatuakIkusi.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.btnOstatuakIkusi.Location = New System.Drawing.Point(41, 29)
        Me.btnOstatuakIkusi.Name = "btnOstatuakIkusi"
        Me.btnOstatuakIkusi.Size = New System.Drawing.Size(192, 45)
        Me.btnOstatuakIkusi.TabIndex = 0
        Me.btnOstatuakIkusi.Text = "Ostatuak Ikusi"
        Me.btnOstatuakIkusi.UseVisualStyleBackColor = False
        '
        'btnErabiltzaileakIkusi
        '
        Me.btnErabiltzaileakIkusi.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnErabiltzaileakIkusi.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.btnErabiltzaileakIkusi.Location = New System.Drawing.Point(41, 106)
        Me.btnErabiltzaileakIkusi.Name = "btnErabiltzaileakIkusi"
        Me.btnErabiltzaileakIkusi.Size = New System.Drawing.Size(192, 47)
        Me.btnErabiltzaileakIkusi.TabIndex = 1
        Me.btnErabiltzaileakIkusi.Text = "Erabiltzaileak Ikusi"
        Me.btnErabiltzaileakIkusi.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnOstatuakIkusi)
        Me.Panel1.Controls.Add(Me.btnErabiltzaileakIkusi)
        Me.Panel1.Location = New System.Drawing.Point(188, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 177)
        Me.Panel1.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnAtzera.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtzera.Location = New System.Drawing.Point(12, 12)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(76, 28)
        Me.btnAtzera.TabIndex = 5
        Me.btnAtzera.Text = "Hasi saioa"
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'Leiho2_AukeraBezeroNormala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._01_SartuBezeroa
        Me.ClientSize = New System.Drawing.Size(625, 357)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Leiho2_AukeraBezeroNormala"
        Me.Text = "OstatuAgrad"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOstatuakIkusi As Button
    Friend WithEvents btnErabiltzaileakIkusi As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnAtzera As Button
End Class
