<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkillsForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Cancel_Input_Skills = New System.Windows.Forms.Button()
        Me.btn_Add_Input_Skills = New System.Windows.Forms.Button()
        Me.txtBx_Input_Skills = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Skills"
        '
        'btn_Cancel_Input_Skills
        '
        Me.btn_Cancel_Input_Skills.Location = New System.Drawing.Point(26, 88)
        Me.btn_Cancel_Input_Skills.Name = "btn_Cancel_Input_Skills"
        Me.btn_Cancel_Input_Skills.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cancel_Input_Skills.TabIndex = 19
        Me.btn_Cancel_Input_Skills.Text = "Cancel"
        Me.btn_Cancel_Input_Skills.UseVisualStyleBackColor = True
        '
        'btn_Add_Input_Skills
        '
        Me.btn_Add_Input_Skills.Location = New System.Drawing.Point(157, 88)
        Me.btn_Add_Input_Skills.Name = "btn_Add_Input_Skills"
        Me.btn_Add_Input_Skills.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add_Input_Skills.TabIndex = 16
        Me.btn_Add_Input_Skills.Text = "Add"
        Me.btn_Add_Input_Skills.UseVisualStyleBackColor = True
        '
        'txtBx_Input_Skills
        '
        Me.txtBx_Input_Skills.Location = New System.Drawing.Point(26, 59)
        Me.txtBx_Input_Skills.Name = "txtBx_Input_Skills"
        Me.txtBx_Input_Skills.Size = New System.Drawing.Size(206, 23)
        Me.txtBx_Input_Skills.TabIndex = 12
        '
        'SkillsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 157)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel_Input_Skills)
        Me.Controls.Add(Me.btn_Add_Input_Skills)
        Me.Controls.Add(Me.txtBx_Input_Skills)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SkillsForm"
        Me.Text = "SkillsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Cancel_Input_Skills As Button
    Friend WithEvents btn_Add_Input_Skills As Button
    Friend WithEvents txtBx_Input_Skills As TextBox
End Class
