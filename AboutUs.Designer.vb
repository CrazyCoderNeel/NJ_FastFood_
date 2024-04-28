<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutUs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutUs))
        Label7 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.BurlyWood
        Label7.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Red
        Label7.Location = New Point(61, 125)
        Label7.Name = "Label7"
        Label7.Size = New Size(743, 25)
        Label7.TabIndex = 6
        Label7.Text = "Welcome to our vibrant fast food haven,where flavours take the spot"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.BurlyWood
        Label1.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(61, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(710, 25)
        Label1.TabIndex = 7
        Label1.Text = "At our restaurant , we pride ourselves on delivering a delightful "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.BurlyWood
        Label3.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(61, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(273, 25)
        Label3.TabIndex = 9
        Label3.Text = " tantalize your taste bud"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.BurlyWood
        Label4.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Red
        Label4.Location = New Point(61, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(632, 25)
        Label4.TabIndex = 10
        Label4.Text = "our menu is a symphony of tastes and textures designed to"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.BurlyWood
        Label5.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(61, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(715, 25)
        Label5.TabIndex = 11
        Label5.Text = "From sizzingling burgers to crispy fries and refereshing beverages"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.BurlyWood
        Label8.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Red
        Label8.Location = New Point(61, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(573, 25)
        Label8.TabIndex = 13
        Label8.Text = "culinary experience that marries speed with quality."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SaddleBrown
        Label2.Font = New Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Snow
        Label2.Location = New Point(351, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 25)
        Label2.TabIndex = 15
        Label2.Text = "About Us"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(250, 300)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(345, 304)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' AboutUs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(945, 702)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "AboutUs"
        Text = "AboutUs"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
