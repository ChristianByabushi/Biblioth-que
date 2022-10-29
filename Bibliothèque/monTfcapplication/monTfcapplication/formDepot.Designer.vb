<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDepot
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formDepot))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBoxGenre = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DateEdition = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextAuteurLivre = New System.Windows.Forms.TextBox()
        Me.TextTitre = New System.Windows.Forms.TextBox()
        Me.TextCodeisbn = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Depot = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBoxMatricule = New System.Windows.Forms.TextBox()
        Me.TextBoxnom = New System.Windows.Forms.TextBox()
        Me.TextBoxPostnom = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dateEmpruntLivre = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateDepotLivre = New System.Windows.Forms.DateTimePicker()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBoxGenre)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.DateEdition)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextAuteurLivre)
        Me.Panel2.Controls.Add(Me.TextTitre)
        Me.Panel2.Controls.Add(Me.TextCodeisbn)
        Me.Panel2.Location = New System.Drawing.Point(13, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 308)
        Me.Panel2.TabIndex = 14
        '
        'TextBoxGenre
        '
        Me.TextBoxGenre.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxGenre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxGenre.Location = New System.Drawing.Point(144, 162)
        Me.TextBoxGenre.Multiline = True
        Me.TextBoxGenre.Name = "TextBoxGenre"
        Me.TextBoxGenre.Size = New System.Drawing.Size(259, 29)
        Me.TextBoxGenre.TabIndex = 50
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(403, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'DateEdition
        '
        Me.DateEdition.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.DateEdition.CustomFormat = ""
        Me.DateEdition.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DateEdition.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateEdition.Location = New System.Drawing.Point(144, 220)
        Me.DateEdition.Name = "DateEdition"
        Me.DateEdition.Size = New System.Drawing.Size(259, 29)
        Me.DateEdition.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(6, 223)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Date d'Edition : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(2, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 21)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Genre du Livre : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(2, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 21)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Auteur :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Titre : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(3, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 21)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Code Isbn Livre :"
        '
        'TextAuteurLivre
        '
        Me.TextAuteurLivre.BackColor = System.Drawing.Color.Gainsboro
        Me.TextAuteurLivre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextAuteurLivre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextAuteurLivre.Location = New System.Drawing.Point(144, 120)
        Me.TextAuteurLivre.Multiline = True
        Me.TextAuteurLivre.Name = "TextAuteurLivre"
        Me.TextAuteurLivre.Size = New System.Drawing.Size(259, 29)
        Me.TextAuteurLivre.TabIndex = 2
        '
        'TextTitre
        '
        Me.TextTitre.BackColor = System.Drawing.Color.Gainsboro
        Me.TextTitre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextTitre.Location = New System.Drawing.Point(144, 76)
        Me.TextTitre.Multiline = True
        Me.TextTitre.Name = "TextTitre"
        Me.TextTitre.Size = New System.Drawing.Size(259, 26)
        Me.TextTitre.TabIndex = 1
        '
        'TextCodeisbn
        '
        Me.TextCodeisbn.BackColor = System.Drawing.Color.Gainsboro
        Me.TextCodeisbn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextCodeisbn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextCodeisbn.Location = New System.Drawing.Point(137, 29)
        Me.TextCodeisbn.Multiline = True
        Me.TextCodeisbn.Name = "TextCodeisbn"
        Me.TextCodeisbn.Size = New System.Drawing.Size(259, 25)
        Me.TextCodeisbn.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(957, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(376, -3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 45)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Dépot du Livre"
        '
        'Depot
        '
        Me.Depot.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.Depot.Location = New System.Drawing.Point(380, 436)
        Me.Depot.Name = "Depot"
        Me.Depot.Size = New System.Drawing.Size(148, 33)
        Me.Depot.TabIndex = 50
        Me.Depot.Text = "Déposer"
        Me.Depot.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(380, 431)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 41)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'TextBoxMatricule
        '
        Me.TextBoxMatricule.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxMatricule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxMatricule.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxMatricule.Location = New System.Drawing.Point(142, 29)
        Me.TextBoxMatricule.Multiline = True
        Me.TextBoxMatricule.Name = "TextBoxMatricule"
        Me.TextBoxMatricule.Size = New System.Drawing.Size(281, 25)
        Me.TextBoxMatricule.TabIndex = 0
        '
        'TextBoxnom
        '
        Me.TextBoxnom.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxnom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxnom.Location = New System.Drawing.Point(142, 72)
        Me.TextBoxnom.Multiline = True
        Me.TextBoxnom.Name = "TextBoxnom"
        Me.TextBoxnom.Size = New System.Drawing.Size(281, 26)
        Me.TextBoxnom.TabIndex = 1
        '
        'TextBoxPostnom
        '
        Me.TextBoxPostnom.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxPostnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPostnom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxPostnom.Location = New System.Drawing.Point(142, 116)
        Me.TextBoxPostnom.Multiline = True
        Me.TextBoxPostnom.Name = "TextBoxPostnom"
        Me.TextBoxPostnom.Size = New System.Drawing.Size(281, 29)
        Me.TextBoxPostnom.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 21)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Matricule : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 21)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Nom : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 21)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Post Nom : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(6, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Prenom"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(429, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxPrenom.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxPrenom.Location = New System.Drawing.Point(142, 162)
        Me.TextBoxPrenom.Multiline = True
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(281, 29)
        Me.TextBoxPrenom.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.dateDepotLivre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dateEmpruntLivre)
        Me.Panel1.Controls.Add(Me.TextBoxPrenom)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TextBoxPostnom)
        Me.Panel1.Controls.Add(Me.TextBoxnom)
        Me.Panel1.Controls.Add(Me.TextBoxMatricule)
        Me.Panel1.Location = New System.Drawing.Point(497, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 308)
        Me.Panel1.TabIndex = 49
        '
        'dateEmpruntLivre
        '
        Me.dateEmpruntLivre.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.dateEmpruntLivre.CustomFormat = ""
        Me.dateEmpruntLivre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dateEmpruntLivre.Location = New System.Drawing.Point(155, 220)
        Me.dateEmpruntLivre.Name = "dateEmpruntLivre"
        Me.dateEmpruntLivre.Size = New System.Drawing.Size(268, 29)
        Me.dateEmpruntLivre.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 21)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Date de l'emprunt :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(7, 270)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 21)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Date prevue pour épot"
        '
        'dateDepotLivre
        '
        Me.dateDepotLivre.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.dateDepotLivre.CustomFormat = ""
        Me.dateDepotLivre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dateDepotLivre.Location = New System.Drawing.Point(194, 264)
        Me.dateDepotLivre.Name = "dateDepotLivre"
        Me.dateDepotLivre.Size = New System.Drawing.Size(229, 29)
        Me.dateDepotLivre.TabIndex = 53
        '
        'formDepot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1011, 482)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Depot)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formDepot"
        Me.Text = "formDepot"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateEdition As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextAuteurLivre As System.Windows.Forms.TextBox
    Friend WithEvents TextTitre As System.Windows.Forms.TextBox
    Friend WithEvents TextCodeisbn As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Depot As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxGenre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMatricule As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxnom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPostnom As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dateDepotLivre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dateEmpruntLivre As System.Windows.Forms.DateTimePicker
End Class
