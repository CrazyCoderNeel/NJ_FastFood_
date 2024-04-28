Imports MySql.Data.MySqlClient
Public Class pizza
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
    Private Sub pizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
        ControlBox = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label10.Text & "','" & Integer.Parse(Label5.Text) & "','" & TextBox1.Text & "','" & (Val(Label5.Text * Val(TextBox1.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.receipt(ProdName,Price,Qty,Total)
values('" & Label6.Text & "','" & Integer.Parse(Label4.Text) & "','" & TextBox2.Text & "','" & (Val(Label4.Text * Val(TextBox2.Text))) & "')"
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
values('" & Label15.Text & "','" & Integer.Parse(Label14.Text) & "','" & TextBox3.Text & "','" & (Val(Label14.Text * Val(TextBox3.Text))) & "')"
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
values('" & Label30.Text & "','" & Integer.Parse(Label29.Text) & "','" & TextBox4.Text & "','" & (Val(Label29.Text * Val(TextBox4.Text))) & "')"
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
values('" & Label25.Text & "','" & Integer.Parse(Label24.Text) & "','" & TextBox5.Text & "','" & (Val(Label24.Text * Val(TextBox5.Text))) & "')"
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
values('" & Label20.Text & "','" & Integer.Parse(Label19.Text) & "','" & TextBox6.Text & "','" & (Val(Label19.Text * Val(TextBox6.Text))) & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub
End Class