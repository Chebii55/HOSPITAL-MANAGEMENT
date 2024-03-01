<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        txtbalance = New TextBox()
        txtamount = New TextBox()
        txtpayment = New TextBox()
        txtphoneno = New TextBox()
        txtpatientname = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ListView1 = New ListView()
        Btnexit = New Button()
        BtnEnter = New Button()
        Label1 = New Label()
        PatientName = New ColumnHeader()
        PhoneNo = New ColumnHeader()
        ModeofPayment = New ColumnHeader()
        AmountPaid = New ColumnHeader()
        Balance = New ColumnHeader()
        SuspendLayout()
        ' 
        ' txtbalance
        ' 
        txtbalance.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtbalance.Location = New Point(444, 440)
        txtbalance.Name = "txtbalance"
        txtbalance.Size = New Size(278, 39)
        txtbalance.TabIndex = 47
        ' 
        ' txtamount
        ' 
        txtamount.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtamount.Location = New Point(444, 371)
        txtamount.Name = "txtamount"
        txtamount.Size = New Size(278, 39)
        txtamount.TabIndex = 46
        ' 
        ' txtpayment
        ' 
        txtpayment.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpayment.Location = New Point(444, 302)
        txtpayment.Name = "txtpayment"
        txtpayment.Size = New Size(278, 39)
        txtpayment.TabIndex = 45
        ' 
        ' txtphoneno
        ' 
        txtphoneno.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtphoneno.Location = New Point(444, 226)
        txtphoneno.Name = "txtphoneno"
        txtphoneno.Size = New Size(278, 39)
        txtphoneno.TabIndex = 44
        ' 
        ' txtpatientname
        ' 
        txtpatientname.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtpatientname.Location = New Point(444, 155)
        txtpatientname.Name = "txtpatientname"
        txtpatientname.Size = New Size(278, 39)
        txtpatientname.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(164, 447)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 32)
        Label6.TabIndex = 42
        Label6.Text = "Balance"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(164, 378)
        Label5.Name = "Label5"
        Label5.Size = New Size(163, 32)
        Label5.TabIndex = 41
        Label5.Text = "Amount Paid"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(164, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(220, 32)
        Label4.TabIndex = 40
        Label4.Text = "Mode Of Payment"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(164, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 32)
        Label3.TabIndex = 39
        Label3.Text = "Phone No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(164, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 32)
        Label2.TabIndex = 38
        Label2.Text = "Patient Name"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {PatientName, PhoneNo, ModeofPayment, AmountPaid, Balance})
        ListView1.Location = New Point(821, 100)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(409, 521)
        ListView1.TabIndex = 37
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Btnexit
        ' 
        Btnexit.BackColor = Color.Red
        Btnexit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btnexit.Location = New Point(435, 510)
        Btnexit.Name = "Btnexit"
        Btnexit.Size = New Size(112, 53)
        Btnexit.TabIndex = 36
        Btnexit.Text = "EXIT"
        Btnexit.UseVisualStyleBackColor = False
        ' 
        ' BtnEnter
        ' 
        BtnEnter.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        BtnEnter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnEnter.Location = New Point(249, 510)
        BtnEnter.Name = "BtnEnter"
        BtnEnter.Size = New Size(112, 53)
        BtnEnter.TabIndex = 35
        BtnEnter.Text = "ENTER"
        BtnEnter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(387, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(278, 65)
        Label1.TabIndex = 34
        Label1.Text = "PAYMENTS"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CornflowerBlue
        ClientSize = New Size(1639, 803)
        Controls.Add(txtbalance)
        Controls.Add(txtamount)
        Controls.Add(txtpayment)
        Controls.Add(txtphoneno)
        Controls.Add(txtpatientname)
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
        Name = "Form7"
        Text = "Payments"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbalance As TextBox
    Friend WithEvents txtamount As TextBox
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents txtphoneno As TextBox
    Friend WithEvents txtpatientname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Btnexit As Button
    Friend WithEvents BtnEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientName As ColumnHeader
    Friend WithEvents PhoneNo As ColumnHeader
    Friend WithEvents ModeofPayment As ColumnHeader
    Friend WithEvents AmountPaid As ColumnHeader
    Friend WithEvents Balance As ColumnHeader
End Class
