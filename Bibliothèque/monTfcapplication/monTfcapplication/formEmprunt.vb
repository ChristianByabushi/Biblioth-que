Imports MySql.Data.MySqlClient
Public Class formEmprunt
    Dim rqt As String
    Dim cmd As MySqlCommand
    Dim cn As New MySqlConnection
    Dim Iselection As Integer
    Dim monTextMat As String = ""
    Dim monTextIsbn As String = ""

    Dim autorisation1, autorisation2, autorisation3, autorisation4 As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub afficherAvecLIstview()

        Try
            Dim nbreEmprunt As Integer = 0
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM emprunt"
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5), data(10), data(11)}))
                nbreEmprunt = nbreEmprunt + 1
            End While
            LabelnbreEmp.Text = nbreEmprunt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub resercherUtilisateur(sender As Object, e As EventArgs) Handles PictureBox3.Click, Label4.Click
        rechercheUtilisateur()
    End Sub
    Sub rechercheUTEmprunt()
        autorisation3 = False
        If Not TextMatriculeUt.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM emprunt where matriculeEmprunteur = " & TextMatriculeUt.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()

                If data.Read Then
                    autorisation3 = False
                Else
                    autorisation3 = True
                End If
                While data.Read

                    If data(0) = TextMatriculeUt.Text Then
                        MsgBox("Dejà, tu as un livre non Remis", MsgBoxStyle.Exclamation, "Attention, veuillez vous en souvenir")
                        autorisation3 = False
                    Else
                        autorisation3 = True
                    End If
                End While

                cn.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else

        End If

    End Sub
    Sub rechercheUtilisateur()
        TextnomUt.Text = ""
        TextPrenomUt.Text = ""
        TextPostUt.Text = ""
        autorisation1 = False
        If Not TextMatriculeUt.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM utilisateur where matriculeUT = " & TextMatriculeUt.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()
                While data.Read
                    monTextMat = data(0)
                    TextnomUt.Text = data(1)
                    TextPrenomUt.Text = data(3)
                    TextPostUt.Text = data(2)
                    ComboPromoUt.Text = data(5)
                    If data(0) = TextMatriculeUt.Text Then
                        MsgBox("ok ,Utilisateur Existant", MsgBoxStyle.Information, "Fenetre veri Utilisateur")
                        autorisation1 = True
                    End If
                End While
                cn.Close()
                If TextnomUt.Text = "" Or TextPostUt.Text = "" Or TextPrenomUt.Text = "" Then
                    MsgBox("Utilisateur non existant dans la bases des données", MsgBoxStyle.Information, "Chech User ")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("veillez d'abord remplir le champ de la recherche Id Svp: ")
        End If

    End Sub
    Sub rechercheLivre()
        TextTitreLivre.Text = ""
        TextGenreLivre.Text = ""
        TextauteurLivre.Text = ""
        autorisation2 = False
        If Not codeIsbn.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM livre where codeIsbn = " & codeIsbn.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()

                While data.Read
                    monTextIsbn = data(0)
                    TextTitreLivre.Text = data(2)
                    TextauteurLivre.Text = data(3)
                    TextGenreLivre.Text = data(4)
                    DateEdition.Text = data(5)

                    If data(0) = codeIsbn.Text Then
                        MsgBox("Parfait, Ce livre existe", MsgBoxStyle.Information, "Fenetre Veri Livre")
                        autorisation2 = True
                    End If

                End While
                cn.Close()
                If TextTitreLivre.Text = "" Or TextauteurLivre.Text = "" Then
                    MsgBox("Ce livre a été rétiré ou n'existe pas ici", MsgBoxStyle.Information, "Fenetre Livre")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("veillez d'abord remplir le champ de la recherche Id Svp: ")
        End If
    End Sub
    Sub rechercheLIvreExist()
        autorisation4 = True
        If Not codeIsbn.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM emprunt where codeIsbnLivreEmp = " & codeIsbn.Text
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                Dim data = cmd.ExecuteReader()


                If data.Read Then
                    autorisation4 = False
                Else
                    autorisation4 = True
                End If
                While data.Read
                    If data(0) = monTextIsbn Then
                        MsgBox("Ce Livre a été rétiré par un autre Utilisateur", MsgBoxStyle.Information, "Information")
                        autorisation4 = False
                    Else
                        autorisation4 = True
                    End If
                End While
                cn.Close()
                If TextTitreLivre.Text = "" Or TextauteurLivre.Text = "" Then
                    MsgBox("Ce livre n'existe pas dans la bases des données")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Le Champ du codeISSBN est Vide", MsgBoxStyle.Information, "Vérification Code Issbn")
        End If
    End Sub

    Private Sub ValiderEmprunt(sender As Object, e As EventArgs)
        
    End Sub
    Private Sub rechercheLIVRE(sender As Object, e As EventArgs) Handles PictureBox4.Click, Label14.Click
        rechercheLivre()
    End Sub

    Sub rechercheAvecTexte()
        Try
            Dim nbreEmprunt As Integer = 0
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '" & TextnomUt.Text & "' "
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                'MsgBox(FormatDateTime(CDate(data(6))))
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
                'ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8)}))
                nbreEmprunt = nbreEmprunt + 1
            End While
            LabelnbreEmp.Text = nbreEmprunt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Try
            Dim nbreEmprunt As Integer = 0
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            'rqt = "SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '" & TextnomUt.Text & "' "

            'SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%Jor%'
            'rqt = " SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%'" & TextnomUt.Text & "'%' "
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            Dim data = cmd.ExecuteReader()
            ListView2.Items.Clear()
            While data.Read
                'MsgBox(FormatDateTime(CDate(data(6))))
                ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5)}))
                'ListView2.Items.Add(New ListViewItem({data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8)}))
                nbreEmprunt = nbreEmprunt + 1
            End While
            LabelnbreEmp.Text = nbreEmprunt
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Actualiser(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label21.Click
        afficherAvecLIstview()
    End Sub

    
    Private Sub EmpruntDemarrer(sender As Object, e As EventArgs) Handles PictureBox2.Click, Label3.Click
        rechercheUTEmprunt()
        rechercheLIvreExist()

        If autorisation1 = True And autorisation2 = True And autorisation3 = True And autorisation4 Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "insert into emprunt values('" & monTextMat & "','" & TextnomUt.Text & "','" & TextPostUt.Text & "','" & TextPrenomUt.Text & "','" & monTextIsbn & "','" & TextTitreLivre.Text & "','" & TextTitreLivre.Text & "','" & TextauteurLivre.Text & "','" & TextGenreLivre.Text & "','" & DateEdition.Value.ToString("yyyy-MM-dd") & "','" & DateDepot.Value.ToString("yyyy-MM-dd") & "','" & Date.Now.ToString("yyyy-MM-dd") & "',Null)"
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteNonQuery()
                afficherAvecLIstview()
                cn.Close()
                MsgBox("Emprunt du livre possible, Octroyez le livre!!")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Try
                rqt = "DELETE FROM livre  WHERE codeIsbn = " & monTextIsbn
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteReader()
                cn.Close()
                afficherAvecLIstview()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Impossible D'octroyer soit tu a un livre non remis ou le livre a été remis à unautre", MsgBoxStyle.OkCancel, "Fenetre Impo")
        End If
        autorisation1 = False
        autorisation2 = False
        autorisation3 = False
        autorisation4 = False
    End Sub

    Private Sub formEmprunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficherAvecLIstview()
    End Sub

End Class