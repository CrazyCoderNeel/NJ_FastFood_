<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(faq))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Timer1 = New Timer(components)
        TextBox1 = New TextBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Button3 = New Button()
        Button4 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, -1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(929, 550)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(27, 30)
        Button1.Name = "Button1"
        Button1.Size = New Size(871, 31)
        Button1.TabIndex = 1
        Button1.Text = "Q: What are your available menu options?"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(901, 23)
        TextBox1.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PictureBox2.Location = New Point(12, 21)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(901, 77)
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PictureBox3.Location = New Point(12, 104)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(901, 77)
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(27, 113)
        Button2.Name = "Button2"
        Button2.Size = New Size(871, 31)
        Button2.TabIndex = 5
        Button2.Text = "Q : Can I customize my order to suit my dietary preferences?"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(12, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(901, 23)
        TextBox2.TabIndex = 6
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PictureBox4.Location = New Point(12, 187)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(901, 77)
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        PictureBox5.Location = New Point(12, 270)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(901, 77)
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(27, 196)
        Button3.Name = "Button3"
        Button3.Size = New Size(871, 31)
        Button3.TabIndex = 9
        Button3.Text = "Q: Do you offer any vegetarian or vegan options?"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(27, 279)
        Button4.Name = "Button4"
        Button4.Size = New Size(871, 31)
        Button4.TabIndex = 10
        Button4.Text = "Q : What measures do you take to ensure food safety and hygiene?"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(12, 233)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(901, 23)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(12, 316)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(901, 23)
        TextBox4.TabIndex = 12
        ' 
        ' faq
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(925, 546)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "faq"
        Text = "faq"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
