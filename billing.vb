Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class billing
    Dim sqlconn As New MySqlConnection
    Dim sqlcmd As New MySqlCommand
    Dim sqlrd As MySqlDataReader
    Dim sqldt As New DataTable
    Dim dataadp As New MySqlDataAdapter
    Dim sqlquery As String

    Dim server As String = "localhost"
    Dim uname As String = "root"
    Dim pass As String = "syco2@9"
    Dim dbname As String = "myconnector1"
    Dim temp As Double
     Dim final As Double = 0.0
    Private bitmap As Bitmap
    Private Sub updateTable()
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "Select ProdName,Price,Qty,Total from myconnector1.receipt"

        sqlrd = sqlcmd.ExecuteReader
        sqldt.Load(sqlrd)
        sqlrd.Close()
        sqlconn.Close()
        DataGridView1.DataSource = sqldt
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'If RadioButton2.Checked = True Then
        'PictureBox4.Image = Image.FromFile("D:\desktop\NJ  GAD\lock1.jpg")
        'Else
        'PictureBox4.Image = Nothing
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
        'updateTable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(InvoiceNum,Name,PhNo,Date)
values('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Text & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
        updateTable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim name1 As String
        Dim price1, qty1, total1 As Integer
        Try
            name1 = DataGridView1.SelectedRows(0).Cells(0).Value.ToString
            price1 = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            qty1 = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            total1 = DataGridView1.SelectedRows(0).Cells(3).Value.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Doc.DefaultPageSettings.PaperSize = New PaperSize("custom", 250, 600) '2.5 inches by 6 inches
        PPD.WindowState = FormWindowState.Maximized
        PPD.PrintPreviewControl.Zoom = 2.5

        PPD.Document = Doc
        PPD.ShowDialog()
    End Sub


    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Doc.PrintPage
        'Fonts
        Dim f6b As New Font("Times New Roman", 6, FontStyle.Bold)
        Dim f4 As New Font("Times New Roman", 4, FontStyle.Regular)
        Dim f6 As New Font("Times New Roman", 6, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)


        'alignments
        Dim left As New StringFormat
        Dim center As New StringFormat
        Dim right As New StringFormat

        left.Alignment = StringAlignment.Near
        center.Alignment = StringAlignment.Center
        right.Alignment = StringAlignment.Far

        'rectangle(x,y,width,height)
        Dim l1 As New Rectangle(0, 65, 250, 1)

        Dim Rect1 As New Rectangle(5, 5, 240, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect1)
        e.Graphics.DrawString("NXT CAPITAL DELIGHT", f10b, Brushes.Black, Rect1, center)

        Dim Rect2 As New Rectangle(5, 25, 240, 20)
        e.Graphics.DrawRectangle(Pens.Black, Rect2)
        e.Graphics.DrawString("Ground Floor , Rashmi Tanmay , Eden Rose Complex , Beverly Park , Mira Road(E)", f6, Brushes.Black, Rect2, center)

        Dim Rect3 As New Rectangle(5, 45, 240, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect3)
        e.Graphics.DrawString("Pin : 401107 , Dist. Thane , Ph : +91 7718883299", f6, Brushes.Black, Rect3, center)

        e.Graphics.DrawRectangle(Pens.Black, l1)

        Dim Rect4 As New Rectangle(5, 70, 60, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect4)
        e.Graphics.DrawString("ITEM", f6b, Brushes.Black, Rect4, center)

        Dim Rect5 As New Rectangle(65, 70, 60, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect5)
        e.Graphics.DrawString("PRICE", f6b, Brushes.Black, Rect5, center)

        Dim Rect6 As New Rectangle(125, 70, 60, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect6)
        e.Graphics.DrawString("QTY", f6b, Brushes.Black, Rect6, center)


        Dim Rect7 As New Rectangle(185, 70, 60, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect7)
        e.Graphics.DrawString("TOTAL", f6b, Brushes.Black, Rect7, center)

        Dim y As Integer = 90
        Dim price, qty As Double
        Dim total As Double = 0.0
        For i = 0 To DataGridView1.Rows.Count - 1
            price = DataGridView1.Rows(i).Cells(1).Value
            qty = DataGridView1.Rows(i).Cells(2).Value
            Dim Rect8 As New Rectangle(5, y, 60, 15)
            Dim Rect9 As New Rectangle(65, y, 60, 15)
            Dim Rect10 As New Rectangle(125, y, 60, 15)
            Dim Rect11 As New Rectangle(185, y, 60, 15)

            e.Graphics.DrawRectangle(Pens.Black, Rect8)
            e.Graphics.DrawRectangle(Pens.Black, Rect9)
            e.Graphics.DrawRectangle(Pens.Black, Rect10)
            e.Graphics.DrawRectangle(Pens.Black, Rect11)

            e.Graphics.DrawString("Pizza", f6, Brushes.Black, Rect8, center)
            e.Graphics.DrawString(price, f6, Brushes.Black, Rect9, center)
            e.Graphics.DrawString(qty, f6, Brushes.Black, Rect10, center)
            e.Graphics.DrawString(DataGridView1.Rows(i).Cells(1).Value * DataGridView1.Rows(i).Cells(2).Value, f6, Brushes.Black, Rect11, center)
            y += 15
            total += DataGridView1.Rows(i).Cells(3).Value
        Next

        Dim Rect12 As New Rectangle(5, y, 240, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect12)
        e.Graphics.DrawString("GRAND TOTAL :", f6b, Brushes.Black, Rect12, center)

        Dim Rect13 As New Rectangle(185, y, 60, 15)
        e.Graphics.DrawRectangle(Pens.Black, Rect13)
        Dim perc As Double
        perc = (18 / 100) * total
        final = total - perc

        e.Graphics.DrawString(final, f6b, Brushes.Black, Rect13, right)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Text = "18%"
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim total As Double = 0.0
        For i = 0 To DataGridView1.Rows.Count - 1
            total += DataGridView1.Rows(i).Cells(3).Value
        Next
        TextBox4.Text = total.ToString()
        temp = total
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox7.Text = "0%"
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim perc As Double
        perc = (18 / 100) * temp
        final = temp - perc

        TextBox6.Text = final.ToString()
    End Sub
End Class
