<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leiho5_ErreserbaUpdate
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
        Me.hasieradata = New System.Windows.Forms.MonthCalendar()
        Me.amaieradata = New System.Windows.Forms.MonthCalendar()
        Me.lblPrezioa = New System.Windows.Forms.Label()
        Me.blPertsonaTot = New System.Windows.Forms.Label()
        Me.lblHasieraData = New System.Windows.Forms.Label()
        Me.lblAmaieraData = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.p_cant = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.prezioa = New System.Windows.Forms.Label()
        CType(Me.p_cant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'hasieradata
        '
        Me.hasieradata.Location = New System.Drawing.Point(12, 31)
        Me.hasieradata.Name = "hasieradata"
        Me.hasieradata.TabIndex = 1
        '
        'amaieradata
        '
        Me.amaieradata.Location = New System.Drawing.Point(222, 31)
        Me.amaieradata.Name = "amaieradata"
        Me.amaieradata.TabIndex = 2
        '
        'lblPrezioa
        '
        Me.lblPrezioa.AutoSize = True
        Me.lblPrezioa.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblPrezioa.Location = New System.Drawing.Point(167, 238)
        Me.lblPrezioa.Name = "lblPrezioa"
        Me.lblPrezioa.Size = New System.Drawing.Size(57, 19)
        Me.lblPrezioa.TabIndex = 4
        Me.lblPrezioa.Text = "Prezioa:"
        '
        'blPertsonaTot
        '
        Me.blPertsonaTot.AutoSize = True
        Me.blPertsonaTot.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.blPertsonaTot.Location = New System.Drawing.Point(109, 205)
        Me.blPertsonaTot.Name = "blPertsonaTot"
        Me.blPertsonaTot.Size = New System.Drawing.Size(102, 19)
        Me.blPertsonaTot.TabIndex = 5
        Me.blPertsonaTot.Text = "Pertsona totala:"
        '
        'lblHasieraData
        '
        Me.lblHasieraData.AutoSize = True
        Me.lblHasieraData.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblHasieraData.Location = New System.Drawing.Point(56, 12)
        Me.lblHasieraData.Name = "lblHasieraData"
        Me.lblHasieraData.Size = New System.Drawing.Size(88, 19)
        Me.lblHasieraData.TabIndex = 12
        Me.lblHasieraData.Text = "Hasiera data:"
        '
        'lblAmaieraData
        '
        Me.lblAmaieraData.AutoSize = True
        Me.lblAmaieraData.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblAmaieraData.Location = New System.Drawing.Point(260, 12)
        Me.lblAmaieraData.Name = "lblAmaieraData"
        Me.lblAmaieraData.Size = New System.Drawing.Size(93, 19)
        Me.lblAmaieraData.TabIndex = 13
        Me.lblAmaieraData.Text = "Amaiera data:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(162, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 35)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Erreserba aldatu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.Button2.Location = New System.Drawing.Point(2, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 26)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Ezeztatu"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'p_cant
        '
        Me.p_cant.Location = New System.Drawing.Point(213, 205)
        Me.p_cant.Name = "p_cant"
        Me.p_cant.Size = New System.Drawing.Size(88, 20)
        Me.p_cant.TabIndex = 16
        Me.p_cant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.prezioa)
        Me.Panel1.Controls.Add(Me.amaieradata)
        Me.Panel1.Controls.Add(Me.lblHasieraData)
        Me.Panel1.Controls.Add(Me.p_cant)
        Me.Panel1.Controls.Add(Me.blPertsonaTot)
        Me.Panel1.Controls.Add(Me.lblPrezioa)
        Me.Panel1.Controls.Add(Me.hasieradata)
        Me.Panel1.Controls.Add(Me.lblAmaieraData)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(227, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 320)
        Me.Panel1.TabIndex = 17
        '
        'prezioa
        '
        Me.prezioa.AutoSize = True
        Me.prezioa.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.prezioa.Location = New System.Drawing.Point(230, 238)
        Me.prezioa.Name = "prezioa"
        Me.prezioa.Size = New System.Drawing.Size(17, 19)
        Me.prezioa.TabIndex = 17
        Me.prezioa.Text = "€"
        '
        'Leiho5_ErreserbaUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._04_Aldatu
        Me.ClientSize = New System.Drawing.Size(662, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.MaximizeBox = False
        Me.Name = "Leiho5_ErreserbaUpdate"
        Me.Text = "OstatuAgrad- Administratzailea - Erreserba aldaketa"
        CType(Me.p_cant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents hasieradata As MonthCalendar
    Friend WithEvents amaieradata As MonthCalendar
    Friend WithEvents lblPrezioa As Label
    Friend WithEvents blPertsonaTot As Label
    Friend WithEvents lblHasieraData As Label
    Friend WithEvents lblAmaieraData As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents p_cant As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents prezioa As Label
End Class
