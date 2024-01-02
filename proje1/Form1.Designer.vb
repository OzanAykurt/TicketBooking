<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        homePageButton = New Button()
        aboutButton = New Button()
        getTicketButton = New Button()
        AnasayfaYazi1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' homePageButton
        ' 
        homePageButton.Location = New Point(128, 68)
        homePageButton.Name = "homePageButton"
        homePageButton.Size = New Size(94, 29)
        homePageButton.TabIndex = 0
        homePageButton.Text = "Home Page"
        homePageButton.UseVisualStyleBackColor = True
        ' 
        ' aboutButton
        ' 
        aboutButton.Location = New Point(254, 68)
        aboutButton.Name = "aboutButton"
        aboutButton.Size = New Size(160, 29)
        aboutButton.TabIndex = 1
        aboutButton.Text = "About Auditorium"
        aboutButton.UseVisualStyleBackColor = True
        ' 
        ' getTicketButton
        ' 
        getTicketButton.Location = New Point(446, 68)
        getTicketButton.Name = "getTicketButton"
        getTicketButton.Size = New Size(94, 29)
        getTicketButton.TabIndex = 2
        getTicketButton.Text = "Get Tickets"
        getTicketButton.UseVisualStyleBackColor = True
        ' 
        ' AnasayfaYazi1
        ' 
        AnasayfaYazi1.AutoSize = True
        AnasayfaYazi1.Location = New Point(128, 34)
        AnasayfaYazi1.Name = "AnasayfaYazi1"
        AnasayfaYazi1.Size = New Size(241, 20)
        AnasayfaYazi1.TabIndex = 3
        AnasayfaYazi1.Text = "Akıngüç Auditorium and Art Center"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.AkingucLogo
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.anasayfa
        PictureBox2.Location = New Point(12, 136)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(540, 302)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(564, 450)
        Controls.Add(PictureBox1)
        Controls.Add(AnasayfaYazi1)
        Controls.Add(getTicketButton)
        Controls.Add(aboutButton)
        Controls.Add(homePageButton)
        Controls.Add(PictureBox2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Akıngüç Auditorium Ticket Purchasing Application"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents homePageButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents getTicketButton As Button
    Friend WithEvents AnasayfaYazi1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
