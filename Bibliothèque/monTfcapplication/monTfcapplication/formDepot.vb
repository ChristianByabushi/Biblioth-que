Imports MySql.Data.MySqlClient
Public Class formDepot
    Dim rqt As String
    Dim cmd As MySqlCommand
    Dim cn As New MySqlConnection
    Dim Iselection As Integer
    Dim monTextMat As String = ""
    Dim monTextIsbn As String = ""
    Dim nomLivre, codeIsn, codeMat, titreLivre, auteurLivre, genreLivre As String
    Dim dateEdi As Date
    Dim autorisation As Boolean

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Show()
    End Sub
    Sub rechercheLivre()

        If Not TextCodeisbn.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM emprunt where codeIsbnLivreEmp = " & Val(TextCodeisbn.Text)
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()
                While data.Read
                    codeMat = data(0)
                    TextBoxMatricule.Text = data(0)
                    TextBoxnom.Text = data(1)

                    codeIsn = data(4)

                    TextBoxPostnom.Text = data(2)
                    TextBoxPrenom.Text = data(3)

                    TextTitre.Text = data(6)
                    nomLivre = data(6)

                    TextAuteurLivre.Text = data(7)
                    auteurLivre = data(7)

                    TextBoxGenre.Text = data(8)
                    genreLivre = data(8)
                    DateEdition.Value = data(9)
                    dateEdi = data(9)

                    dateEmpruntLivre.Value = data(10)
                    dateDepotLivre.Value = data(11)
                End While

                If Not data.Read Then
                    MsgBox("Code Isbn non correspondant", MsgBoxStyle.Exclamation, "Erreur depot livre")
                End If

                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Code Isbn incorrect ou soit non existant ", MsgBoxStyle.Exclamation, "VERIFICATION")
        End If
    End Sub
    Private Sub chekIsbn(sender As Object, e As EventArgs) Handles PictureBox3.Click
        rechercheLivre()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        rechercheAvecMatricule()
    End Sub
    Sub rechercheAvecMatricule()

        If Not Val(TextBoxMatricule.Text) = 0 Then

            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM emprunt where matriculeEmprunteur = " & TextBoxMatricule.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()
                While data.Read
                    TextCodeisbn.Text = data(4)
                    codeIsn = data(4)
                    codeMat = data(0)

                    TextBoxnom.Text = data(1)
                    TextBoxPostnom.Text = data(2)
                    TextBoxPrenom.Text = data(3)

                    TextTitre.Text = data(6)
                    nomLivre = data(6)

                    TextAuteurLivre.Text = data(7)
                    auteurLivre = data(7)

                    TextBoxGenre.Text = data(8)
                    genreLivre = data(8)

                    DateEdition.Value = data(9)
                    dateEdi = data(9)

                    dateEmpruntLivre.Value = data(10)
                    dateDepotLivre.Value = data(11)

                End While
                If data.Read Then
                Else
                    MsgBox("Matricule non correspondant", MsgBoxStyle.Exclamation, "Erreur depot livre")
                End If

                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Matricule incorrect ou soit non existant ", MsgBoxStyle.Exclamation, "VERIFICATION")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Depot.Click
        rechercheLivrePourDepot()

        If Not (TextTitre.Text = "" And TextAuteurLivre.Text = "" And autorisation = False) Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "insert into livre values('" & TextCodeisbn.Text & "',Null,'" & TextTitre.Text & "','" & TextAuteurLivre.Text & "','" & TextBoxGenre.Text & "','" & Me.DateEdition.Value.ToString("yyyy-MM-dd") & "')"
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteNonQuery()
                MsgBox("Dépot du livre effectué avec succès", MsgBoxStyle.Information, "Depot")
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                'MsgBox(" Il y a erreur, veuillez vérifier les coordonnées et la connexion à la base des données", MsgBoxStyle.Information, "Erreur")
            End Try

            Try
                rqt = "DELETE FROM emprunt  WHERE codeIsbnLivreEmp = " & codeIsn
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteReader()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, "Verification")
            End Try
        Else
            MsgBox("Veuillez Remplir tous les champs Concernant le livre, Svp", MsgBoxStyle.Information, "Vérification")
        End If
    End Sub

    Sub rechercheLivrePourDepot()

        If Not TextCodeisbn.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM livre where codeIsbn = " & TextCodeisbn.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()

                If data.Read Then
                    autorisation = False
                    MsgBox("Modifier le code isbn du livre, un tel id existe dejà ", MsgBoxStyle.Exclamation, "Depot du livre")
                Else
                    autorisation = True
                End If

                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try



        Else
            MsgBox("veillez d'abord remplir le champ de la recherche Id Svp: ")
        End If

    End Sub
End Class