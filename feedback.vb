Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Public Class feedback
    Dim query As String = "SELECT * FROM feedback WHERE CustID=@CustID"
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
    Private bitmap As Bitmap
    Private Sub updateTable()
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        sqlconn.Open()
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "Select * from myconnector1.feedback"

        sqlrd = sqlcmd.ExecuteReader
        sqldt.Load(sqlrd)
        sqlrd.Close()
        sqlconn.Close()
    End Sub
    Private Sub feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Very Satisfied")
        ComboBox1.Items.Add("Satisfied")
        ComboBox1.Items.Add("Neutral")
        ComboBox1.Items.Add("Dissatisfied")
        ComboBox1.Items.Add("Very Dissatisfied")

        ComboBox2.Items.Add("Excellent")
        ComboBox2.Items.Add("Good")
        ComboBox2.Items.Add("Average")
        ComboBox2.Items.Add("Poor")
        ComboBox2.Items.Add("Very Poor")

        ComboBox3.Items.Add("Excellent")
        ComboBox3.Items.Add("Good")
        ComboBox3.Items.Add("Average")
        ComboBox3.Items.Add("Poor")
        ComboBox3.Items.Add("Very Poor")
        updateTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlconn.ConnectionString = "server=" + server + ";" + "user id =" + uname + ";" + "password=" + pass + ";" + "database=" + dbname
        Try
            sqlconn.Open()
            sqlquery = "Insert into myconnector1.feedback(FullName,PhoneNumber,Address,EmailID,Date,CustID,ProductSatisfaction,ServiceRating,ProductRating,MostAppreciatedAspect,ImprovementAreas,AdditionalSuggestions)
values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "','" & TextBox8.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "')"
            sqlcmd = New MySqlCommand(sqlquery, sqlconn)
            sqlrd = sqlcmd.ExecuteReader
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlconn.Close()
        End Try
        updateTable()
        MsgBox("Response Submitted Successfully , we'll surely try to improve more next time Thank You !")
        dashboard.Show()
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim name As New Regex("^[a-zA-Z\s]+$")
        If name.IsMatch(TextBox1.Text) Then
            ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(TextBox1, "Please Enter a valid name !")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim phno As New Regex("^\d{10}")
        If phno.IsMatch(TextBox2.Text) Then
            ErrorProvider2.Clear()
        Else
            ErrorProvider2.SetError(TextBox2, "Please Enter a valid phone number !")
        End If
    End Sub
End Class