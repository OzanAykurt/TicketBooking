Public Class Form1
    'The functions of the Home Page, About and Buy Ticket buttons here are;
    Private Sub homePageButton_Click(sender As Object, e As EventArgs) Handles homePageButton.Click
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim aboutForm As New HakkindaForm()
        aboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub getTicketButton_Click(sender As Object, e As EventArgs) Handles getTicketButton.Click
        Dim getTicketForm As New BiletAlForm()
        getTicketForm.Show()
        Me.Hide()
    End Sub

    'To avoid changing the size of the tab;
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub


End Class