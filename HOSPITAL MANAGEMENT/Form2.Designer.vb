<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        BtnDoctordetails = New Button()
        BtnAppointments = New Button()
        BtnPatientdetails = New Button()
        BtnPharmacy = New Button()
        BtnPayments = New Button()
        BtnWards = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(230, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 45)
        Label1.TabIndex = 0
        Label1.Text = "WELCOME TO THE HOME PAGE"
        ' 
        ' BtnDoctordetails
        ' 
        BtnDoctordetails.BackColor = Color.LightSeaGreen
        BtnDoctordetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnDoctordetails.Location = New Point(96, 102)
        BtnDoctordetails.Name = "BtnDoctordetails"
        BtnDoctordetails.Size = New Size(243, 60)
        BtnDoctordetails.TabIndex = 1
        BtnDoctordetails.Text = "DOCTORS DETAILS"
        BtnDoctordetails.UseVisualStyleBackColor = False
        ' 
        ' BtnAppointments
        ' 
        BtnAppointments.BackColor = Color.LightSeaGreen
        BtnAppointments.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAppointments.Location = New Point(96, 208)
        BtnAppointments.Name = "BtnAppointments"
        BtnAppointments.Size = New Size(243, 60)
        BtnAppointments.TabIndex = 2
        BtnAppointments.Text = "APPOINTMENTS"
        BtnAppointments.UseVisualStyleBackColor = False
        ' 
        ' BtnPatientdetails
        ' 
        BtnPatientdetails.BackColor = Color.LightSeaGreen
        BtnPatientdetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPatientdetails.Location = New Point(96, 307)
        BtnPatientdetails.Name = "BtnPatientdetails"
        BtnPatientdetails.Size = New Size(243, 60)
        BtnPatientdetails.TabIndex = 3
        BtnPatientdetails.Text = "PATIENTS DETAILS"
        BtnPatientdetails.UseVisualStyleBackColor = False
        ' 
        ' BtnPharmacy
        ' 
        BtnPharmacy.BackColor = Color.LightSeaGreen
        BtnPharmacy.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPharmacy.Location = New Point(441, 102)
        BtnPharmacy.Name = "BtnPharmacy"
        BtnPharmacy.Size = New Size(243, 60)
        BtnPharmacy.TabIndex = 4
        BtnPharmacy.Text = "PHARMACY"
        BtnPharmacy.UseVisualStyleBackColor = False
        ' 
        ' BtnPayments
        ' 
        BtnPayments.BackColor = Color.LightSeaGreen
        BtnPayments.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnPayments.Location = New Point(441, 198)
        BtnPayments.Name = "BtnPayments"
        BtnPayments.Size = New Size(243, 60)
        BtnPayments.TabIndex = 5
        BtnPayments.Text = "PAYMENTS"
        BtnPayments.UseVisualStyleBackColor = False
        ' 
        ' BtnWards
        ' 
        BtnWards.BackColor = Color.LightSeaGreen
        BtnWards.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnWards.Location = New Point(441, 307)
        BtnWards.Name = "BtnWards"
        BtnWards.Size = New Size(243, 60)
        BtnWards.TabIndex = 6
        BtnWards.Text = "WARDS"
        BtnWards.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(920, 580)
        Controls.Add(BtnWards)
        Controls.Add(BtnPayments)
        Controls.Add(BtnPharmacy)
        Controls.Add(BtnPatientdetails)
        Controls.Add(BtnAppointments)
        Controls.Add(BtnDoctordetails)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDoctordetails As Button
    Friend WithEvents BtnAppointments As Button
    Friend WithEvents BtnPatientdetails As Button
    Friend WithEvents BtnPharmacy As Button
    Friend WithEvents BtnPayments As Button
    Friend WithEvents BtnWards As Button
End Class
