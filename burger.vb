Imports Microsoft.SqlServer
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Data.SqlTypes
'Imports Microsoft.SqlServer
'Imports MySql.Data.MySqlClient
'Imports Mysqlx
'Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Drawing.Printing
Public Class Burger
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
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' switchPanel(AboutUs)
    End Sub
    Sub switchPanel(ByVal panel As Burger)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Burger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Me.Size = New System.Drawing.Size(500, 500)
        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Me.Visible = False
        Form1.Show()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label1.Text & "','" & Integer.Parse(Label6.Text) & "','" & TextBox1.Text & "','" & (Val(Label6.Text * Val(TextBox1.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label10.Text & "','" & Integer.Parse(Label5.Text) & "','" & TextBox2.Text & "','" & (Val(Label5.Text * Val(TextBox2.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label15.Text & "','" & Integer.Parse(Label11.Text) & "','" & TextBox3.Text & "','" & (Val(Label11.Text * Val(TextBox3.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label30.Text & "','" & Integer.Parse(Label26.Text) & "','" & TextBox4.Text & "','" & (Val(Label26.Text * Val(TextBox4.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label25.Text & "','" & Integer.Parse(Label16.Text) & "','" & TextBox5.Text & "','" & (Val(Label16.Text * Val(TextBox5.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label20.Text & "','" & Integer.Parse(Label21.Text) & "','" & TextBox6.Text & "','" & (Val(Label21.Text * Val(TextBox6.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class