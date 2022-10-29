Imports MySql.Data.MySqlClient
Imports System.DateTime
Public Class formLivre
    Dim rqt As String
    Dim cmd As MySqlCommand
    Dim cn As New MySqlConnection
    Dim Iselection As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub AjouterLivre(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label3.Click

        Dim veriDate As Boolean = False

        If DateEdition.Value.Year < "1789" And DateEdition.Value.Month < "1" And DateEdition.Value.Day < "1" Then
            veriDate = False
            MsgBox("Verifier bien la date", MsgBoxStyle.OkOnly, "Date Vérification")
        Else
            veriDate = True
        End If

        If Not (TextCodeisbn.Text = "" Or TextTitre.Text = "" Or TextAuteurLivre.Text = "" Or TextGentreLivre.SelectedItem.ToString = "" Or DateEdition.Text = "" Or veriDate = False) Then
            Try
                'MsgBox(Me.DateEdition.Value.ToString("yyyy-MM-dd"))
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "insert into livre values('" & Val(TextCodeisbn.Text) & "',Null,'" & TextTitre.Text & "','" & TextAuteurLivre.Text & "','" & TextGentreLivre.Text & "','" & Me.DateEdition.Value.ToString("yyyy-MM-dd") & "')"
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteNonQuery()
                afficherAvecLIstview()
                MsgBox("Ajout d'un nouvel enregistrement réussi avec succès", MsgBoxStyle.Information, "Ajouter")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Veuillez Remplir tous les champs Concernant le livre, Svp", MsgBoxStyle.Information, "Vérification")
        End If
    End Sub
    Private Sub afficherAvecLIstview()
        Try
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM livre"
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub formLivre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView2.FullRowSelect = True
        afficherAvecLIstview()
        'MsgBox(Me.DateEdition.Value.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub SupprimerLivre(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label4.Click
        Try
            rqt = "DELETE FROM livre  WHERE codeIsbn = " & ListView2.Items(Iselection).Text
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            cmd.ExecuteReader()
            MsgBox("Suppression réussie avec succès", MsgBoxStyle.Information, "Suppression")
            cn.Close()
            afficherAvecLIstview()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click

        Try
            Iselection = ListView2.SelectedIndices(0)
            'TextMatrUt.Text = ListView2.Items(Iselection).SubItems(0).Text
            TextTitre.Text = ListView2.Items(Iselection).SubItems(2).Text
            TextAuteurLivre.Text = ListView2.Items(Iselection).SubItems(3).Text
            TextGentreLivre.Text = ListView2.Items(Iselection).SubItems(4).Text
            DateEdition.Value = ListView2.Items(Iselection).SubItems(5).Text.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
    End Sub

    Private Sub ModifierLivre(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label9.Click
        Dim veriDate As Boolean = False
        If DateEdition.Value.Year < "1789" And DateEdition.Value.Month < "1" And DateEdition.Value.Day < "1" Then
            veriDate = False
            MsgBox("Verifier bien la date", MsgBoxStyle.OkOnly, "Date Vérification")
        Else
            veriDate = True
        End If

        If Not (TextTitre.Text = "" Or TextAuteurLivre.Text = "" Or TextGentreLivre.Text = "" Or DateEdition.Text = "" Or veriDate = False) Then
            Try
                rqt = "UPDATE livre SET auteurLivre ='" & TextAuteurLivre.Text & "', titreLivre  ='" & TextTitre.Text & "', genreLivre = '" & TextGentreLivre.SelectedItem & "', dateEdition ='" & Me.DateEdition.Value.ToString("yyyy-MM-dd") & "'  WHERE codeIsbn = " & ListView2.Items(Iselection).Text
                cmd = New MySqlCommand(rqt, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                afficherAvecLIstview()
                MsgBox("Modification de l'enregistrement faite avec succès", MsgBoxStyle.Information, "Update")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Vérifiez que tous les champs sont pas Vides", MsgBoxStyle.Exclamation, " Vérification champ")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub actualiser(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label21.Click
        afficherAvecLIstview()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TriGenre.SelectedIndexChanged
        Try
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM `livre` WHERE `genreLivre` LIKE '" & TriGenre.SelectedItem & "' "

            'SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%Jor%'
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
            End While

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ChekISBN(sender As Object, e As EventArgs) Handles CheckWithISBN.Click
        If Not TextBoxCheckIsbn.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM livre where codeIsbn = " & TextBoxCheckIsbn.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()
                ListView2.Items.Clear()
                While data.Read
                    ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7)}))
                End While
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("veillez d'abord remplir le champ de la recherche Id Svp: ", MsgBoxStyle.Information, "Vérification")
        End If
    End Sub

    Private Sub PictureBoxCheckTitre_Click(sender As Object, e As EventArgs) Handles PictureBoxCheckTitre.Click
        Try
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM `livre` WHERE `titreLivre` LIKE '" & TextBoxCheckTitre.Text & "' "

            'SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%Jor%'
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
            End While

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub PictureBoxCHeckAuteur_Click(sender As Object, e As EventArgs) Handles PictureBoxCHeckAuteur.Click
        Try
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM `livre` WHERE `auteurLivre` LIKE '" & TextBoxCheckAuteur.Text & "' "

            'SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%Jor%'
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
            End While

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class