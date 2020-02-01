<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OstatuakIkusiV2
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHotela = New System.Windows.Forms.Button()
        Me.btnAlbergue = New System.Windows.Forms.Button()
        Me.btnEtxea = New System.Windows.Forms.Button()
        Me.btnAtzera = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(85, 3)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(575, 398)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ERRESERBATU"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(43, 521)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 61)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "BUKATU"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnHotela
        '
        Me.btnHotela.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnHotela.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnHotela.Location = New System.Drawing.Point(3, 42)
        Me.btnHotela.Name = "btnHotela"
        Me.btnHotela.Size = New System.Drawing.Size(76, 30)
        Me.btnHotela.TabIndex = 3
        Me.btnHotela.Text = "Hotela"
        Me.btnHotela.UseVisualStyleBackColor = False
        '
        'btnAlbergue
        '
        Me.btnAlbergue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAlbergue.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnAlbergue.Location = New System.Drawing.Point(3, 78)
        Me.btnAlbergue.Name = "btnAlbergue"
        Me.btnAlbergue.Size = New System.Drawing.Size(76, 30)
        Me.btnAlbergue.TabIndex = 4
        Me.btnAlbergue.Text = "Albergue"
        Me.btnAlbergue.UseVisualStyleBackColor = False
        '
        'btnEtxea
        '
        Me.btnEtxea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnEtxea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnEtxea.Location = New System.Drawing.Point(3, 114)
        Me.btnEtxea.Name = "btnEtxea"
        Me.btnEtxea.Size = New System.Drawing.Size(76, 30)
        Me.btnEtxea.TabIndex = 5
        Me.btnEtxea.Text = "Etxea"
        Me.btnEtxea.UseVisualStyleBackColor = False
        '
        'btnAtzera
        '
        Me.btnAtzera.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnAtzera.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnAtzera.Location = New System.Drawing.Point(3, 362)
        Me.btnAtzera.Name = "btnAtzera"
        Me.btnAtzera.Size = New System.Drawing.Size(76, 29)
        Me.btnAtzera.TabIndex = 7
        Me.btnAtzera.Text = "Atzera"
        Me.btnAtzera.UseVisualStyleBackColor = False
        '
        'Leiho3_OstatuakIkusiN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._03_BilatuOstatua1
        Me.ClientSize = New System.Drawing.Size(662, 403)
        Me.Controls.Add(Me.btnAtzera)
        Me.Controls.Add(Me.btnEtxea)
        Me.Controls.Add(Me.btnAlbergue)
        Me.Controls.Add(Me.btnHotela)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.MaximizeBox = False
        Me.Name = "Leiho3_OstatuakIkusiN"
        Me.Text = "OstatuAgrad - Ostatuak"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHotela As Button
    Friend WithEvents btnAlbergue As Button
    Friend WithEvents btnEtxea As Button
    Friend WithEvents btnAtzera As Button
End Class
