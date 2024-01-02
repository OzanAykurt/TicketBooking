Public Class BiletAlForm
    Private selectedDate As String = ""
    Private selectedSeatsControl As New List(Of String)()
    Private selectedSeatCounter As Integer = 0

    'The functions of the Home Page, About and Buy Ticket buttons here are;
    Private Sub homePageButton_Click(sender As Object, e As EventArgs) Handles homePageButton.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim aboutForm As New HakkindaForm()
        aboutForm.Show()
        Me.Hide()
    End Sub

    Private Sub getTicketButton_Click(sender As Object, e As EventArgs) Handles getTicketButton.Click
    End Sub

    'In order not to change the size of the tab;
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
    End Sub



    Private selectedSeats As New List(Of String)() 'List of selected seats

    Private Sub seats(sender As Object, e As EventArgs)
        Dim seatNumber = 28 'The number of seats can be increased from here
        For i = 1 To seatNumber
            Dim seat As New Button
            seat.Text = "Seat " & i.ToString
            seat.Name = "Seat_" & i.ToString
            seat.Size = New Size(70, 50) 'Dimensions of seat tabs
            AddHandler seat.Click, AddressOf seat_Click
            FlowLayoutPanel1.Controls.Add(seat)
        Next
    End Sub

    Private Sub seat_Click(sender As Object, e As EventArgs)
        'Prevents seat selection before the event is selected;
        If ComboBoxEvent.SelectedItem Is Nothing Then
            MessageBox.Show("Please select an event first.")
            Exit Sub
        End If

        'Prevents seat selection without selecting a date;
        If ComboBoxDate.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a date first.")
            Exit Sub
        End If

        Dim selectedSeat As Button = DirectCast(sender, Button)
        Dim seatName As String = selectedSeat.Name 'Gets the name of the clicked seat

        If selectedSeats.Contains(seatName) Then
            selectedSeats.Remove(seatName)
            selectedSeat.BackColor = DefaultBackColor
        ElseIf selectedSeats.Count < 2 Then
            selectedSeats.Add(seatName)
            selectedSeat.BackColor = Color.Green
        Else
            MessageBox.Show("Two seat at most.")
        End If
    End Sub


    'Events ComboBox';
    Private Sub getTicketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxEvent.Items.Add("Cem Yılmaz Standup")
        ComboBoxEvent.Items.Add("Ozan Aykurt ile Yazılım Sohbetleri")

        seats(Nothing, Nothing)
    End Sub


    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Reset seat selection when there is any change in 'ComboBox'
        selectedSeats.Clear()

        For Each koltuk In FlowLayoutPanel1.Controls.OfType(Of Button)
            koltuk.BackColor = DefaultBackColor
        Next

        'As the event or date changes, it also clears the selectedDate variable
        selectedDate = ""
    End Sub

    Private Sub ComboBoxEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxEvent.SelectedIndexChanged
        selectedSeats.Clear() 'Resets selections if event is changed

        'Dates arrive according to the selected event;
        ComboBoxDate.Items.Clear()
        If ComboBoxEvent.SelectedItem IsNot Nothing Then
            Dim selectedEvent As String = ComboBoxEvent.SelectedItem.ToString()

            Select Case selectedEvent
                Case "Cem Yılmaz Standup"
                    ComboBoxDate.Items.Add("04.01.2024")
                    ComboBoxDate.Items.Add("14.01.2024")
                Case "Software Conversations with Ozan Aykurt"
                    ComboBoxDate.Items.Add("06.01.2024")
                    ComboBoxDate.Items.Add("17.01.2024")
                Case Else

            End Select
        End If

        For Each seat As Button In FlowLayoutPanel1.Controls.OfType(Of Button)()
            seat.BackColor = DefaultBackColor
            seat.Enabled = False
        Next
    End Sub

    Private Sub ComboBoxDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDate.SelectedIndexChanged
        'Activate seats when date selected
        For Each seat As Button In FlowLayoutPanel1.Controls.OfType(Of Button)()
            seat.Enabled = True
        Next
    End Sub

    Private Sub buttonReservation_Click(sender As Object, e As EventArgs) Handles reservationButton.Click
        If ComboBoxEvent.SelectedItem Is Nothing OrElse ComboBoxDate.SelectedItem Is Nothing Then
            MessageBox.Show("Please select event and date.")
            Return
        End If

        If selectedSeats.Count = 0 Then
            MessageBox.Show("Please choose at least one seat.")
            Return
        End If

        'Reservation
        Dim selectedEvent As String = ComboBoxEvent.SelectedItem.ToString()
        Dim selectedDate As String = ComboBoxDate.SelectedItem.ToString()
        Dim selectedSeatText As String = String.Join(", ", selectedSeats)
        Dim title As String = "Reservation Confirmation"

        MessageBox.Show(“Congratulations, your reservation is made!” & vbCrLf & vbCrLf & "Selected event: " & selectedEvent & vbCrLf & "Selected date: " & selectedDate & vbCrLf & "Selected seat: " & selectedSeatText, title)
    End Sub


    'Seat counter
    Public Class BiletAlForm
        Private selectedSeats As New List(Of String)()
        Private selectedSeatCounter As Integer = 0

        Private Sub seat_Click(sender As Object, e As EventArgs)
            Dim secilenKoltuk As Button = DirectCast(sender, Button)
            Dim koltukAdi As String = secilenKoltuk.Name

            If selectedSeats.Contains(koltukAdi) Then
                selectedSeats.Remove(koltukAdi)
                secilenKoltuk.BackColor = DefaultBackColor
                selectedSeatCounter -= 1
            ElseIf selectedSeatCounter < 2 Then
                selectedSeats.Add(koltukAdi)
                secilenKoltuk.BackColor = Color.Green
                selectedSeatCounter += 1
            Else
                MessageBox.Show("You can choose a maximum of two seats.")
            End If
        End Sub

    End Class

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class