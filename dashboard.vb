Imports System.Diagnostics.Eventing.Reader
'Imports NJGAD.Feedback1
Public Class dashboard
    Dim isCollapsed As Boolean = True
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Size = Panel5.MinimumSize

        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
        Timer2.Interval = 1500
        Timer2.Start()

        Timer3.Interval = 2000
        Timer3.Start()

        Timer4.Interval = 1500
        Timer4.Start()
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub AboutUsbtn_Click(sender As Object, e As EventArgs) Handles AboutUsbtn.Click
        SlidePanel.Show()

        SlidePanel.Height = AboutUsbtn.Height
        SlidePanel.Top = AboutUsbtn.Top
        switchPanel(AboutUs)

    End Sub

    Private Sub AvailableItemsbtn_Click(sender As Object, e As EventArgs) Handles AvailableItemsbtn.Click
        Timer1.Start()
        'SlidePanel.Location = AvailableItems.Location
        SlidePanel.Hide()
        SlidePanel.Height = 100
        SlidePanel.Top = 26
        switchPanel(AvailableItems)
    End Sub

    Private Sub Billingbtn_Click(sender As Object, e As EventArgs) Handles Billingbtn.Click
        SlidePanel.Height = Billingbtn.Height
        SlidePanel.Top = Billingbtn.Top
        SlidePanel.Show()
        switchPanel(billing)
    End Sub

    Private Sub ReachUsbtn_Click(sender As Object, e As EventArgs) Handles ReachUsbtn.Click
        SlidePanel.Height = ReachUsbtn.Height
        SlidePanel.Top = ReachUsbtn.Top
        SlidePanel.Show()
        switchPanel(reachUs)
    End Sub

    Private Sub Feedbackbtn_Click(sender As Object, e As EventArgs) Handles Feedbackbtn.Click
        SlidePanel.Height = Feedbackbtn.Height
        SlidePanel.Top = Feedbackbtn.Top
        SlidePanel.Show()
        switchPanel(feedback)
    End Sub

    Private Sub FAQsbtn_Click(sender As Object, e As EventArgs) Handles FAQsbtn.Click
        SlidePanel.Height = FAQsbtn.Height
        SlidePanel.Top = FAQsbtn.Top
        SlidePanel.Show()
        switchPanel(faq)
    End Sub

    Private Sub Logoutbtn_Click(sender As Object, e As EventArgs) Handles Logoutbtn.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            Panel5.Height += 10


            If Panel5.Size = Panel5.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If

        Else
            Panel5.Height -= 10

            If isCollapsed Then

            End If

            If Panel5.Size = Panel5.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(Burger)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(pizza)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(wraps)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(fries)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(beverages)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim tempImage As Image = PictureBox4.Image
        PictureBox4.Image = PictureBox12.Image
        PictureBox12.Image = tempImage
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim tempImage1 As Image = PictureBox14.Image
        PictureBox14.Image = PictureBox6.Image
        PictureBox6.Image = tempImage1
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim tempImage2 As Image = PictureBox14.Image
        PictureBox14.Image = PictureBox11.Image
        PictureBox11.Image = tempImage2
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
