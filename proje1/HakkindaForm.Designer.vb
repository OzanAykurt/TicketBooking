<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HakkindaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HakkindaForm))
        homePageText1 = New Label()
        getTicketButton = New Button()
        aboutButton = New Button()
        homePageButton = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' homePageText1
        ' 
        homePageText1.AutoSize = True
        homePageText1.Location = New Point(128, 30)
        homePageText1.Name = "homePageText1"
        homePageText1.RightToLeft = RightToLeft.No
        homePageText1.Size = New Size(241, 20)
        homePageText1.TabIndex = 7
        homePageText1.Text = "Akıngüç Auditorium and Art Center"
        ' 
        ' getTicketButton
        ' 
        getTicketButton.Location = New Point(446, 64)
        getTicketButton.Name = "getTicketButton"
        getTicketButton.Size = New Size(94, 29)
        getTicketButton.TabIndex = 6
        getTicketButton.Text = "Get Tickets"
        getTicketButton.UseVisualStyleBackColor = True
        ' 
        ' aboutButton
        ' 
        aboutButton.Location = New Point(254, 64)
        aboutButton.Name = "aboutButton"
        aboutButton.Size = New Size(160, 29)
        aboutButton.TabIndex = 5
        aboutButton.Text = "About Auditorium"
        aboutButton.UseVisualStyleBackColor = True
        ' 
        ' homePageButton
        ' 
        homePageButton.Location = New Point(128, 64)
        homePageButton.Name = "homePageButton"
        homePageButton.Size = New Size(94, 29)
        homePageButton.TabIndex = 4
        homePageButton.Text = "Home Page"
        homePageButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.akingucOditoryum
        PictureBox1.Location = New Point(12, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(522, 175)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(-4, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(556, 220)
        Label1.TabIndex = 9
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.AkingucLogo
        PictureBox2.Location = New Point(12, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' HakkindaForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(553, 545)
        Controls.Add(PictureBox2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(homePageText1)
        Controls.Add(getTicketButton)
        Controls.Add(aboutButton)
        Controls.Add(homePageButton)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "HakkindaForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterScreen
        Text = "Akıngüç Auditorium Ticket Purchasing Application"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents homePageText1 As Label
    Friend WithEvents getTicketButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents homePageButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
