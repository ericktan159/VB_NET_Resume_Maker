<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreateJSON = New System.Windows.Forms.Button()
        Me.jsonFolderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreatePDF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUploadJSON = New System.Windows.Forms.Button()
        Me.jsonFileSelect = New System.Windows.Forms.OpenFileDialog()
        Me.chckBx_AddDeatails = New System.Windows.Forms.CheckBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.txtBxMiddleName = New System.Windows.Forms.TextBox()
        Me.txtBxSummary = New System.Windows.Forms.TextBox()
        Me.labelSummary = New System.Windows.Forms.Label()
        Me.lableEmail = New System.Windows.Forms.Label()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.labelMiddleName = New System.Windows.Forms.Label()
        Me.txtBxEmail = New System.Windows.Forms.TextBox()
        Me.txtBxCellNumber = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.btn_Edit_Educ = New System.Windows.Forms.Button()
        Me.lstVw_EducatuonalBackGorund = New System.Windows.Forms.ListView()
        Me.btn_Remove_Educ = New System.Windows.Forms.Button()
        Me.btn_add_Educ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCreateJSON
        '
        Me.btnCreateJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateJSON.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreateJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateJSON.Location = New System.Drawing.Point(932, 383)
        Me.btnCreateJSON.Name = "btnCreateJSON"
        Me.btnCreateJSON.Size = New System.Drawing.Size(157, 23)
        Me.btnCreateJSON.TabIndex = 131
        Me.btnCreateJSON.Text = "Create JSON"
        Me.btnCreateJSON.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(23, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(91, 23)
        Me.btnClear.TabIndex = 132
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCreatePDF
        '
        Me.btnCreatePDF.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreatePDF.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreatePDF.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreatePDF.Location = New System.Drawing.Point(1131, 383)
        Me.btnCreatePDF.Name = "btnCreatePDF"
        Me.btnCreatePDF.Size = New System.Drawing.Size(157, 23)
        Me.btnCreatePDF.TabIndex = 130
        Me.btnCreatePDF.Text = "Create PDF"
        Me.btnCreatePDF.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(259, 1233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 127
        '
        'btnUploadJSON
        '
        Me.btnUploadJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUploadJSON.BackColor = System.Drawing.SystemColors.Control
        Me.btnUploadJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUploadJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUploadJSON.Location = New System.Drawing.Point(765, 383)
        Me.btnUploadJSON.Name = "btnUploadJSON"
        Me.btnUploadJSON.Size = New System.Drawing.Size(130, 23)
        Me.btnUploadJSON.TabIndex = 126
        Me.btnUploadJSON.Text = "Upload JSON"
        Me.btnUploadJSON.UseVisualStyleBackColor = False
        '
        'chckBx_AddDeatails
        '
        Me.chckBx_AddDeatails.AutoSize = True
        Me.chckBx_AddDeatails.Location = New System.Drawing.Point(23, 337)
        Me.chckBx_AddDeatails.Name = "chckBx_AddDeatails"
        Me.chckBx_AddDeatails.Size = New System.Drawing.Size(86, 19)
        Me.chckBx_AddDeatails.TabIndex = 134
        Me.chckBx_AddDeatails.Text = "Add Details"
        Me.chckBx_AddDeatails.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(700, 258)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(546, 84)
        Me.RichTextBox1.TabIndex = 150
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Educational Background"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Name:"
        '
        'txtBxLastName
        '
        Me.txtBxLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxLastName.Location = New System.Drawing.Point(454, 32)
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(229, 24)
        Me.txtBxLastName.TabIndex = 156
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelLastName.Location = New System.Drawing.Point(479, 59)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(89, 17)
        Me.labelLastName.TabIndex = 165
        Me.labelLastName.Text = "Last Name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxMiddleName.Location = New System.Drawing.Point(308, 32)
        Me.txtBxMiddleName.Name = "txtBxMiddleName"
        Me.txtBxMiddleName.Size = New System.Drawing.Size(139, 24)
        Me.txtBxMiddleName.TabIndex = 155
        '
        'txtBxSummary
        '
        Me.txtBxSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxSummary.Location = New System.Drawing.Point(12, 196)
        Me.txtBxSummary.Multiline = True
        Me.txtBxSummary.Name = "txtBxSummary"
        Me.txtBxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBxSummary.Size = New System.Drawing.Size(671, 134)
        Me.txtBxSummary.TabIndex = 163
        '
        'labelSummary
        '
        Me.labelSummary.AutoSize = True
        Me.labelSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSummary.Location = New System.Drawing.Point(12, 176)
        Me.labelSummary.Name = "labelSummary"
        Me.labelSummary.Size = New System.Drawing.Size(170, 17)
        Me.labelSummary.TabIndex = 162
        Me.labelSummary.Text = "Objective/Summary:"
        '
        'lableEmail
        '
        Me.lableEmail.AutoSize = True
        Me.lableEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lableEmail.Location = New System.Drawing.Point(351, 122)
        Me.lableEmail.Name = "lableEmail"
        Me.lableEmail.Size = New System.Drawing.Size(134, 17)
        Me.lableEmail.TabIndex = 160
        Me.lableEmail.Text = "Email Address:"
        '
        'labelNumber
        '
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNumber.Location = New System.Drawing.Point(12, 116)
        Me.labelNumber.Name = "labelNumber"
        Me.labelNumber.Size = New System.Drawing.Size(143, 17)
        Me.labelNumber.TabIndex = 158
        Me.labelNumber.Text = "Contact Number:"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxAddress.Location = New System.Drawing.Point(98, 89)
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(585, 24)
        Me.txtBxAddress.TabIndex = 157
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxFirstName.Location = New System.Drawing.Point(71, 32)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(230, 24)
        Me.txtBxFirstName.TabIndex = 153
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelFirstName.Location = New System.Drawing.Point(123, 59)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(98, 17)
        Me.labelFirstName.TabIndex = 152
        Me.labelFirstName.Text = "First Name"
        '
        'labelMiddleName
        '
        Me.labelMiddleName.AutoSize = True
        Me.labelMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelMiddleName.Location = New System.Drawing.Point(332, 59)
        Me.labelMiddleName.Name = "labelMiddleName"
        Me.labelMiddleName.Size = New System.Drawing.Size(107, 17)
        Me.labelMiddleName.TabIndex = 164
        Me.labelMiddleName.Text = "Middle Name"
        '
        'txtBxEmail
        '
        Me.txtBxEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxEmail.Location = New System.Drawing.Point(491, 116)
        Me.txtBxEmail.Name = "txtBxEmail"
        Me.txtBxEmail.Size = New System.Drawing.Size(192, 24)
        Me.txtBxEmail.TabIndex = 161
        '
        'txtBxCellNumber
        '
        Me.txtBxCellNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxCellNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxCellNumber.Location = New System.Drawing.Point(161, 119)
        Me.txtBxCellNumber.Name = "txtBxCellNumber"
        Me.txtBxCellNumber.Size = New System.Drawing.Size(183, 24)
        Me.txtBxCellNumber.TabIndex = 159
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddress.Location = New System.Drawing.Point(12, 92)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(80, 17)
        Me.labelAddress.TabIndex = 154
        Me.labelAddress.Text = "Address:"
        '
        'btn_Edit_Educ
        '
        Me.btn_Edit_Educ.Location = New System.Drawing.Point(1252, 86)
        Me.btn_Edit_Educ.Name = "btn_Edit_Educ"
        Me.btn_Edit_Educ.Size = New System.Drawing.Size(75, 23)
        Me.btn_Edit_Educ.TabIndex = 167
        Me.btn_Edit_Educ.Text = "edit"
        Me.btn_Edit_Educ.UseVisualStyleBackColor = True
        '
        'lstVw_EducatuonalBackGorund
        '
        Me.lstVw_EducatuonalBackGorund.GridLines = True
        Me.lstVw_EducatuonalBackGorund.HideSelection = False
        Me.lstVw_EducatuonalBackGorund.Location = New System.Drawing.Point(700, 59)
        Me.lstVw_EducatuonalBackGorund.Name = "lstVw_EducatuonalBackGorund"
        Me.lstVw_EducatuonalBackGorund.Size = New System.Drawing.Size(546, 97)
        Me.lstVw_EducatuonalBackGorund.TabIndex = 168
        Me.lstVw_EducatuonalBackGorund.UseCompatibleStateImageBehavior = False
        Me.lstVw_EducatuonalBackGorund.View = System.Windows.Forms.View.Details
        '
        'btn_Remove_Educ
        '
        Me.btn_Remove_Educ.Location = New System.Drawing.Point(1252, 115)
        Me.btn_Remove_Educ.Name = "btn_Remove_Educ"
        Me.btn_Remove_Educ.Size = New System.Drawing.Size(75, 23)
        Me.btn_Remove_Educ.TabIndex = 169
        Me.btn_Remove_Educ.Text = "Remove"
        Me.btn_Remove_Educ.UseVisualStyleBackColor = True
        '
        'btn_add_Educ
        '
        Me.btn_add_Educ.Location = New System.Drawing.Point(1252, 59)
        Me.btn_add_Educ.Name = "btn_add_Educ"
        Me.btn_add_Educ.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_Educ.TabIndex = 170
        Me.btn_add_Educ.Text = "add"
        Me.btn_add_Educ.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 445)
        Me.Controls.Add(Me.btn_add_Educ)
        Me.Controls.Add(Me.btn_Remove_Educ)
        Me.Controls.Add(Me.lstVw_EducatuonalBackGorund)
        Me.Controls.Add(Me.btn_Edit_Educ)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBxLastName)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.txtBxMiddleName)
        Me.Controls.Add(Me.txtBxSummary)
        Me.Controls.Add(Me.labelSummary)
        Me.Controls.Add(Me.lableEmail)
        Me.Controls.Add(Me.labelNumber)
        Me.Controls.Add(Me.txtBxAddress)
        Me.Controls.Add(Me.txtBxFirstName)
        Me.Controls.Add(Me.labelFirstName)
        Me.Controls.Add(Me.labelMiddleName)
        Me.Controls.Add(Me.txtBxEmail)
        Me.Controls.Add(Me.txtBxCellNumber)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.chckBx_AddDeatails)
        Me.Controls.Add(Me.btnCreateJSON)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreatePDF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUploadJSON)
        Me.Name = "Form1"
        Me.Text = "PDF and JSON Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateJSON As Button
    Friend WithEvents jsonFolderSelect As FolderBrowserDialog
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCreatePDF As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonUploadJSON As Button
    Friend WithEvents jsonFileSelect As OpenFileDialog
    Friend WithEvents btnUploadJSON As Button
    Friend WithEvents chckBx_AddDeatails As CheckBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents labelLastName As Label
    Friend WithEvents txtBxMiddleName As TextBox
    Friend WithEvents txtBxSummary As TextBox
    Friend WithEvents labelSummary As Label
    Friend WithEvents lableEmail As Label
    Friend WithEvents labelNumber As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents labelFirstName As Label
    Friend WithEvents labelMiddleName As Label
    Friend WithEvents txtBxEmail As TextBox
    Friend WithEvents txtBxCellNumber As TextBox
    Friend WithEvents labelAddress As Label
    Friend WithEvents btn_Edit_Educ As Button
    Friend WithEvents lstVw_EducatuonalBackGorund As ListView
    Friend WithEvents btn_Remove_Educ As Button
    Friend WithEvents btn_add_Educ As Button
End Class
