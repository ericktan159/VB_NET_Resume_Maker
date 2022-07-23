<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationalBackGroundForm
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
        Me.txtBx_SchoolName = New System.Windows.Forms.TextBox()
        Me.txtBx_YearStarted = New System.Windows.Forms.TextBox()
        Me.txtBx_YearEnded = New System.Windows.Forms.TextBox()
        Me.txtBx_Remarks = New System.Windows.Forms.TextBox()
        Me.btn_Add_EducationalBackGround = New System.Windows.Forms.Button()
        Me.btn_Remove_EducationalBackGround = New System.Windows.Forms.Button()
        Me.btn_Update_EducationalBackGround = New System.Windows.Forms.Button()
        Me.btn_Cancel_EducationalBackGround = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBx_SchoolName
        '
        Me.txtBx_SchoolName.Location = New System.Drawing.Point(23, 87)
        Me.txtBx_SchoolName.Name = "txtBx_SchoolName"
        Me.txtBx_SchoolName.Size = New System.Drawing.Size(206, 23)
        Me.txtBx_SchoolName.TabIndex = 0
        '
        'txtBx_YearStarted
        '
        Me.txtBx_YearStarted.Location = New System.Drawing.Point(246, 87)
        Me.txtBx_YearStarted.Name = "txtBx_YearStarted"
        Me.txtBx_YearStarted.Size = New System.Drawing.Size(100, 23)
        Me.txtBx_YearStarted.TabIndex = 1
        '
        'txtBx_YearEnded
        '
        Me.txtBx_YearEnded.Location = New System.Drawing.Point(352, 87)
        Me.txtBx_YearEnded.Name = "txtBx_YearEnded"
        Me.txtBx_YearEnded.Size = New System.Drawing.Size(100, 23)
        Me.txtBx_YearEnded.TabIndex = 2
        '
        'txtBx_Remarks
        '
        Me.txtBx_Remarks.Location = New System.Drawing.Point(458, 87)
        Me.txtBx_Remarks.Name = "txtBx_Remarks"
        Me.txtBx_Remarks.Size = New System.Drawing.Size(193, 23)
        Me.txtBx_Remarks.TabIndex = 3
        '
        'btn_Add_EducationalBackGround
        '
        Me.btn_Add_EducationalBackGround.Location = New System.Drawing.Point(576, 143)
        Me.btn_Add_EducationalBackGround.Name = "btn_Add_EducationalBackGround"
        Me.btn_Add_EducationalBackGround.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add_EducationalBackGround.TabIndex = 4
        Me.btn_Add_EducationalBackGround.Text = "Add"
        Me.btn_Add_EducationalBackGround.UseVisualStyleBackColor = True
        '
        'btn_Remove_EducationalBackGround
        '
        Me.btn_Remove_EducationalBackGround.Enabled = False
        Me.btn_Remove_EducationalBackGround.Location = New System.Drawing.Point(407, 143)
        Me.btn_Remove_EducationalBackGround.Name = "btn_Remove_EducationalBackGround"
        Me.btn_Remove_EducationalBackGround.Size = New System.Drawing.Size(75, 23)
        Me.btn_Remove_EducationalBackGround.TabIndex = 5
        Me.btn_Remove_EducationalBackGround.Text = "Remove"
        Me.btn_Remove_EducationalBackGround.UseVisualStyleBackColor = True
        Me.btn_Remove_EducationalBackGround.Visible = False
        '
        'btn_Update_EducationalBackGround
        '
        Me.btn_Update_EducationalBackGround.Enabled = False
        Me.btn_Update_EducationalBackGround.Location = New System.Drawing.Point(488, 143)
        Me.btn_Update_EducationalBackGround.Name = "btn_Update_EducationalBackGround"
        Me.btn_Update_EducationalBackGround.Size = New System.Drawing.Size(75, 23)
        Me.btn_Update_EducationalBackGround.TabIndex = 6
        Me.btn_Update_EducationalBackGround.Text = "Update"
        Me.btn_Update_EducationalBackGround.UseVisualStyleBackColor = True
        Me.btn_Update_EducationalBackGround.Visible = False
        '
        'btn_Cancel_EducationalBackGround
        '
        Me.btn_Cancel_EducationalBackGround.Location = New System.Drawing.Point(23, 143)
        Me.btn_Cancel_EducationalBackGround.Name = "btn_Cancel_EducationalBackGround"
        Me.btn_Cancel_EducationalBackGround.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel_EducationalBackGround.TabIndex = 7
        Me.btn_Cancel_EducationalBackGround.Text = "Cancel"
        Me.btn_Cancel_EducationalBackGround.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "School Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Year Started"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Year Ended"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(488, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Remarks"
        '
        'EducationalBackGroundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 203)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel_EducationalBackGround)
        Me.Controls.Add(Me.btn_Update_EducationalBackGround)
        Me.Controls.Add(Me.btn_Remove_EducationalBackGround)
        Me.Controls.Add(Me.btn_Add_EducationalBackGround)
        Me.Controls.Add(Me.txtBx_Remarks)
        Me.Controls.Add(Me.txtBx_YearEnded)
        Me.Controls.Add(Me.txtBx_YearStarted)
        Me.Controls.Add(Me.txtBx_SchoolName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EducationalBackGroundForm"
        Me.Text = "EducationalBackGroundForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBx_SchoolName As TextBox
    Friend WithEvents txtBx_YearStarted As TextBox
    Friend WithEvents txtBx_YearEnded As TextBox
    Friend WithEvents txtBx_Remarks As TextBox
    Friend WithEvents btn_Add_EducationalBackGround As Button
    Friend WithEvents btn_Remove_EducationalBackGround As Button
    Friend WithEvents btn_Update_EducationalBackGround As Button
    Friend WithEvents btn_Cancel_EducationalBackGround As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
