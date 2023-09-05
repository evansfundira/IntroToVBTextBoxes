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
        GreetMe = New Button()
        txtFirstName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtSurname = New TextBox()
        txtGender = New TextBox()
        SuspendLayout()
        ' 
        ' GreetMe
        ' 
        GreetMe.Location = New Point(194, 257)
        GreetMe.Name = "GreetMe"
        GreetMe.Size = New Size(225, 90)
        GreetMe.TabIndex = 0
        GreetMe.Text = "Greet Me!"
        GreetMe.UseVisualStyleBackColor = True
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(263, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(125, 27)
        txtFirstName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(182, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(194, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 3
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 162)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 20)
        Label3.TabIndex = 4
        Label3.Text = "Gender"
        ' 
        ' txtSurname
        ' 
        txtSurname.Location = New Point(272, 109)
        txtSurname.Name = "txtSurname"
        txtSurname.Size = New Size(125, 27)
        txtSurname.TabIndex = 5
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(294, 159)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(125, 27)
        txtGender.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtGender)
        Controls.Add(txtSurname)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtFirstName)
        Controls.Add(GreetMe)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GreetMe As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtGender As TextBox
End Class
