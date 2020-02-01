<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leiho4_OstatuInsert
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEzeztatu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.signatura = New System.Windows.Forms.TextBox()
        Me.cbHerria = New System.Windows.Forms.ComboBox()
        Me.lbHerria = New System.Windows.Forms.Label()
        Me.cbProbintzia = New System.Windows.Forms.ComboBox()
        Me.lblProbintzia = New System.Windows.Forms.Label()
        Me.cbPostaKodea = New System.Windows.Forms.ComboBox()
        Me.cbHerriKodea = New System.Windows.Forms.ComboBox()
        Me.zipurl = New System.Windows.Forms.TextBox()
        Me.adiskidetsuurl = New System.Windows.Forms.TextBox()
        Me.weburl = New System.Windows.Forms.TextBox()
        Me.lblZipUrl = New System.Windows.Forms.Label()
        Me.lblAdiskidetsuUrl = New System.Windows.Forms.Label()
        Me.lblWebUrl = New System.Windows.Forms.Label()
        Me.longitudea = New System.Windows.Forms.TextBox()
        Me.latitudea = New System.Windows.Forms.TextBox()
        Me.lblLongitudea = New System.Windows.Forms.Label()
        Me.lblLatitudea = New System.Windows.Forms.Label()
        Me.pertsonatot = New System.Windows.Forms.NumericUpDown()
        Me.lblPertsonaTot = New System.Windows.Forms.Label()
        Me.lblDeskribapena = New System.Windows.Forms.Label()
        Me.deskribapena = New System.Windows.Forms.RichTextBox()
        Me.lblPostaKodea = New System.Windows.Forms.Label()
        Me.lblHerriKodea = New System.Windows.Forms.Label()
        Me.marka = New System.Windows.Forms.TextBox()
        Me.mota = New System.Windows.Forms.TextBox()
        Me.lblMarka = New System.Windows.Forms.Label()
        Me.lblMota = New System.Windows.Forms.Label()
        Me.telefonoa = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.lblTelefonoa = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblHelbidea = New System.Windows.Forms.Label()
        Me.helbidea = New System.Windows.Forms.TextBox()
        Me.izena = New System.Windows.Forms.TextBox()
        Me.lblIzena = New System.Windows.Forms.Label()
        Me.lblSignatura = New System.Windows.Forms.Label()
        Me.btnGehitu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.pertsonatot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEzeztatu
        '
        Me.btnEzeztatu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnEzeztatu.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.btnEzeztatu.Location = New System.Drawing.Point(2, 3)
        Me.btnEzeztatu.Name = "btnEzeztatu"
        Me.btnEzeztatu.Size = New System.Drawing.Size(67, 26)
        Me.btnEzeztatu.TabIndex = 87
        Me.btnEzeztatu.Text = "Ezeztatu"
        Me.btnEzeztatu.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.signatura)
        Me.Panel1.Controls.Add(Me.cbHerria)
        Me.Panel1.Controls.Add(Me.lbHerria)
        Me.Panel1.Controls.Add(Me.cbProbintzia)
        Me.Panel1.Controls.Add(Me.lblProbintzia)
        Me.Panel1.Controls.Add(Me.cbPostaKodea)
        Me.Panel1.Controls.Add(Me.cbHerriKodea)
        Me.Panel1.Controls.Add(Me.zipurl)
        Me.Panel1.Controls.Add(Me.adiskidetsuurl)
        Me.Panel1.Controls.Add(Me.weburl)
        Me.Panel1.Controls.Add(Me.lblZipUrl)
        Me.Panel1.Controls.Add(Me.lblAdiskidetsuUrl)
        Me.Panel1.Controls.Add(Me.lblWebUrl)
        Me.Panel1.Controls.Add(Me.longitudea)
        Me.Panel1.Controls.Add(Me.latitudea)
        Me.Panel1.Controls.Add(Me.lblLongitudea)
        Me.Panel1.Controls.Add(Me.lblLatitudea)
        Me.Panel1.Controls.Add(Me.pertsonatot)
        Me.Panel1.Controls.Add(Me.lblPertsonaTot)
        Me.Panel1.Controls.Add(Me.lblDeskribapena)
        Me.Panel1.Controls.Add(Me.deskribapena)
        Me.Panel1.Controls.Add(Me.lblPostaKodea)
        Me.Panel1.Controls.Add(Me.lblHerriKodea)
        Me.Panel1.Controls.Add(Me.marka)
        Me.Panel1.Controls.Add(Me.mota)
        Me.Panel1.Controls.Add(Me.lblMarka)
        Me.Panel1.Controls.Add(Me.lblMota)
        Me.Panel1.Controls.Add(Me.telefonoa)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Controls.Add(Me.lblTelefonoa)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblHelbidea)
        Me.Panel1.Controls.Add(Me.helbidea)
        Me.Panel1.Controls.Add(Me.izena)
        Me.Panel1.Controls.Add(Me.lblIzena)
        Me.Panel1.Controls.Add(Me.lblSignatura)
        Me.Panel1.Controls.Add(Me.btnGehitu)
        Me.Panel1.Location = New System.Drawing.Point(75, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 458)
        Me.Panel1.TabIndex = 86
        '
        'signatura
        '
        Me.signatura.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.signatura.Location = New System.Drawing.Point(177, 16)
        Me.signatura.MaxLength = 10
        Me.signatura.Name = "signatura"
        Me.signatura.Size = New System.Drawing.Size(130, 21)
        Me.signatura.TabIndex = 84
        '
        'cbHerria
        '
        Me.cbHerria.DisplayMember = "67"
        Me.cbHerria.Enabled = False
        Me.cbHerria.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbHerria.FormattingEnabled = True
        Me.cbHerria.Location = New System.Drawing.Point(162, 124)
        Me.cbHerria.Name = "cbHerria"
        Me.cbHerria.Size = New System.Drawing.Size(145, 23)
        Me.cbHerria.TabIndex = 83
        '
        'lbHerria
        '
        Me.lbHerria.AutoSize = True
        Me.lbHerria.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbHerria.Location = New System.Drawing.Point(166, 102)
        Me.lbHerria.Name = "lbHerria"
        Me.lbHerria.Size = New System.Drawing.Size(50, 19)
        Me.lbHerria.TabIndex = 82
        Me.lbHerria.Text = "Herria:"
        '
        'cbProbintzia
        '
        Me.cbProbintzia.DisplayMember = "67"
        Me.cbProbintzia.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbProbintzia.FormattingEnabled = True
        Me.cbProbintzia.Items.AddRange(New Object() {"Araba", "Bizkaia", "Gipuzkoa"})
        Me.cbProbintzia.Location = New System.Drawing.Point(11, 124)
        Me.cbProbintzia.Name = "cbProbintzia"
        Me.cbProbintzia.Size = New System.Drawing.Size(145, 23)
        Me.cbProbintzia.TabIndex = 81
        '
        'lblProbintzia
        '
        Me.lblProbintzia.AutoSize = True
        Me.lblProbintzia.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblProbintzia.Location = New System.Drawing.Point(15, 102)
        Me.lblProbintzia.Name = "lblProbintzia"
        Me.lblProbintzia.Size = New System.Drawing.Size(72, 19)
        Me.lblProbintzia.TabIndex = 80
        Me.lblProbintzia.Text = "Probintzia:"
        '
        'cbPostaKodea
        '
        Me.cbPostaKodea.Enabled = False
        Me.cbPostaKodea.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbPostaKodea.FormattingEnabled = True
        Me.cbPostaKodea.Location = New System.Drawing.Point(463, 124)
        Me.cbPostaKodea.Name = "cbPostaKodea"
        Me.cbPostaKodea.Size = New System.Drawing.Size(145, 23)
        Me.cbPostaKodea.TabIndex = 79
        '
        'cbHerriKodea
        '
        Me.cbHerriKodea.DisplayMember = "67"
        Me.cbHerriKodea.Enabled = False
        Me.cbHerriKodea.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.cbHerriKodea.FormattingEnabled = True
        Me.cbHerriKodea.Location = New System.Drawing.Point(312, 124)
        Me.cbHerriKodea.Name = "cbHerriKodea"
        Me.cbHerriKodea.Size = New System.Drawing.Size(145, 23)
        Me.cbHerriKodea.TabIndex = 78
        '
        'zipurl
        '
        Me.zipurl.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.zipurl.Location = New System.Drawing.Point(124, 394)
        Me.zipurl.MaxLength = 1500
        Me.zipurl.Name = "zipurl"
        Me.zipurl.Size = New System.Drawing.Size(483, 21)
        Me.zipurl.TabIndex = 76
        '
        'adiskidetsuurl
        '
        Me.adiskidetsuurl.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.adiskidetsuurl.Location = New System.Drawing.Point(124, 363)
        Me.adiskidetsuurl.MaxLength = 1500
        Me.adiskidetsuurl.Name = "adiskidetsuurl"
        Me.adiskidetsuurl.Size = New System.Drawing.Size(483, 21)
        Me.adiskidetsuurl.TabIndex = 75
        '
        'weburl
        '
        Me.weburl.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.weburl.Location = New System.Drawing.Point(124, 332)
        Me.weburl.MaxLength = 1500
        Me.weburl.Name = "weburl"
        Me.weburl.Size = New System.Drawing.Size(483, 21)
        Me.weburl.TabIndex = 74
        '
        'lblZipUrl
        '
        Me.lblZipUrl.AutoSize = True
        Me.lblZipUrl.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblZipUrl.Location = New System.Drawing.Point(48, 394)
        Me.lblZipUrl.Name = "lblZipUrl"
        Me.lblZipUrl.Size = New System.Drawing.Size(68, 19)
        Me.lblZipUrl.TabIndex = 73
        Me.lblZipUrl.Text = "ZIP URL:"
        '
        'lblAdiskidetsuUrl
        '
        Me.lblAdiskidetsuUrl.AutoSize = True
        Me.lblAdiskidetsuUrl.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblAdiskidetsuUrl.Location = New System.Drawing.Point(4, 363)
        Me.lblAdiskidetsuUrl.Name = "lblAdiskidetsuUrl"
        Me.lblAdiskidetsuUrl.Size = New System.Drawing.Size(117, 19)
        Me.lblAdiskidetsuUrl.TabIndex = 72
        Me.lblAdiskidetsuUrl.Text = "Adiskidetsu URL:"
        '
        'lblWebUrl
        '
        Me.lblWebUrl.AutoSize = True
        Me.lblWebUrl.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblWebUrl.Location = New System.Drawing.Point(43, 334)
        Me.lblWebUrl.Name = "lblWebUrl"
        Me.lblWebUrl.Size = New System.Drawing.Size(75, 19)
        Me.lblWebUrl.TabIndex = 71
        Me.lblWebUrl.Text = "Web URL:"
        '
        'longitudea
        '
        Me.longitudea.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.longitudea.Location = New System.Drawing.Point(493, 297)
        Me.longitudea.Name = "longitudea"
        Me.longitudea.Size = New System.Drawing.Size(113, 21)
        Me.longitudea.TabIndex = 70
        '
        'latitudea
        '
        Me.latitudea.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.latitudea.Location = New System.Drawing.Point(253, 296)
        Me.latitudea.Name = "latitudea"
        Me.latitudea.Size = New System.Drawing.Size(149, 21)
        Me.latitudea.TabIndex = 69
        '
        'lblLongitudea
        '
        Me.lblLongitudea.AutoSize = True
        Me.lblLongitudea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblLongitudea.Location = New System.Drawing.Point(408, 298)
        Me.lblLongitudea.Name = "lblLongitudea"
        Me.lblLongitudea.Size = New System.Drawing.Size(79, 19)
        Me.lblLongitudea.TabIndex = 68
        Me.lblLongitudea.Text = "Longitudea:"
        '
        'lblLatitudea
        '
        Me.lblLatitudea.AutoSize = True
        Me.lblLatitudea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblLatitudea.Location = New System.Drawing.Point(179, 298)
        Me.lblLatitudea.Name = "lblLatitudea"
        Me.lblLatitudea.Size = New System.Drawing.Size(68, 19)
        Me.lblLatitudea.TabIndex = 67
        Me.lblLatitudea.Text = "Latitudea:"
        '
        'pertsonatot
        '
        Me.pertsonatot.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.pertsonatot.Location = New System.Drawing.Point(124, 297)
        Me.pertsonatot.Name = "pertsonatot"
        Me.pertsonatot.Size = New System.Drawing.Size(46, 21)
        Me.pertsonatot.TabIndex = 66
        '
        'lblPertsonaTot
        '
        Me.lblPertsonaTot.AutoSize = True
        Me.lblPertsonaTot.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblPertsonaTot.Location = New System.Drawing.Point(17, 299)
        Me.lblPertsonaTot.Name = "lblPertsonaTot"
        Me.lblPertsonaTot.Size = New System.Drawing.Size(102, 19)
        Me.lblPertsonaTot.TabIndex = 65
        Me.lblPertsonaTot.Text = "Pertsona totala:"
        '
        'lblDeskribapena
        '
        Me.lblDeskribapena.AutoSize = True
        Me.lblDeskribapena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblDeskribapena.Location = New System.Drawing.Point(15, 157)
        Me.lblDeskribapena.Name = "lblDeskribapena"
        Me.lblDeskribapena.Size = New System.Drawing.Size(96, 19)
        Me.lblDeskribapena.TabIndex = 64
        Me.lblDeskribapena.Text = "Deskribapena:"
        '
        'deskribapena
        '
        Me.deskribapena.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.deskribapena.Location = New System.Drawing.Point(11, 179)
        Me.deskribapena.MaxLength = 2000
        Me.deskribapena.Name = "deskribapena"
        Me.deskribapena.Size = New System.Drawing.Size(596, 111)
        Me.deskribapena.TabIndex = 63
        Me.deskribapena.Text = ""
        '
        'lblPostaKodea
        '
        Me.lblPostaKodea.AutoSize = True
        Me.lblPostaKodea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblPostaKodea.Location = New System.Drawing.Point(460, 102)
        Me.lblPostaKodea.Name = "lblPostaKodea"
        Me.lblPostaKodea.Size = New System.Drawing.Size(88, 19)
        Me.lblPostaKodea.TabIndex = 62
        Me.lblPostaKodea.Text = "Posta kodea:"
        '
        'lblHerriKodea
        '
        Me.lblHerriKodea.AutoSize = True
        Me.lblHerriKodea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblHerriKodea.Location = New System.Drawing.Point(316, 102)
        Me.lblHerriKodea.Name = "lblHerriKodea"
        Me.lblHerriKodea.Size = New System.Drawing.Size(85, 19)
        Me.lblHerriKodea.TabIndex = 61
        Me.lblHerriKodea.Text = "Herri kodea:"
        '
        'marka
        '
        Me.marka.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.marka.Location = New System.Drawing.Point(395, 72)
        Me.marka.MaxLength = 500
        Me.marka.Name = "marka"
        Me.marka.Size = New System.Drawing.Size(100, 21)
        Me.marka.TabIndex = 60
        '
        'mota
        '
        Me.mota.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.mota.Location = New System.Drawing.Point(507, 72)
        Me.mota.MaxLength = 25
        Me.mota.Name = "mota"
        Me.mota.Size = New System.Drawing.Size(100, 21)
        Me.mota.TabIndex = 59
        '
        'lblMarka
        '
        Me.lblMarka.AutoSize = True
        Me.lblMarka.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblMarka.Location = New System.Drawing.Point(391, 50)
        Me.lblMarka.Name = "lblMarka"
        Me.lblMarka.Size = New System.Drawing.Size(53, 19)
        Me.lblMarka.TabIndex = 58
        Me.lblMarka.Text = "Marka:"
        '
        'lblMota
        '
        Me.lblMota.AutoSize = True
        Me.lblMota.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblMota.Location = New System.Drawing.Point(503, 50)
        Me.lblMota.Name = "lblMota"
        Me.lblMota.Size = New System.Drawing.Size(45, 19)
        Me.lblMota.TabIndex = 57
        Me.lblMota.Text = "Mota:"
        '
        'telefonoa
        '
        Me.telefonoa.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.telefonoa.Location = New System.Drawing.Point(278, 72)
        Me.telefonoa.MaxLength = 25
        Me.telefonoa.Name = "telefonoa"
        Me.telefonoa.Size = New System.Drawing.Size(100, 21)
        Me.telefonoa.TabIndex = 56
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.email.Location = New System.Drawing.Point(157, 72)
        Me.email.MaxLength = 100
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(100, 21)
        Me.email.TabIndex = 55
        '
        'lblTelefonoa
        '
        Me.lblTelefonoa.AutoSize = True
        Me.lblTelefonoa.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblTelefonoa.Location = New System.Drawing.Point(274, 50)
        Me.lblTelefonoa.Name = "lblTelefonoa"
        Me.lblTelefonoa.Size = New System.Drawing.Size(71, 19)
        Me.lblTelefonoa.TabIndex = 54
        Me.lblTelefonoa.Text = "Telefonoa:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(153, 50)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 19)
        Me.lblEmail.TabIndex = 53
        Me.lblEmail.Text = "Email:"
        '
        'lblHelbidea
        '
        Me.lblHelbidea.AutoSize = True
        Me.lblHelbidea.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblHelbidea.Location = New System.Drawing.Point(21, 50)
        Me.lblHelbidea.Name = "lblHelbidea"
        Me.lblHelbidea.Size = New System.Drawing.Size(66, 19)
        Me.lblHelbidea.TabIndex = 52
        Me.lblHelbidea.Text = "Helbidea:"
        '
        'helbidea
        '
        Me.helbidea.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.helbidea.Location = New System.Drawing.Point(21, 72)
        Me.helbidea.MaxLength = 200
        Me.helbidea.Name = "helbidea"
        Me.helbidea.Size = New System.Drawing.Size(100, 21)
        Me.helbidea.TabIndex = 51
        '
        'izena
        '
        Me.izena.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.izena.Location = New System.Drawing.Point(395, 16)
        Me.izena.MaxLength = 50
        Me.izena.Name = "izena"
        Me.izena.Size = New System.Drawing.Size(130, 21)
        Me.izena.TabIndex = 50
        '
        'lblIzena
        '
        Me.lblIzena.AutoSize = True
        Me.lblIzena.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblIzena.Location = New System.Drawing.Point(350, 16)
        Me.lblIzena.Name = "lblIzena"
        Me.lblIzena.Size = New System.Drawing.Size(44, 19)
        Me.lblIzena.TabIndex = 49
        Me.lblIzena.Text = "Izena:"
        '
        'lblSignatura
        '
        Me.lblSignatura.AutoSize = True
        Me.lblSignatura.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lblSignatura.Location = New System.Drawing.Point(108, 16)
        Me.lblSignatura.Name = "lblSignatura"
        Me.lblSignatura.Size = New System.Drawing.Size(68, 19)
        Me.lblSignatura.TabIndex = 48
        Me.lblSignatura.Text = "Signatura:"
        '
        'btnGehitu
        '
        Me.btnGehitu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btnGehitu.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.btnGehitu.Location = New System.Drawing.Point(264, 421)
        Me.btnGehitu.Name = "btnGehitu"
        Me.btnGehitu.Size = New System.Drawing.Size(106, 35)
        Me.btnGehitu.TabIndex = 14
        Me.btnGehitu.Text = "Ostatua gehitu"
        Me.btnGehitu.UseVisualStyleBackColor = False
        '
        'Leiho4_OstatuInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UsuAdmin.My.Resources.Resources._04_Insert
        Me.ClientSize = New System.Drawing.Size(700, 467)
        Me.Controls.Add(Me.btnEzeztatu)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Leiho4_OstatuInsert"
        Me.Text = "OstatuAgrad - Administratzailea  - Ostatua gehitu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pertsonatot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEzeztatu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbHerria As ComboBox
    Friend WithEvents lbHerria As Label
    Friend WithEvents cbProbintzia As ComboBox
    Friend WithEvents lblProbintzia As Label
    Friend WithEvents cbPostaKodea As ComboBox
    Friend WithEvents cbHerriKodea As ComboBox
    Friend WithEvents zipurl As TextBox
    Friend WithEvents adiskidetsuurl As TextBox
    Friend WithEvents weburl As TextBox
    Friend WithEvents lblZipUrl As Label
    Friend WithEvents lblAdiskidetsuUrl As Label
    Friend WithEvents lblWebUrl As Label
    Friend WithEvents longitudea As TextBox
    Friend WithEvents latitudea As TextBox
    Friend WithEvents lblLongitudea As Label
    Friend WithEvents lblLatitudea As Label
    Friend WithEvents pertsonatot As NumericUpDown
    Friend WithEvents lblPertsonaTot As Label
    Friend WithEvents lblDeskribapena As Label
    Friend WithEvents deskribapena As RichTextBox
    Friend WithEvents lblPostaKodea As Label
    Friend WithEvents lblHerriKodea As Label
    Friend WithEvents marka As TextBox
    Friend WithEvents mota As TextBox
    Friend WithEvents lblMarka As Label
    Friend WithEvents lblMota As Label
    Friend WithEvents telefonoa As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents lblTelefonoa As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblHelbidea As Label
    Friend WithEvents helbidea As TextBox
    Friend WithEvents izena As TextBox
    Friend WithEvents lblIzena As Label
    Friend WithEvents lblSignatura As Label
    Friend WithEvents btnGehitu As Button
    Friend WithEvents signatura As TextBox
End Class
