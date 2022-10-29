Imports MySql.Data.MySqlClient
Imports System.DateTime
Public Class formUtilisateur
    Dim rqt As String
    Dim cmd As MySqlCommand
    Dim cn As New MySqlConnection
    Dim Iselection As Integer


    Private Sub formUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView2.FullRowSelect = True
        afficherAvecLIstview()
    End Sub
    Private Sub afficherAvecLIstview()
        Try
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM utilisateur"
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
    End Sub

    'Private Sub affichageLivreAvecData()
    '    cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
    '    rqt = "SELECT * FROM utilisateur"
    '    cn.Open()
    '    cmd = New MySqlCommand(rqt, cn)
    '    Dim data As New MySqlDataAdapter
    '    data.SelectCommand = cmd
    '    Dim mydata As New DataTable
    '    data.Fill(mydata)
    '    DatagrdAffLIvre.DataSource = mydata
    '    cn.Close()
    'End Sub

    Private Sub BoutonAjouterUtilisataire(sender As Object, e As EventArgs) Handles Button4.Click
        Dim veriDate As Boolean = False

        If DateNaissanceUt.Value.Year < "1789" And DateNaissanceUt.Value.Month < "1" And DateNaissanceUt.Value.Day < "1" Then
            veriDate = False
            MsgBox("Verifier bien la date", MsgBoxStyle.OkOnly, "Date Vérification")
        Else
            veriDate = True
        End If

        If Not (TextMatrUt.Text = "" Or TextNomResearch.Text = "" Or TextNumTel.Text = "" Or TextPostUt.Text = "" Or TextPrenomUt.Text = "" Or SexeUT.Text = "" Or PromotionUt.Text = "" Or veriDate = False) Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "insert into utilisateur values('" & Val(TextMatrUt.Text) & "','" & TextNomUT.Text & "','" & TextPostUt.Text & "','" & TextPrenomUt.Text & "','" & SexeUT.SelectedItem & "','" & PromotionUt.Text & "','" & Val(TextNumTel.Text) & "','" & DateNaissanceUt.Value.ToString("yyyy-MM-dd") & "')"
                cn.Open()
                cmd = New MySqlCommand(rqt, cn)
                cmd.ExecuteNonQuery()
                afficherAvecLIstview()
                MsgBox("Ajout d'un nouvel enregistrement réussi avec succès", MsgBoxStyle.Information, "ADD of Successfull")

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Veuillez Remplir tous les champs, Svp", MsgBoxStyle.Information, "Message de Vérification")
        End If
    End Sub
    Private Sub Rechecher(sender As Object, e As EventArgs)
        TextBoxsearchAUto.Text = ""
    End Sub
    Private Sub ButtonnSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonnSupprimer.Click
        Try
            rqt = "DELETE FROM utilisateur  WHERE matriculeUt = " & ListView2.Items(Iselection).Text
            cn.Open()
            cmd = New MySqlCommand(rqt, cn)
            cmd.ExecuteReader()
            cn.Close()
            afficherAvecLIstview()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ModifierVotreut.Click
        Dim veriDate As Boolean = False

        If DateNaissanceUt.Value.Year < "1789" And DateNaissanceUt.Value.Month < "1" And DateNaissanceUt.Value.Day < "1" Then
            veriDate = False
            MsgBox("Verifier bien la date", MsgBoxStyle.OkOnly, "Date Vérification")
        Else
            veriDate = True
        End If


        If Not (TextNomResearch.Text = "" Or TextNumTel.Text = "" Or TextPostUt.Text = "" Or TextPrenomUt.Text = "" Or SexeUT.Text = "" Or PromotionUt.Text = "" Or veriDate = False) Then
            Try
                rqt = "UPDATE utilisateur SET nomUt ='" & TextNomUT.Text & "', postUt ='" & TextPostUt.Text & "', prenomUt ='" & TextPrenomUt.Text & "', sexeUt ='" & SexeUT.Text & "', promotionUt ='" & PromotionUt.Text & "', numTelUt = '" & TextNumTel.Text & "', dateNaissanceUt ='" & DateNaissanceUt.Value.ToString("yyyy-MM-dd") & "'  WHERE matriculeUt = " & ListView2.Items(Iselection).Text
                cmd = New MySqlCommand(rqt, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()
                afficherAvecLIstview()
                MsgBox("Modification de l'enregistrement faite avec succès", MsgBoxStyle.Information, "Information ")
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Veuillez Remplir tous les champs necessaires avant la modification, Svp", MsgBoxStyle.Exclamation, "Fenetre Modification ")
        End If
    End Sub

    Private Sub ListView2_Click(sender As Object, e As EventArgs) Handles ListView2.Click
        Try
            Iselection = ListView2.SelectedIndices(0)
            'TextMatrUt.Text = ListView2.Items(Iselection).SubItems(0).Text
            TextNomUT.Text = ListView2.Items(Iselection).SubItems(1).Text
            TextPostUt.Text = ListView2.Items(Iselection).SubItems(2).Text
            TextPrenomUt.Text = ListView2.Items(Iselection).SubItems(3).Text
            SexeUT.Text = ListView2.Items(Iselection).SubItems(4).Text
            PromotionUt.Text = ListView2.Items(Iselection).SubItems(5).Text
            TextNumTel.Text = ListView2.Items(Iselection).SubItems(6).Text
            DateNaissanceUt.Text = ListView2.Items(Iselection).SubItems(7).Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub PictureRearchWithId(sender As Object, e As EventArgs) Handles PictureResearchWithID.Click
        If Not TextboxRechercher.Text = "" Then
            Try
                cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
                rqt = "SELECT * FROM utilisateur where matriculeUT = " & TextboxRechercher.Text
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
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

   
    Private Sub actualiser(sender As Object, e As EventArgs) Handles PictureBox9.Click, Label21.Click
        afficherAvecLIstview()
    End Sub

    Private Sub TriPromotioN(sender As Object, e As EventArgs) Handles TriGenre.SelectedIndexChanged

        Try
            Dim nbreEmprunt As Integer = 0
            cn = New MySqlConnection("server = localhost; database = bibliotheque; user id = root; pwd = ")
            rqt = "SELECT * FROM `utilisateur` WHERE `promotionUt` LIKE '" & TriGenre.SelectedItem & "' "
            'SELECT * FROM `emprunt` WHERE `nomEmprunteur` LIKE '%Jor%'
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

    End Sub
End Class