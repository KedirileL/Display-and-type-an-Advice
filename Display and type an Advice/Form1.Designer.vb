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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtAdvice1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtAdvice3 = New TextBox()
        txtAdvice2 = New TextBox()
        OpenFileDialog1 = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(343, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(308, 31)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Advice for young People"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.GradientActiveCaption
        Button1.Location = New Point(289, 251)
        Button1.Name = "Button1"
        Button1.Size = New Size(182, 49)
        Button1.TabIndex = 1
        Button1.Text = "Show Message"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 25)
        Label1.TabIndex = 2
        Label1.Text = "Title bar for message ==>"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(110, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(195, 25)
        Label2.TabIndex = 2
        Label2.Text = "Part 1 of message ==>"
        ' 
        ' txtAdvice1
        ' 
        txtAdvice1.Location = New Point(343, 98)
        txtAdvice1.Name = "txtAdvice1"
        txtAdvice1.Size = New Size(308, 31)
        txtAdvice1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(195, 25)
        Label3.TabIndex = 2
        Label3.Text = "Part 3 of message ==>"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(110, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 25)
        Label4.TabIndex = 2
        Label4.Text = "Part 2 of message ==>"
        ' 
        ' txtAdvice3
        ' 
        txtAdvice3.Location = New Point(343, 181)
        txtAdvice3.Name = "txtAdvice3"
        txtAdvice3.Size = New Size(308, 31)
        txtAdvice3.TabIndex = 0
        ' 
        ' txtAdvice2
        ' 
        txtAdvice2.Location = New Point(343, 141)
        txtAdvice2.Name = "txtAdvice2"
        txtAdvice2.Size = New Size(308, 31)
        txtAdvice2.TabIndex = 0
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(txtAdvice2)
        Controls.Add(txtAdvice3)
        Controls.Add(txtAdvice1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdvice1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdvice3 As TextBox
    Friend WithEvents txtAdvice2 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
