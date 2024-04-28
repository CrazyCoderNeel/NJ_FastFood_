<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billing
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(billing))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Panel1 = New Panel()
        Panel2 = New Panel()
        DataGridView1 = New DataGridView()
        Panel3 = New Panel()
        Label7 = New Label()
        PictureBox2 = New PictureBox()
        Panel4 = New Panel()
        Button3 = New Button()
        TextBox7 = New TextBox()
        Label12 = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label11 = New Label()
        Button2 = New Button()
        TextBox6 = New TextBox()
        Label10 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        PictureBox3 = New PictureBox()
        ToolTip1 = New ToolTip(components)
        Doc = New Printing.PrintDocument()
        PPD = New PrintPreviewDialog()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(381, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 36)
        Label1.TabIndex = 1
        Label1.Text = "INVOICE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(22, 57)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 24)
        Label2.TabIndex = 2
        Label2.Text = "INVOICE TO "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(49, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 22)
        Label3.TabIndex = 3
        Label3.Text = "Name :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(49, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(148, 22)
        Label4.TabIndex = 4
        Label4.Text = "Mobile Number :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(449, 90)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 22)
        Label5.TabIndex = 5
        Label5.Text = "Invoice Number :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(449, 127)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 22)
        Label6.TabIndex = 6
        Label6.Text = "Date :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(222, 89)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(155, 23)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(222, 126)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(155, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(626, 92)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(155, 23)
        TextBox3.TabIndex = 9
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(626, 127)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(155, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(160, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(736, 3)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel2.Controls.Add(DataGridView1)
        Panel2.Location = New Point(12, 185)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(551, 331)
        Panel2.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(10, 44)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(529, 273)
        DataGridView1.TabIndex = 13
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(-3, 525)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(914, 74)
        Panel3.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(395, -2)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 19)
        Label7.TabIndex = 16
        Label7.Text = "www.nxtcapitaldelight.org"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PictureBox2.Location = New Point(569, 185)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(325, 331)
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button3)
        Panel4.Controls.Add(TextBox7)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(RadioButton2)
        Panel4.Controls.Add(RadioButton1)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Button2)
        Panel4.Controls.Add(TextBox6)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(TextBox5)
        Panel4.Controls.Add(TextBox4)
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(Button1)
        Panel4.Location = New Point(583, 197)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(301, 305)
        Panel4.TabIndex = 16
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(13, 5)
        Button3.Name = "Button3"
        Button3.RightToLeft = RightToLeft.No
        Button3.Size = New Size(128, 36)
        Button3.TabIndex = 31
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(146, 135)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 23)
        TextBox7.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Transparent
        Label12.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(20, 135)
        Label12.Name = "Label12"
        Label12.Size = New Size(92, 22)
        Label12.TabIndex = 29
        Label12.Text = "Discount :"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton2.Location = New Point(185, 194)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(71, 23)
        RadioButton2.TabIndex = 27
        RadioButton2.TabStop = True
        RadioButton2.Text = "Online"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RadioButton1.Location = New Point(185, 166)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(61, 23)
        RadioButton1.TabIndex = 26
        RadioButton1.TabStop = True
        RadioButton1.Text = "Cash"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(20, 166)
        Label11.Name = "Label11"
        Label11.Size = New Size(159, 22)
        Label11.TabIndex = 25
        Label11.Text = "Payment Method :"
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(185, 240)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 55)
        Button2.TabIndex = 24
        Button2.Text = "PRINT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(146, 106)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 23)
        TextBox6.TabIndex = 23
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(20, 107)
        Label10.Name = "Label10"
        Label10.Size = New Size(120, 22)
        Label10.TabIndex = 22
        Label10.Text = "Grand Total :"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(122, 76)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(149, 23)
        TextBox5.TabIndex = 21
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(122, 47)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(149, 23)
        TextBox4.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(20, 78)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 22)
        Label9.TabIndex = 19
        Label9.Text = "GST :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(20, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(84, 22)
        Label8.TabIndex = 18
        Label8.Text = "TOTAL :"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(154, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 36)
        Button1.TabIndex = 0
        Button1.Text = "REMOVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Location = New Point(11, 168)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(883, 3)
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' Doc
        ' 
        ' 
        ' PPD
        ' 
        PPD.AutoScrollMargin = New Size(0, 0)
        PPD.AutoScrollMinSize = New Size(0, 0)
        PPD.ClientSize = New Size(400, 300)
        PPD.Enabled = True
        PPD.Icon = CType(resources.GetObject("PPD.Icon"), Icon)
        PPD.Name = "PrintPreviewDialog1"
        PPD.Visible = False
        ' 
        ' billing
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(910, 541)
        Controls.Add(PictureBox3)
        Controls.Add(Panel4)
        Controls.Add(PictureBox2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "billing"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Doc As Printing.PrintDocument
    Friend WithEvents PPD As PrintPreviewDialog
End Class
