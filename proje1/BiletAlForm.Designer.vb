<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BiletAlForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBox2 = New PictureBox()
        homePageText1 = New Label()
        getTicketButton = New Button()
        aboutButton = New Button()
        homePageButton = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        ComboBoxEvent = New ComboBox()
        ComboBoxDate = New ComboBox()
        reservationButton = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label2 = New Label()
        Label3 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AkingucLogo
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' homePageText1
        ' 
        homePageText1.AutoSize = True
        homePageText1.Location = New Point(128, 30)
        homePageText1.Name = "homePageText1"
        homePageText1.Size = New Size(241, 20)
        homePageText1.TabIndex = 14
        homePageText1.Text = "Akıngüç Auditorium and Art Center"
        ' 
        ' getTicketButton
        ' 
        getTicketButton.Location = New Point(446, 64)
        getTicketButton.Name = "getTicketButton"
        getTicketButton.Size = New Size(94, 29)
        getTicketButton.TabIndex = 13
        getTicketButton.Text = "Get Tickets"
        getTicketButton.UseVisualStyleBackColor = True
        ' 
        ' aboutButton
        ' 
        aboutButton.Location = New Point(254, 64)
        aboutButton.Name = "aboutButton"
        aboutButton.Size = New Size(160, 29)
        aboutButton.TabIndex = 12
        aboutButton.Text = "About Auditorium"
        aboutButton.UseVisualStyleBackColor = True
        ' 
        ' homePageButton
        ' 
        homePageButton.Location = New Point(128, 64)
        homePageButton.Name = "homePageButton"
        homePageButton.Size = New Size(94, 29)
        homePageButton.TabIndex = 11
        homePageButton.Text = "Home Page"
        homePageButton.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(12, 244)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(548, 232)
        FlowLayoutPanel1.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 210)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 20)
        Label1.TabIndex = 17
        Label1.Text = "Select the Seat(s) Numbers You Want to Buy Tickets:"
        ' 
        ' ComboBoxEvent
        ' 
        ComboBoxEvent.FormattingEnabled = True
        ComboBoxEvent.Location = New Point(45, 165)
        ComboBoxEvent.Name = "ComboBoxEvent"
        ComboBoxEvent.Size = New Size(261, 28)
        ComboBoxEvent.TabIndex = 19
        ' 
        ' ComboBoxDate
        ' 
        ComboBoxDate.FormattingEnabled = True
        ComboBoxDate.Location = New Point(364, 165)
        ComboBoxDate.Name = "ComboBoxDate"
        ComboBoxDate.Size = New Size(150, 28)
        ComboBoxDate.TabIndex = 20
        ' 
        ' reservationButton
        ' 
        reservationButton.Location = New Point(196, 507)
        reservationButton.Name = "reservationButton"
        reservationButton.Size = New Size(141, 29)
        reservationButton.TabIndex = 21
        reservationButton.Text = "Get Ticket"
        reservationButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(56, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(239, 20)
        Label2.TabIndex = 22
        Label2.Text = "Select the event you want to go to:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(359, 133)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 20)
        Label3.TabIndex = 23
        Label3.Text = "Select Event Date:"
        ' 
        ' BiletAlForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(572, 559)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(reservationButton)
        Controls.Add(ComboBoxDate)
        Controls.Add(ComboBoxEvent)
        Controls.Add(Label1)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(PictureBox2)
        Controls.Add(homePageText1)
        Controls.Add(getTicketButton)
        Controls.Add(aboutButton)
        Controls.Add(homePageButton)
        MaximizeBox = False
        MinimizeBox = False
        Name = "BiletAlForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Akıngüç Auditorium Ticket Purchasing Application"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents homePageText1 As Label
    Friend WithEvents getTicketButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents homePageButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxEvent As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ComboBoxDate As ComboBox
    Friend WithEvents reservationButton As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
