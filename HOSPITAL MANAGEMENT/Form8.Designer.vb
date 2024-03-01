<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        ListView1 = New ListView()
        WardName = New ColumnHeader()
        Capacity = New ColumnHeader()
        Gender = New ColumnHeader()
        Ailment = New ColumnHeader()
        PatientID = New ColumnHeader()
        Btnexit = New Button()
        BtnEnter = New Button()
        Label1 = New Label()
        txtpatienid = New TextBox()
        txtailment = New TextBox()
        txtcapacity = New TextBox()
        txtwardname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        rdmale = New RadioButton()
        rdfemale = New RadioButton()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {WardName, Capacity, Gender, Ailment, PatientID})
        ListView1.Location = New Point(732, 79)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(461, 444)
        ListView1.TabIndex = 23
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.Location = New Point(432, 513)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(112, 53)
        Btnexit.TabIndex = 22
        Btnexit.Text = "EXIT"
        Btnexit.UseVisualStyleBackColor = False
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnEnter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.Location = New Point(246, 513)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(112, 53)
        BtnEnter.TabIndex = 21
        BtnEnter.Text = "ENTER"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(384, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(313, 65)
        Label1.TabIndex = 20
        Label1.Text = "WARD AREA"
        ' 
        ' txtpatienid
        ' 
        txtpatienid.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatienid.Location = New Point(436, 426)
        txtpatienid.Name = "txtpatienid"
        txtpatienid.Size = New Size(278, 39)
        txtpatienid.TabIndex = 57
        ' 
        ' txtailment
        ' 
        txtailment.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtailment.Location = New Point(436, 357)
        txtailment.Name = "txtailment"
        txtailment.Size = New Size(278, 39)
        txtailment.TabIndex = 56
        ' 
        ' txtcapacity
        ' 
        txtcapacity.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtcapacity.Location = New Point(436, 212)
        txtcapacity.Name = "txtcapacity"
        txtcapacity.Size = New Size(278, 39)
        txtcapacity.TabIndex = 54
        ' 
        ' txtwardname
        ' 
        txtwardname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtwardname.Location = New Point(436, 141)
        txtwardname.Name = "txtwardname"
        txtwardname.Size = New Size(278, 39)
        txtwardname.TabIndex = 53
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(156, 433)
        Label6.Name = "Label6"
        Label6.Size = New Size(120, 32)
        Label6.TabIndex = 52
        Label6.Text = "PatientID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(156, 364)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 32)
        Label5.TabIndex = 51
        Label5.Text = "Ailment"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(156, 291)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 32)
        Label4.TabIndex = 50
        Label4.Text = "Gender"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(156, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 32)
        Label3.TabIndex = 49
        Label3.Text = "Capacity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(156, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 32)
        Label2.TabIndex = 48
        Label2.Text = "Ward Name"
        ' 
        ' rdmale
        ' 
        rdmale.AutoSize = True
        rdmale.Location = New Point(440, 293)
        rdmale.Name = "rdmale"
        rdmale.Size = New Size(95, 36)
        rdmale.TabIndex = 58
        rdmale.TabStop = True
        rdmale.Text = "Male"
        rdmale.UseVisualStyleBackColor = True
        ' 
        ' rdfemale
        ' 
        rdfemale.AutoSize = True
        rdfemale.Location = New Point(572, 291)
        rdfemale.Name = "rdfemale"
        rdfemale.Size = New Size(119, 36)
        rdfemale.TabIndex = 59
        rdfemale.TabStop = True
        rdfemale.Text = "Female"
        rdfemale.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1446, 858)
        Controls.Add(rdfemale)
        Controls.Add(rdmale)
        Controls.Add(txtpatienid)
        Controls.Add(txtailment)
        Controls.Add(txtcapacity)
        Controls.Add(txtwardname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(Btnexit)
        Controls.Add(BtnEnter)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form8"
        Text = "Wards"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Btnexit As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpatienid As TextBox
    Friend WithEvents txtailment As TextBox
    Friend WithEvents txtcapacity As TextBox
    Friend WithEvents txtwardname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rdmale As RadioButton
    Friend WithEvents rdfemale As RadioButton
    Friend WithEvents WardName As ColumnHeader
    Friend WithEvents Capacity As ColumnHeader
    Friend WithEvents Gender As ColumnHeader
    Friend WithEvents Ailment As ColumnHeader
    Friend WithEvents PatientID As ColumnHeader
End Class
