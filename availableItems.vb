Imports System.Runtime.CompilerServices

Public Class AvailableItems

    ' Add buttons

    Private Sub btnItem1_Click(sender As Object, e As EventArgs)
        ' Me.Visible = False
        '  Burger.Show()

        ' switchPanel(Burger)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ' switchPanel(wraps)

    End Sub

    Private Sub AvailableItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Me.Size = New System.Drawing.Size(500, 500)

        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
    End Sub

    Sub switchPanel(ByVal panel As Form)
        ' Panel1.Controls.clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
        'changes
        '  Panel1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ' switchPanel(pizza)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'switchPanel(fries)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        'switchPanel(beverages)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class