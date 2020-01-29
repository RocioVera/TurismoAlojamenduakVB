<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leiho3_ErabiltzaileKudeaketa
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
        Me.btnEzabatu = New System.Windows.Forms.Button()
        Me.btnAldatu = New System.Windows.Forms.Button()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnGehitu = New System.Windows.Forms.Button()
        Me.lblErrorea = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnEzabatu
        '
        Me.btnEzabatu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnEzabatu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEzabatu.Location = New System.Drawing.Point(3, 123)
        Me.btnEzabatu.Name = "btnEzabatu"
        Me.btnEzabatu.Size = New System.Drawing.Size(76, 35)
        Me.btnEzabatu.TabIndex = 2
        Me.btnEzabatu.Text = "Ezabatu"
        Me.btnEzabatu.UseVisualStyleBackColor = False
        '
        'btnAldatu
        '
        Me.btnAldatu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAldatu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAldatu.Location = New System.Drawing.Point(3, 72)
        Me.btnAldatu.Name = "btnAldatu"
        Me.btnAldatu.Size = New System.Drawing.Size(76, 35)
        Me.btnAldatu.TabIndex = 3
        Me.btnAldatu.Text = "Aldatu"
        Me.btnAldatu.UseVisualStyleBackColor = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAtzera.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnAtzera.Location = New System.Drawing.Point(12, 369)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(58, 22)
        Me.btnAtzera.TabIndex = 4
        Me.btnAtzera.Text = "Atzera"
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'btnGehitu
        '
        Me.btnGehitu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnGehitu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGehitu.Location = New System.Drawing.Point(3, 21)
        Me.btnGehitu.Name = "btnGehitu"
        Me.btnGehitu.Size = New System.Drawing.Size(76, 33)
        Me.btnGehitu.TabIndex = 5
        Me.btnGehitu.Text = "Gehitu"
        Me.btnGehitu.UseVisualStyleBackColor = False
        '
        'lblErrorea
        '
        Me.lblErrorea.AutoSize = True
        Me.lblErrorea.BackColor = System.Drawing.Color.Yellow
        Me.lblErrorea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblErrorea.Location = New System.Drawing.Point(-1, 103)
        Me.lblErrorea.Name = "lblErrorea"
        Me.lblErrorea.Size = New System.Drawing.Size(92, 19)
        Me.lblErrorea.TabIndex = 6
        Me.lblErrorea.Text = " Hautatu bat! "
        Me.lblErrorea.Visible = False
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(85, 6)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(572, 397)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Leiho3_ErabiltzaileKudeaketa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._03_BilatuOstatua1
        Me.ClientSize = New System.Drawing.Size(662, 403)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.lblErrorea)
        Me.Controls.Add(Me.btnGehitu)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnAldatu)
        Me.Controls.Add(Me.btnEzabatu)
        Me.MaximizeBox = False
        Me.Name = "Leiho3_ErabiltzaileKudeaketa"
        Me.Text = "OstatuAgrad - Erabiltzaile Kudeaketa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEzabatu As Button
    Friend WithEvents btnAldatu As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents btnGehitu As Button
    Friend WithEvents lblErrorea As Label
    Friend WithEvents ListView1 As ListView
End Class
