<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Btnexit = New Button()
        BtnEnter = New Button()
        ListView1 = New ListView()
        txtdoctorsname = New TextBox()
        txtappointmentno = New TextBox()
        txtpatientsnumber = New TextBox()
        txtappointmentref = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        AppintmentRef = New ColumnHeader()
        PatientsNumber = New ColumnHeader()
        AppointmentNo = New ColumnHeader()
        DctorsName = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Cursor = Cursors.IBeam
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(351, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(466, 54)
        Label1.TabIndex = 0
        Label1.Text = "APPOINTMENTS PAGE"
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.Location = New Point(361, 555)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(112, 53)
        Btnexit.TabIndex = 18
        Btnexit.Text = "EXIT"
        Btnexit.UseVisualStyleBackColor = False
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnEnter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.Location = New Point(175, 555)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(112, 53)
        BtnEnter.TabIndex = 17
        BtnEnter.Text = "ENTER"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.AllowColumnReorder = True
        ListView1.Columns.AddRange(New ColumnHeader() {AppintmentRef, PatientsNumber, AppointmentNo, DctorsName})
        ListView1.Location = New Point(792, 126)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(435, 482)
        ListView1.TabIndex = 19
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' txtdoctorsname
        ' 
        txtdoctorsname.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtdoctorsname.Location = New Point(384, 345)
        txtdoctorsname.Name = "txtdoctorsname"
        txtdoctorsname.Size = New Size(250, 37)
        txtdoctorsname.TabIndex = 27
        ' 
        ' txtappointmentno
        ' 
        txtappointmentno.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtappointmentno.Location = New Point(384, 282)
        txtappointmentno.Name = "txtappointmentno"
        txtappointmentno.Size = New Size(250, 37)
        txtappointmentno.TabIndex = 26
        ' 
        ' txtpatientsnumber
        ' 
        txtpatientsnumber.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatientsnumber.Location = New Point(384, 212)
        txtpatientsnumber.Name = "txtpatientsnumber"
        txtpatientsnumber.Size = New Size(250, 37)
        txtpatientsnumber.TabIndex = 25
        ' 
        ' txtappointmentref
        ' 
        txtappointmentref.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtappointmentref.Location = New Point(384, 145)
        txtappointmentref.Name = "txtappointmentref"
        txtappointmentref.Size = New Size(250, 37)
        txtappointmentref.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(158, 362)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 32)
        Label5.TabIndex = 23
        Label5.Text = "Doctors Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(158, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 32)
        Label4.TabIndex = 22
        Label4.Text = "AppointmentNO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(158, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(208, 32)
        Label3.TabIndex = 21
        Label3.Text = "Patients Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(158, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 32)
        Label2.TabIndex = 20
        Label2.Text = "Appointmant Ref"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(13F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        ClientSize = New Size(1239, 802)
        Controls.Add(txtdoctorsname)
        Controls.Add(txtappointmentno)
        Controls.Add(txtpatientsnumber)
        Controls.Add(txtappointmentref)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(Btnexit)
        Controls.Add(BtnEnter)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form4"
        Text = "Appointments"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btnexit As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtdoctorsname As TextBox
    Friend WithEvents txtappointmentno As TextBox
    Friend WithEvents txtpatientsnumber As TextBox
    Friend WithEvents txtappointmentref As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AppintmentRef As ColumnHeader
    Friend WithEvents PatientsNumber As ColumnHeader
    Friend WithEvents AppointmentNo As ColumnHeader
    Friend WithEvents DctorsName As ColumnHeader
End Class
