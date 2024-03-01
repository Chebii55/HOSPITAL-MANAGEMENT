<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnexit = New Button()
        BtnEnter = New Button()
        ListView1 = New ListView()
        txtappointmentno = New TextBox()
        txtpatientid = New TextBox()
        txtward = New TextBox()
        txtidno = New TextBox()
        txtpatientname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Name = New ColumnHeader()
        IDNo = New ColumnHeader()
        Ward = New ColumnHeader()
        PatientId = New ColumnHeader()
        AppointmentNo = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(292, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(386, 65)
        Label1.TabIndex = 0
        Label1.Text = "PATIENTS AREA"
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Red
        btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.Location = New Point(340, 495)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(112, 53)
        btnexit.TabIndex = 18
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnEnter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.Location = New Point(154, 495)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(112, 53)
        BtnEnter.TabIndex = 17
        BtnEnter.Text = "ENTER"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {Name, IDNo, Ward, PatientId, AppointmentNo})
        ListView1.Location = New Point(684, 86)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(409, 444)
        ListView1.TabIndex = 19
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' txtappointmentno
        ' 
        txtappointmentno.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtappointmentno.Location = New Point(383, 403)
        txtappointmentno.Name = "txtappointmentno"
        txtappointmentno.Size = New Size(278, 39)
        txtappointmentno.TabIndex = 43
        ' 
        ' txtpatientid
        ' 
        txtpatientid.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatientid.Location = New Point(383, 334)
        txtpatientid.Name = "txtpatientid"
        txtpatientid.Size = New Size(278, 39)
        txtpatientid.TabIndex = 42
        ' 
        ' txtward
        ' 
        txtward.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtward.Location = New Point(383, 265)
        txtward.Name = "txtward"
        txtward.Size = New Size(278, 39)
        txtward.TabIndex = 41
        ' 
        ' txtidno
        ' 
        txtidno.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtidno.Location = New Point(383, 189)
        txtidno.Name = "txtidno"
        txtidno.Size = New Size(278, 39)
        txtidno.TabIndex = 40
        ' 
        ' txtpatientname
        ' 
        txtpatientname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatientname.Location = New Point(383, 118)
        txtpatientname.Name = "txtpatientname"
        txtpatientname.Size = New Size(278, 39)
        txtpatientname.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(103, 410)
        Label6.Name = "Label6"
        Label6.Size = New Size(210, 32)
        Label6.TabIndex = 38
        Label6.Text = "Appointment NO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(103, 341)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 32)
        Label5.TabIndex = 37
        Label5.Text = "Patient ID"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(103, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 32)
        Label4.TabIndex = 36
        Label4.Text = "Ward"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(103, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 32)
        Label3.TabIndex = 35
        Label3.Text = "ID No"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(103, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 32)
        Label2.TabIndex = 34
        Label2.Text = "Name"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1120, 576)
        Controls.Add(txtappointmentno)
        Controls.Add(txtpatientid)
        Controls.Add(txtward)
        Controls.Add(txtidno)
        Controls.Add(txtpatientname)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(btnexit)
        Controls.Add(BtnEnter)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form5"
        Text = "Patients"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnexit As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtappointmentno As TextBox
    Friend WithEvents txtpatientid As TextBox
    Friend WithEvents txtward As TextBox
    Friend WithEvents txtidno As TextBox
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents IDNo As ColumnHeader
    Friend WithEvents Ward As ColumnHeader
    Friend WithEvents PatientId As ColumnHeader
    Friend WithEvents AppointmentNo As ColumnHeader
End Class
