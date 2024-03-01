<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtname = New TextBox()
        txtphoneno = New TextBox()
        txtemail = New TextBox()
        txtemployeeno = New TextBox()
        cbrole = New ComboBox()
        Label7 = New Label()
        ListView1 = New ListView()
        rbmale = New RadioButton()
        rbfemale = New RadioButton()
        BtnEnter = New Button()
        Btnexit = New Button()
        Name = New ColumnHeader()
        PhoneNo = New ColumnHeader()
        Email = New ColumnHeader()
        EmployeeNo = New ColumnHeader()
        Role = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(254, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 48)
        Label1.TabIndex = 0
        Label1.Text = "DOCTORS' PAGE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(133, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 32)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(133, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 32)
        Label3.TabIndex = 2
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(133, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 32)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(133, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(175, 32)
        Label5.TabIndex = 4
        Label5.Text = "Employee No."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(133, 393)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 32)
        Label6.TabIndex = 5
        Label6.Text = "Role"
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtname.Location = New Point(359, 116)
        txtname.Name = "txtname"
        txtname.Size = New Size(250, 37)
        txtname.TabIndex = 6
        ' 
        ' txtphoneno
        ' 
        txtphoneno.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtphoneno.Location = New Point(359, 183)
        txtphoneno.Name = "txtphoneno"
        txtphoneno.Size = New Size(250, 37)
        txtphoneno.TabIndex = 7
        ' 
        ' txtemail
        ' 
        txtemail.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtemail.Location = New Point(359, 253)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(250, 37)
        txtemail.TabIndex = 8
        ' 
        ' txtemployeeno
        ' 
        txtemployeeno.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtemployeeno.Location = New Point(359, 316)
        txtemployeeno.Name = "txtemployeeno"
        txtemployeeno.Size = New Size(250, 37)
        txtemployeeno.TabIndex = 9
        ' 
        ' cbrole
        ' 
        cbrole.AllowDrop = True
        cbrole.FormattingEnabled = True
        cbrole.Items.AddRange(New Object() {"Nurse", "Doctor", "Radiotherapist", "Surgeon", "Phlebotomist"})
        cbrole.Location = New Point(364, 399)
        cbrole.Name = "cbrole"
        cbrole.Size = New Size(245, 33)
        cbrole.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(133, 485)
        Label7.Name = "Label7"
        Label7.Size = New Size(98, 32)
        Label7.TabIndex = 11
        Label7.Text = "Gender"
        ' 
        ' ListView1
        ' 
        ListView1.AllowColumnReorder = True
        ListView1.Columns.AddRange(New ColumnHeader() {Name, PhoneNo, Email, EmployeeNo, Role})
        ListView1.LabelEdit = True
        ListView1.Location = New Point(715, 91)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(345, 444)
        ListView1.TabIndex = 12
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' rbmale
        ' 
        rbmale.AutoSize = True
        rbmale.Cursor = Cursors.Hand
        rbmale.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbmale.Location = New Point(365, 492)
        rbmale.Name = "rbmale"
        rbmale.Size = New Size(89, 34)
        rbmale.TabIndex = 13
        rbmale.TabStop = True
        rbmale.Text = "Male"
        rbmale.UseVisualStyleBackColor = True
        ' 
        ' rbfemale
        ' 
        rbfemale.AutoSize = True
        rbfemale.Cursor = Cursors.Hand
        rbfemale.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rbfemale.Location = New Point(498, 492)
        rbfemale.Name = "rbfemale"
        rbfemale.Size = New Size(111, 34)
        rbfemale.TabIndex = 14
        rbfemale.TabStop = True
        rbfemale.Text = "Female"
        rbfemale.UseVisualStyleBackColor = True
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnEnter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.Location = New Point(156, 560)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(112, 53)
        BtnEnter.TabIndex = 15
        BtnEnter.Text = "ENTER"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.Location = New Point(342, 560)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(112, 53)
        Btnexit.TabIndex = 16
        Btnexit.Text = "EXIT"
        Btnexit.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(1109, 692)
        Controls.Add(Btnexit)
        Controls.Add(BtnEnter)
        Controls.Add(rbfemale)
        Controls.Add(rbmale)
        Controls.Add(ListView1)
        Controls.Add(Label7)
        Controls.Add(cbrole)
        Controls.Add(txtemployeeno)
        Controls.Add(txtemail)
        Controls.Add(txtphoneno)
        Controls.Add(txtname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Doctor Details"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtphoneno As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtemployeeno As TextBox
    Friend WithEvents cbrole As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Btnexit As Button
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents PhoneNo As ColumnHeader
    Friend WithEvents Email As ColumnHeader
    Friend WithEvents EmployeeNo As ColumnHeader
    Friend WithEvents Role As ColumnHeader
End Class
