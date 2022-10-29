<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLivre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLivre))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateEdition = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextGentreLivre = New System.Windows.Forms.ComboBox()
        Me.TextAuteurLivre = New System.Windows.Forms.TextBox()
        Me.TextTitre = New System.Windows.Forms.TextBox()
        Me.TextCodeisbn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBoxCHeckAuteur = New System.Windows.Forms.PictureBox()
        Me.PictureBoxCheckTitre = New System.Windows.Forms.PictureBox()
        Me.CheckWithISBN = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxCheckAuteur = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxCheckIsbn = New System.Windows.Forms.TextBox()
        Me.TextBoxCheckTitre = New System.Windows.Forms.TextBox()
        Me.TriGenre = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBoxCHeckAuteur, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxCheckTitre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckWithISBN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(444, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(277, 45)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Gestion des Livres"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ListView2)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(492, 71)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(688, 308)
        Me.Panel4.TabIndex = 14
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14})
        Me.ListView2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ListView2.ForeColor = System.Drawing.Color.Black
        Me.ListView2.Location = New System.Drawing.Point(7, 40)
        Me.ListView2.MultiSelect = False
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(676, 254)
        Me.ListView2.TabIndex = 40
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "CodeIsbn"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "NumeroLivre"
        Me.ColumnHeader10.Width = 120
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "TitreLivre"
        Me.ColumnHeader11.Width = 150
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Auteur"
        Me.ColumnHeader12.Width = 120
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "genreLivre"
        Me.ColumnHeader13.Width = 100
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "dateEdition"
        Me.ColumnHeader14.Width = 97
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.Label5.Location = New System.Drawing.Point(7, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(676, 25)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Tous les Livres de la Bibliothèque"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateEdition)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextGentreLivre)
        Me.Panel2.Controls.Add(Me.TextAuteurLivre)
        Me.Panel2.Controls.Add(Me.TextTitre)
        Me.Panel2.Controls.Add(Me.TextCodeisbn)
        Me.Panel2.Location = New System.Drawing.Point(12, 71)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(474, 308)
        Me.Panel2.TabIndex = 13
        '
        'DateEdition
        '
        Me.DateEdition.CalendarMonthBackground = System.Drawing.SystemColors.WindowFrame
        Me.DateEdition.CustomFormat = ""
        Me.DateEdition.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.DateEdition.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateEdition.Location = New System.Drawing.Point(197, 218)
        Me.DateEdition.Name = "DateEdition"
        Me.DateEdition.Size = New System.Drawing.Size(259, 29)
        Me.DateEdition.TabIndex = 48
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(8, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 21)
        Me.Label12.TabIndex = 47
        Me.Label12.Text = "Date d'Edition : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(8, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 21)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Entrer le genre du Livre : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(4, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 21)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Entrer L'Auteur Livre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(5, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Entrer le Titre : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(5, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 21)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Entrer le Code Isbn Livre :"
        '
        'TextGentreLivre
        '
        Me.TextGentreLivre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TextGentreLivre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextGentreLivre.FormattingEnabled = True
        Me.TextGentreLivre.Items.AddRange(New Object() {"Roman", "Livres informatiques", "Livres d'agronomie", "Livres éducatifs", "Livres en polytechnique"})
        Me.TextGentreLivre.Location = New System.Drawing.Point(197, 168)
        Me.TextGentreLivre.Name = "TextGentreLivre"
        Me.TextGentreLivre.Size = New System.Drawing.Size(259, 29)
        Me.TextGentreLivre.TabIndex = 4
        Me.TextGentreLivre.Text = " Choisir"
        '
        'TextAuteurLivre
        '
        Me.TextAuteurLivre.BackColor = System.Drawing.Color.Gainsboro
        Me.TextAuteurLivre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextAuteurLivre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextAuteurLivre.Location = New System.Drawing.Point(197, 118)
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
        Me.TextTitre.Location = New System.Drawing.Point(197, 74)
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
        Me.TextCodeisbn.Location = New System.Drawing.Point(197, 31)
        Me.TextCodeisbn.Multiline = True
        Me.TextCodeisbn.Name = "TextCodeisbn"
        Me.TextCodeisbn.Size = New System.Drawing.Size(259, 25)
        Me.TextCodeisbn.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(179, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Enregistrement "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(73, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(12, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 94)
        Me.Panel1.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(343, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 21)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Modifier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(206, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Supprimer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(96, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Ajouter"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(336, 16)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(203, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(87, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(91, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBoxCHeckAuteur)
        Me.Panel3.Controls.Add(Me.PictureBoxCheckTitre)
        Me.Panel3.Controls.Add(Me.CheckWithISBN)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TextBoxCheckAuteur)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.TextBoxCheckIsbn)
        Me.Panel3.Controls.Add(Me.TextBoxCheckTitre)
        Me.Panel3.Location = New System.Drawing.Point(611, 416)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(565, 116)
        Me.Panel3.TabIndex = 18
        '
        'PictureBoxCHeckAuteur
        '
        Me.PictureBoxCHeckAuteur.BackColor = System.Drawing.Color.Silver
        Me.PictureBoxCHeckAuteur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCHeckAuteur.Image = CType(resources.GetObject("PictureBoxCHeckAuteur.Image"), System.Drawing.Image)
        Me.PictureBoxCHeckAuteur.Location = New System.Drawing.Point(445, 82)
        Me.PictureBoxCHeckAuteur.Name = "PictureBoxCHeckAuteur"
        Me.PictureBoxCHeckAuteur.Size = New System.Drawing.Size(32, 26)
        Me.PictureBoxCHeckAuteur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCHeckAuteur.TabIndex = 57
        Me.PictureBoxCHeckAuteur.TabStop = False
        '
        'PictureBoxCheckTitre
        '
        Me.PictureBoxCheckTitre.BackColor = System.Drawing.Color.Silver
        Me.PictureBoxCheckTitre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxCheckTitre.Image = CType(resources.GetObject("PictureBoxCheckTitre.Image"), System.Drawing.Image)
        Me.PictureBoxCheckTitre.Location = New System.Drawing.Point(444, 49)
        Me.PictureBoxCheckTitre.Name = "PictureBoxCheckTitre"
        Me.PictureBoxCheckTitre.Size = New System.Drawing.Size(32, 26)
        Me.PictureBoxCheckTitre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCheckTitre.TabIndex = 56
        Me.PictureBoxCheckTitre.TabStop = False
        '
        'CheckWithISBN
        '
        Me.CheckWithISBN.BackColor = System.Drawing.Color.Silver
        Me.CheckWithISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CheckWithISBN.Image = CType(resources.GetObject("CheckWithISBN.Image"), System.Drawing.Image)
        Me.CheckWithISBN.Location = New System.Drawing.Point(442, 15)
        Me.CheckWithISBN.Name = "CheckWithISBN"
        Me.CheckWithISBN.Size = New System.Drawing.Size(32, 25)
        Me.CheckWithISBN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CheckWithISBN.TabIndex = 55
        Me.CheckWithISBN.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(12, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 21)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Entrer l'auteur"
        '
        'TextBoxCheckAuteur
        '
        Me.TextBoxCheckAuteur.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxCheckAuteur.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCheckAuteur.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxCheckAuteur.Location = New System.Drawing.Point(217, 82)
        Me.TextBoxCheckAuteur.Multiline = True
        Me.TextBoxCheckAuteur.Name = "TextBoxCheckAuteur"
        Me.TextBoxCheckAuteur.Size = New System.Drawing.Size(226, 26)
        Me.TextBoxCheckAuteur.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.Location = New System.Drawing.Point(12, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 21)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Entrer le Titre : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(10, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 21)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "Entrer le Code Isbn Livre :"
        '
        'TextBoxCheckIsbn
        '
        Me.TextBoxCheckIsbn.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxCheckIsbn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCheckIsbn.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxCheckIsbn.Location = New System.Drawing.Point(215, 15)
        Me.TextBoxCheckIsbn.Multiline = True
        Me.TextBoxCheckIsbn.Name = "TextBoxCheckIsbn"
        Me.TextBoxCheckIsbn.Size = New System.Drawing.Size(226, 25)
        Me.TextBoxCheckIsbn.TabIndex = 48
        '
        'TextBoxCheckTitre
        '
        Me.TextBoxCheckTitre.BackColor = System.Drawing.Color.Gainsboro
        Me.TextBoxCheckTitre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCheckTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TextBoxCheckTitre.Location = New System.Drawing.Point(217, 49)
        Me.TextBoxCheckTitre.Multiline = True
        Me.TextBoxCheckTitre.Name = "TextBoxCheckTitre"
        Me.TextBoxCheckTitre.Size = New System.Drawing.Size(226, 26)
        Me.TextBoxCheckTitre.TabIndex = 49
        '
        'TriGenre
        '
        Me.TriGenre.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.TriGenre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TriGenre.FormattingEnabled = True
        Me.TriGenre.Items.AddRange(New Object() {"Roman", "Livres informatiques", "Livres d'agronomie", "Livres éducatifs", "Livres en polytechnique"})
        Me.TriGenre.Location = New System.Drawing.Point(796, 40)
        Me.TriGenre.Name = "TriGenre"
        Me.TriGenre.Size = New System.Drawing.Size(169, 29)
        Me.TriGenre.TabIndex = 49
        Me.TriGenre.Text = "Trier par le genre : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Window
        Me.Button1.Location = New System.Drawing.Point(1144, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 27)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label11.Location = New System.Drawing.Point(768, 385)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(239, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Recherche Sophistiquée"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(971, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Rechercher : "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1061, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 20)
        Me.TextBox1.TabIndex = 22
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label21.Location = New System.Drawing.Point(1100, 384)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 21)
        Me.Label21.TabIndex = 68
        Me.Label21.Text = "Actualiser"
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(1056, 382)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 31)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 67
        Me.PictureBox9.TabStop = False
        '
        'formLivre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1189, 539)
        Me.Controls.Add(Me.TriGenre)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLivre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLivre"
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBoxCHeckAuteur, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxCheckTitre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckWithISBN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextGentreLivre As System.Windows.Forms.ComboBox
    Friend WithEvents TextAuteurLivre As System.Windows.Forms.TextBox
    Friend WithEvents TextTitre As System.Windows.Forms.TextBox
    Friend WithEvents TextCodeisbn As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCheckAuteur As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCheckIsbn As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCheckTitre As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateEdition As System.Windows.Forms.DateTimePicker
    Friend WithEvents TriGenre As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxCHeckAuteur As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxCheckTitre As System.Windows.Forms.PictureBox
    Friend WithEvents CheckWithISBN As System.Windows.Forms.PictureBox
End Class
