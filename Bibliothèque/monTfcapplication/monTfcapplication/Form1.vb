Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelPrincipalAccueil.Show()
    End Sub

    Private Sub btUtlisateur_MouseEnter(sender As Object, e As EventArgs) Handles pnlSousUtilisateur.MouseEnter, btUtlisateur.MouseEnter
        btUtlisateur.BackColor = Color.FromArgb(213, 93, 82)
        pnlSousUtilisateur.BackColor = Color.FromArgb(213, 93, 82)
    End Sub

    Private Sub btUtlisateur_MouseLeave(sender As Object, e As EventArgs) Handles pnlSousUtilisateur.MouseLeave, btUtlisateur.MouseLeave
        btUtlisateur.BackColor = Color.FromArgb(29, 81, 87)
        pnlSousUtilisateur.BackColor = Color.FromArgb(29, 81, 87)
    End Sub

    'Private Sub btAccueil_MouseEnter(sender As Object, e As EventArgs) Handles pnlSousAccueil.MouseEnter
   
    'End Sub

    'Private Sub btAccueil_MouseLeave(sender As Object, e As EventArgs) Handles pnlSousAccueil.MouseLeave
    '   
    'End Sub

    Private Sub btLivre_MouseEnter(sender As Object, e As EventArgs) Handles pnlSouslivre.MouseEnter, btLivre.MouseEnter
        btLivre.BackColor = Color.FromArgb(173, 162, 42)
        pnlSouslivre.BackColor = Color.FromArgb(173, 162, 42)
    End Sub

    Private Sub pnlSouslivre_MouseLeave(sender As Object, e As EventArgs) Handles pnlSouslivre.MouseLeave, btLivre.MouseLeave
        btLivre.BackColor = Color.FromArgb(29, 81, 87)
        pnlSouslivre.BackColor = Color.FromArgb(29, 81, 87)
    End Sub

    
    Private Sub btUtlisateur_Click(sender As Object, e As EventArgs) Handles pnlSousUtilisateur.Click, btUtlisateur.Click
        Me.Hide()
        formUtilisateur.Show()
    End Sub

    Private Sub btLivre_Click(sender As Object, e As EventArgs) Handles pnlSouslivre.Click, btLivre.Click
        Me.Hide()
        formLivre.Show()
    End Sub

    Private Sub BtEmprunt_MouseEnter(sender As Object, e As EventArgs) Handles PanelsousEmprunt.MouseEnter, BtEmprunt.MouseEnter
        BtEmprunt.BackColor = Color.FromArgb(116, 40, 148)
        PanelsousEmprunt.BackColor = Color.FromArgb(116, 40, 148)
    End Sub

    Private Sub BtEmprunt_MouseLeave(sender As Object, e As EventArgs) Handles PanelsousEmprunt.MouseLeave, BtEmprunt.MouseLeave
        BtEmprunt.BackColor = Color.FromArgb(29, 81, 87)
        PanelsousEmprunt.BackColor = Color.FromArgb(29, 81, 87)
    End Sub

   

    Private Sub BtDepot_MouseLeave(sender As Object, e As EventArgs) Handles sousPanelDépot.MouseLeave, BtDepot.MouseLeave
        BtDepot.BackColor = Color.FromArgb(29, 81, 87)
        sousPanelDépot.BackColor = Color.FromArgb(29, 81, 87)
    End Sub

    
    Private Sub BtDepot_MouseEnter(sender As Object, e As EventArgs) Handles sousPanelDépot.MouseEnter, BtDepot.MouseEnter
        BtDepot.BackColor = Color.FromArgb(252, 1, 151)
        sousPanelDépot.BackColor = Color.FromArgb(252, 1, 151)
    End Sub

    Private Sub PanelsousAcceuil_MouseEnter(sender As Object, e As EventArgs)
        pnlSousAc.BackColor = Color.FromArgb(74, 20, 58)
        btAccueil.BackColor = Color.FromArgb(74, 20, 58)
    End Sub

    Private Sub PanelsousAcceuil_MouseLeave(sender As Object, e As EventArgs)
        btAccueil.BackColor = Color.FromArgb(29, 81, 87)
        pnlSousAc.BackColor = Color.FromArgb(29, 81, 87)
    End Sub

    Private Sub EmprunterForm(sender As Object, e As EventArgs) Handles PanelsousEmprunt.Click, BtEmprunt.Click
        Me.Hide()
        formEmprunt.Show()
    End Sub
    Private Sub DepotDemarrer(sender As Object, e As EventArgs) Handles sousPanelDépot.Click, BtDepot.Click
        Me.Hide()
        formDepot.Show()
    End Sub

    Private Sub Fermer(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class
