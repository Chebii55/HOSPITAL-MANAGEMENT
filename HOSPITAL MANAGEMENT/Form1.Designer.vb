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
        Panel1 = New Panel()
        Btnexit = New Button()
        Btnlogin = New Button()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Teal
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Btnexit)
        Panel1.Controls.Add(Btnlogin)
        Panel1.Controls.Add(txtpassword)
        Panel1.Controls.Add(txtusername)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(91, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(462, 318)
        Panel1.TabIndex = 0
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.ForeColor = SystemColors.ButtonHighlight
        Btnexit.Location = New Point(214, 208)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(112, 53)
        Btnexit.TabIndex = 5
        Btnexit.Text = "Exit"
        Btnexit.UseVisualStyleBackColor = False
        ' 
        ' Btnlogin
        ' 
        Btnlogin.BackColor = Color.Blue
        Btnlogin.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnlogin.ForeColor = SystemColors.ButtonHighlight
        Btnlogin.Location = New Point(55, 208)
        Btnlogin.Name = "Btnlogin"
        Btnlogin.Size = New Size(112, 53)
        Btnlogin.TabIndex = 4
        Btnlogin.Text = "Log In"
        Btnlogin.UseVisualStyleBackColor = False
        ' 
        ' txtpassword
        ' 
        txtpassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpassword.Location = New Point(173, 125)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(225, 39)
        txtpassword.TabIndex = 3
        txtpassword.UseSystemPasswordChar = True
        ' 
        ' txtusername
        ' 
        txtusername.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtusername.Location = New Point(173, 37)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(225, 39)
        txtusername.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 32)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 32)
        Label1.TabIndex = 0
        Label1.Text = "User Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Teal
        Label3.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(91, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(530, 45)
        Label3.TabIndex = 1
        Label3.Text = "HOSPITAL MANAGMENT SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btnexit As Button
    Friend WithEvents Btnlogin As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label3 As Label

End Class
