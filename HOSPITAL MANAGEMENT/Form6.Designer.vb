<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Btnexit = New Button()
        BtnEnter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtpatientid = New TextBox()
        txtnameoftablet = New TextBox()
        txtadministration = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(783, 87)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(409, 521)
        ListView1.TabIndex = 23
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.Location = New Point(397, 497)
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
        BtnEnter.Location = New Point(211, 497)
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
        Label1.Location = New Point(349, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 65)
        Label1.TabIndex = 20
        Label1.Text = "PHARMACY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(126, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 32)
        Label2.TabIndex = 24
        Label2.Text = "PatientID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(126, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 32)
        Label3.TabIndex = 25
        Label3.Text = "Name of Tablet"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(126, 292)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 32)
        Label4.TabIndex = 26
        Label4.Text = "Administration"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(126, 365)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 32)
        Label5.TabIndex = 27
        Label5.Text = "Date Issued"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(126, 434)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 32)
        Label6.TabIndex = 28
        Label6.Text = "Exp Date"
        ' 
        ' txtpatientid
        ' 
        txtpatientid.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatientid.Location = New Point(406, 142)
        txtpatientid.Name = "txtpatientid"
        txtpatientid.Size = New Size(278, 39)
        txtpatientid.TabIndex = 29
        ' 
        ' txtnameoftablet
        ' 
        txtnameoftablet.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtnameoftablet.Location = New Point(406, 213)
        txtnameoftablet.Name = "txtnameoftablet"
        txtnameoftablet.Size = New Size(278, 39)
        txtnameoftablet.TabIndex = 30
        ' 
        ' txtadministration
        ' 
        txtadministration.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtadministration.Location = New Point(406, 289)
        txtadministration.Name = "txtadministration"
        txtadministration.Size = New Size(278, 39)
        txtadministration.TabIndex = 31
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(406, 356)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(278, 39)
        DateTimePicker1.TabIndex = 32
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(406, 427)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(278, 39)
        DateTimePicker2.TabIndex = 33
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(1265, 772)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtadministration)
        Controls.Add(txtnameoftablet)
        Controls.Add(txtpatientid)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ListView1)
        Controls.Add(Btnexit)
        Controls.Add(BtnEnter)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "Form6"
        Text = "Pharmacy"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Btnexit As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpatientid As TextBox
    Friend WithEvents txtnameoftablet As TextBox
    Friend WithEvents txtadministration As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
