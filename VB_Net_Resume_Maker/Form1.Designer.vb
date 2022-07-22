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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCreatePDF = New System.Windows.Forms.Button()
        Me.txtBxLastName = New System.Windows.Forms.TextBox()
        Me.labelLastName = New System.Windows.Forms.Label()
        Me.txtBxMiddleName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUploadJSON = New System.Windows.Forms.Button()
        Me.txtBxSummary = New System.Windows.Forms.TextBox()
        Me.labelSummary = New System.Windows.Forms.Label()
        Me.lableEmail = New System.Windows.Forms.Label()
        Me.labelNumber = New System.Windows.Forms.Label()
        Me.txtBxAddress = New System.Windows.Forms.TextBox()
        Me.txtBxFirstName = New System.Windows.Forms.TextBox()
        Me.labelFirstName = New System.Windows.Forms.Label()
        Me.jsonFileSelect = New System.Windows.Forms.OpenFileDialog()
        Me.labelMiddleName = New System.Windows.Forms.Label()
        Me.txtBxEmail = New System.Windows.Forms.TextBox()
        Me.txtBxCellNumber = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreateJSON
        '
        Me.btnCreateJSON.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateJSON.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreateJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCreateJSON.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateJSON.Location = New System.Drawing.Point(339, 340)
        Me.btnCreateJSON.Name = "btnCreateJSON"
        Me.btnCreateJSON.Size = New System.Drawing.Size(157, 23)
        Me.btnCreateJSON.TabIndex = 131
        Me.btnCreateJSON.Text = "Create JSON"
        Me.btnCreateJSON.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(23, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Name:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(23, 340)
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
        Me.btnCreatePDF.Location = New System.Drawing.Point(538, 340)
        Me.btnCreatePDF.Name = "btnCreatePDF"
        Me.btnCreatePDF.Size = New System.Drawing.Size(157, 23)
        Me.btnCreatePDF.TabIndex = 130
        Me.btnCreatePDF.Text = "Create PDF"
        Me.btnCreatePDF.UseVisualStyleBackColor = False
        '
        'txtBxLastName
        '
        Me.txtBxLastName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxLastName.Location = New System.Drawing.Point(465, 23)
        Me.txtBxLastName.Name = "txtBxLastName"
        Me.txtBxLastName.Size = New System.Drawing.Size(230, 24)
        Me.txtBxLastName.TabIndex = 118
        '
        'labelLastName
        '
        Me.labelLastName.AutoSize = True
        Me.labelLastName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelLastName.Location = New System.Drawing.Point(490, 50)
        Me.labelLastName.Name = "labelLastName"
        Me.labelLastName.Size = New System.Drawing.Size(89, 17)
        Me.labelLastName.TabIndex = 129
        Me.labelLastName.Text = "Last Name"
        '
        'txtBxMiddleName
        '
        Me.txtBxMiddleName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxMiddleName.Location = New System.Drawing.Point(319, 23)
        Me.txtBxMiddleName.Name = "txtBxMiddleName"
        Me.txtBxMiddleName.Size = New System.Drawing.Size(140, 24)
        Me.txtBxMiddleName.TabIndex = 117
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
        Me.btnUploadJSON.Location = New System.Drawing.Point(172, 340)
        Me.btnUploadJSON.Name = "btnUploadJSON"
        Me.btnUploadJSON.Size = New System.Drawing.Size(130, 23)
        Me.btnUploadJSON.TabIndex = 126
        Me.btnUploadJSON.Text = "Upload JSON"
        Me.btnUploadJSON.UseVisualStyleBackColor = False
        '
        'txtBxSummary
        '
        Me.txtBxSummary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxSummary.Location = New System.Drawing.Point(23, 187)
        Me.txtBxSummary.Multiline = True
        Me.txtBxSummary.Name = "txtBxSummary"
        Me.txtBxSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBxSummary.Size = New System.Drawing.Size(672, 134)
        Me.txtBxSummary.TabIndex = 125
        '
        'labelSummary
        '
        Me.labelSummary.AutoSize = True
        Me.labelSummary.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSummary.Location = New System.Drawing.Point(23, 167)
        Me.labelSummary.Name = "labelSummary"
        Me.labelSummary.Size = New System.Drawing.Size(170, 17)
        Me.labelSummary.TabIndex = 124
        Me.labelSummary.Text = "Objective/Summary:"
        '
        'lableEmail
        '
        Me.lableEmail.AutoSize = True
        Me.lableEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lableEmail.Location = New System.Drawing.Point(362, 113)
        Me.lableEmail.Name = "lableEmail"
        Me.lableEmail.Size = New System.Drawing.Size(134, 17)
        Me.lableEmail.TabIndex = 122
        Me.lableEmail.Text = "Email Address:"
        '
        'labelNumber
        '
        Me.labelNumber.AutoSize = True
        Me.labelNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNumber.Location = New System.Drawing.Point(23, 107)
        Me.labelNumber.Name = "labelNumber"
        Me.labelNumber.Size = New System.Drawing.Size(143, 17)
        Me.labelNumber.TabIndex = 120
        Me.labelNumber.Text = "Contact Number:"
        '
        'txtBxAddress
        '
        Me.txtBxAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxAddress.Location = New System.Drawing.Point(109, 80)
        Me.txtBxAddress.Name = "txtBxAddress"
        Me.txtBxAddress.Size = New System.Drawing.Size(586, 24)
        Me.txtBxAddress.TabIndex = 119
        '
        'txtBxFirstName
        '
        Me.txtBxFirstName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxFirstName.Location = New System.Drawing.Point(82, 23)
        Me.txtBxFirstName.Name = "txtBxFirstName"
        Me.txtBxFirstName.Size = New System.Drawing.Size(231, 24)
        Me.txtBxFirstName.TabIndex = 115
        '
        'labelFirstName
        '
        Me.labelFirstName.AutoSize = True
        Me.labelFirstName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelFirstName.Location = New System.Drawing.Point(134, 50)
        Me.labelFirstName.Name = "labelFirstName"
        Me.labelFirstName.Size = New System.Drawing.Size(98, 17)
        Me.labelFirstName.TabIndex = 114
        Me.labelFirstName.Text = "First Name"
        '
        'labelMiddleName
        '
        Me.labelMiddleName.AutoSize = True
        Me.labelMiddleName.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelMiddleName.Location = New System.Drawing.Point(343, 50)
        Me.labelMiddleName.Name = "labelMiddleName"
        Me.labelMiddleName.Size = New System.Drawing.Size(107, 17)
        Me.labelMiddleName.TabIndex = 128
        Me.labelMiddleName.Text = "Middle Name"
        '
        'txtBxEmail
        '
        Me.txtBxEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxEmail.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxEmail.Location = New System.Drawing.Point(502, 107)
        Me.txtBxEmail.Name = "txtBxEmail"
        Me.txtBxEmail.Size = New System.Drawing.Size(193, 24)
        Me.txtBxEmail.TabIndex = 123
        '
        'txtBxCellNumber
        '
        Me.txtBxCellNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBxCellNumber.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBxCellNumber.Location = New System.Drawing.Point(172, 110)
        Me.txtBxCellNumber.Name = "txtBxCellNumber"
        Me.txtBxCellNumber.Size = New System.Drawing.Size(184, 24)
        Me.txtBxCellNumber.TabIndex = 121
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAddress.Location = New System.Drawing.Point(23, 83)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(80, 17)
        Me.labelAddress.TabIndex = 116
        Me.labelAddress.Text = "Address:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 400)
        Me.Controls.Add(Me.btnCreateJSON)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCreatePDF)
        Me.Controls.Add(Me.txtBxLastName)
        Me.Controls.Add(Me.labelLastName)
        Me.Controls.Add(Me.txtBxMiddleName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUploadJSON)
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
        Me.Name = "Form1"
        Me.Text = "PDF and JSON Maker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreateJSON As Button
    Friend WithEvents jsonFolderSelect As FolderBrowserDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCreatePDF As Button
    Friend WithEvents txtBxLastName As TextBox
    Friend WithEvents labelLastName As Label
    Friend WithEvents txtBxMiddleName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonUploadJSON As Button
    Friend WithEvents txtBxSummary As TextBox
    Friend WithEvents labelSummary As Label
    Friend WithEvents lableEmail As Label
    Friend WithEvents labelNumber As Label
    Friend WithEvents txtBxAddress As TextBox
    Friend WithEvents txtBxFirstName As TextBox
    Friend WithEvents labelFirstName As Label
    Friend WithEvents jsonFileSelect As OpenFileDialog
    Friend WithEvents labelMiddleName As Label
    Friend WithEvents txtBxEmail As TextBox
    Friend WithEvents txtBxCellNumber As TextBox
    Friend WithEvents labelAddress As Label
    Friend WithEvents btnUploadJSON As Button
End Class
