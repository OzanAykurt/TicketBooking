Public Class HakkindaForm

    'The functions of the Home Page, About and Buy Ticket buttons here are;
    Private Sub homePageButton_Click(sender As Object, e As EventArgs) Handles homePageButton.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
    End Sub

    Private Sub getTicketButton_Click(sender As Object, e As EventArgs) Handles getTicketButton.Click
        Dim getTicketForm As New BiletAlForm()
        getTicketForm.Show()
        Me.Hide()
    End Sub

    'To avoid changing the size of the tab;
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
    End Sub


    Private Sub aboutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub homePageText1_Click(sender As Object, e As EventArgs) Handles homePageText1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class