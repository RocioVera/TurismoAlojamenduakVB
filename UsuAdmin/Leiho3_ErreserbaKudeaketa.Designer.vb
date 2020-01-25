<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leiho3_ErreserbaKudeaketa
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
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.btnAldatu = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'btnEzabatu
        '
        Me.btnEzabatu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnEzabatu.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnEzabatu.Location = New System.Drawing.Point(3, 47)
        Me.btnEzabatu.Name = "btnEzabatu"
        Me.btnEzabatu.Size = New System.Drawing.Size(76, 29)
        Me.btnEzabatu.TabIndex = 1
        Me.btnEzabatu.Text = "Ezabatu"
        Me.btnEzabatu.UseVisualStyleBackColor = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAtzera.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnAtzera.Location = New System.Drawing.Point(3, 362)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(76, 29)
        Me.btnAtzera.TabIndex = 2
        Me.btnAtzera.Text = "Atzera"
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'btnAldatu
        '
        Me.btnAldatu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAldatu.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnAldatu.Location = New System.Drawing.Point(3, 12)
        Me.btnAldatu.Name = "btnAldatu"
        Me.btnAldatu.Size = New System.Drawing.Size(76, 29)
        Me.btnAldatu.TabIndex = 3
        Me.btnAldatu.Text = "Aldatu"
        Me.btnAldatu.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(85, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(572, 388)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'Leiho3_ErreserbaKudeaketa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._03_BilatuOstatua1
        Me.ClientSize = New System.Drawing.Size(662, 403)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAldatu)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnEzabatu)
        Me.MaximizeBox = False
        Me.Name = "Leiho3_ErreserbaKudeaketa"
        Me.Text = "OstatuAgrad - Erreserba kudeaketa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEzabatu As Button
    Friend WithEvents btnAtzera As Button
    Friend WithEvents btnAldatu As Button
    Friend WithEvents ListView1 As ListView
End Class
