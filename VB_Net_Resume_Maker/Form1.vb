Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Newtonsoft.Json

Public Class Form1

    Dim myJSON As JSON_Module_Class = New JSON_Module_Class()
    Dim myPDF As PDF_Module_CLass = New PDF_Module_CLass()

    Dim inputsFromForm As InputDataForm

    Public info_EducationaBackGround_LisOfDictionary As List(Of Dictionary(Of String, String)) = New List(Of Dictionary(Of String, String))()
    Public info_Skills_ListOfString As List(Of String) = New List(Of String)()



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_ListView_EducationalBackGround()
        init_ListView_Skills()
    End Sub

    Public Sub init_ListView_EducationalBackGround()

        lstVw_EducatuonalBackGorund.Columns.Add("School Name", 200, HorizontalAlignment.Left)
        lstVw_EducatuonalBackGorund.Columns.Add("Year Started", 80, HorizontalAlignment.Left)
        lstVw_EducatuonalBackGorund.Columns.Add("Year Ended", 80, HorizontalAlignment.Left)
        lstVw_EducatuonalBackGorund.Columns.Add("Remarks", 150, HorizontalAlignment.Left)
    End Sub

    Public Sub init_ListView_Skills()

        lstVw_Skills.Columns.Add("Skills", 500, HorizontalAlignment.Left)
    End Sub

    Private Sub CopyInputs()
        inputsFromForm = New InputDataForm()

        inputsFromForm.txtBxFirstName = txtBxFirstName
        inputsFromForm.txtBxMiddleName = txtBxMiddleName
        inputsFromForm.txtBxLastName = txtBxLastName
        inputsFromForm.txtBxAddress = txtBxAddress
        inputsFromForm.txtBxCellNumber = txtBxCellNumber
        inputsFromForm.txtBxEmail = txtBxEmail
        inputsFromForm.txtBxSummary = txtBxSummary

        inputsFromForm.info_EducationaBackGround_LisOfDictionary = info_EducationaBackGround_LisOfDictionary
        inputsFromForm.info_Skills_ListOfString = info_Skills_ListOfString
    End Sub



    Private Sub event_btnUploadJSON()
        jsonFileSelect.Filter = "JSON Files (*.json)|*.json"
        If jsonFileSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            CopyInputs()
            If myJSON.uploadFileJSON(jsonFileSelect.FileName, inputsFromForm) Then
                'print_ListView_EducationalBackGround()
                display_Information_Ok("Succes!!!", "Upload JSON FILE")
            Else
                display_Information_Ok("Failed!!!", "Upload JSON FILE")
            End If
        End If
    End Sub
    Private Sub event_btnCreateJSON()
        If IsInputsComplete() Then
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                CopyInputs()
                If myJSON.createJFileJSON(jsonFolderSelect.SelectedPath, inputsFromForm) Then
                    display_Information_Ok("Succes!!!", "Create JSON FILE")
                Else
                    display_Information_Ok("Failed!!!", "Create JSON FILE")
                End If
                ClearInputs()
            End If
        End If
    End Sub
    Private Sub event_btnCreatePDFResume()
        If IsInputsComplete() Then
            If jsonFolderSelect.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                CopyInputs()
                If display_Question_YesNo("Do you want to save the File in JSON File also?", "Save as JSON") = Windows.Forms.DialogResult.Yes Then
                    'CopyInputs()
                    If myJSON.createJFileJSON(jsonFolderSelect.SelectedPath, inputsFromForm) Then
                        display_Information_Ok("Succes!!!", "Create JSON FILE")
                    Else
                        display_Information_Ok("Failed!!!", "Create JSON FILE")

                    End If
                End If
                'CopyInputs()

                If myPDF.GeneratePDF(jsonFolderSelect.SelectedPath, inputsFromForm) Then
                    display_Information_Ok("Succes!!!", "Create PDF FILE")
                Else
                    display_Information_Ok("Failed!!!", "Create PDF FILE")
                End If

                ClearInputs()
            End If
        End If
    End Sub

    Private Sub event_chckBx_AddDeatails_CheckedChanged()

    End Sub
    Public Function IsInputsComplete() As Boolean
        Dim listOfIncompleteFields As New List(Of String)
        Dim isSucces As Boolean = True

        If txtBxFirstName.Text.Trim() = "" Then
            listOfIncompleteFields.Add("First Name")
            isSucces = False
        End If
        If txtBxMiddleName.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Middle Name")
            isSucces = False
        End If
        If txtBxLastName.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Last Name")
            isSucces = False
        End If
        If txtBxAddress.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Address")
            isSucces = False
        End If
        If txtBxCellNumber.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Cellphone Number")
            isSucces = False
        End If
        If txtBxSummary.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Object/Summary")
            isSucces = False
        End If


        If isSucces Then
            displayWarningInputNotComplete(listOfIncompleteFields, "")
            Return True
        Else
            displayWarningInputNotComplete(listOfIncompleteFields, "Error!")
            Return False
        End If

    End Function

    Public Sub displayWarningInputNotComplete(msgS As List(Of String), caption As String)

        If caption <> "" Then
            Dim strMsg As String = ""
            For Each txt In msgS
                strMsg += txt + vbNewLine
            Next

            MessageBox.Show("Incomplete Fields:" + vbNewLine + strMsg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Public Function display_Warning_Ok(msg As String, caption As String) As DialogResult

        Return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning)

    End Function

    Public Function display_Information_Ok(msg As String, caption As String) As DialogResult

        Return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function

    Public Function display_Question_YesNo(msg As String, caption As String) As DialogResult

        Return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    End Function

    Public Sub ClearInputs()
        txtBxFirstName.Text = ""
        txtBxMiddleName.Text = ""
        txtBxLastName.Text = ""
        txtBxAddress.Text = ""
        txtBxCellNumber.Text = ""
        txtBxEmail.Text = ""
        txtBxSummary.Text = ""

        Me.info_EducationaBackGround_LisOfDictionary.Clear()
        lstVw_EducatuonalBackGorund.Items.Clear()

        Me.info_Skills_ListOfString.Clear()
        lstVw_Skills.Items.Clear()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub

    Private Sub btnUploadJSON_Click(sender As Object, e As EventArgs) Handles btnUploadJSON.Click
        event_btnUploadJSON()
    End Sub

    Private Sub btnCreateJSON_Click(sender As Object, e As EventArgs) Handles btnCreateJSON.Click
        event_btnCreateJSON()
    End Sub

    Private Sub btnCreatePDF_Click(sender As Object, e As EventArgs) Handles btnCreatePDF.Click
        event_btnCreatePDFResume()
    End Sub

    Private Sub txtBxCellNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBxCellNumber.KeyPress


        event_NumbersOnly_KeyPress(e)

    End Sub

    Private Sub event_NumbersOnly_KeyPress(e As KeyPressEventArgs)
        If (Not Char.IsDigit(e.KeyChar) And (Not Char.IsControl(e.KeyChar))) Then
            e.Handled = True

        End If
    End Sub

    Private Sub chckBx_AddDeatails_CheckedChanged(sender As Object, e As EventArgs)
        event_chckBx_AddDeatails_CheckedChanged()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_add_Educ_Click(sender As Object, e As EventArgs) Handles btn_add_Educ.Click
        event_call_add_educ_Dialog()
    End Sub

    Private Sub event_call_add_educ_Dialog()
        Dim educ_Form As EducationalBackGroundForm = New EducationalBackGroundForm()
        educ_Form.ShowDialog()
        MessageBox.Show(EducationalBackGroundForm.show_Table_Data())
    End Sub



    Private Sub lstVw_EducatuonalBackGorund_Click(sender As Object, e As EventArgs) Handles lstVw_EducatuonalBackGorund.Click
        event_LstVw_EducatuonalBackGorund_Click()
    End Sub

    Private Sub event_LstVw_EducatuonalBackGorund_Click()
        Dim educ_Form As EducationalBackGroundForm = New EducationalBackGroundForm()
        If (lstVw_EducatuonalBackGorund.SelectedItems.Count > 0) Then
            educ_Form.txtBx_SchoolName.Text = lstVw_EducatuonalBackGorund.SelectedItems(0).SubItems(0).Text
            educ_Form.txtBx_YearStarted.Text = lstVw_EducatuonalBackGorund.SelectedItems(0).SubItems(1).Text
            educ_Form.txtBx_YearEnded.Text = lstVw_EducatuonalBackGorund.SelectedItems(0).SubItems(2).Text
            educ_Form.txtBx_Remarks.Text = lstVw_EducatuonalBackGorund.SelectedItems(0).SubItems(3).Text

            educ_Form.ShowDialog()
        End If

    End Sub

    Private Sub btn_Remove_Educ_Click(sender As Object, e As EventArgs) Handles btn_Remove_Educ.Click

        event_btn_Remove_Educ_Click()
    End Sub

    Private Sub event_btn_Remove_Educ_Click()
        If info_EducationaBackGround_LisOfDictionary.Count > 0 Then
            If display_Question_YesNo("Do you really want to delete this Row?" + vbNewLine +
                                  EducationalBackGroundForm.view_Row_Data(), "Delete Last Row of Educational BackGround") = DialogResult.Yes Then
                info_EducationaBackGround_LisOfDictionary.RemoveAt(info_EducationaBackGround_LisOfDictionary.Count - 1)
                EducationalBackGroundForm.displayTable_EducationaBackGround()
            End If
        Else
            display_Warning_Ok("Empty Table", "Educational BackGround Table")
        End If



    End Sub

    Public Sub print_ListView_EducationalBackGround(info_EducationaBackGround_LisOfDictionary As List(Of Dictionary(Of String, String)))
        Me.info_EducationaBackGround_LisOfDictionary = info_EducationaBackGround_LisOfDictionary
        lstVw_EducatuonalBackGorund.Items.Clear()
        For Each row_EducationaBackGround_Dictionary As Dictionary(Of String, String) In info_EducationaBackGround_LisOfDictionary
            Dim new_ListViewItem As New ListViewItem(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_School_Name))
            new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started))
            new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended))
            new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Remarks))

            lstVw_EducatuonalBackGorund.Items.Add(new_ListViewItem)
        Next
    End Sub

    Private Sub btn_Add_Skills_Form1_Click(sender As Object, e As EventArgs) Handles btn_Add_Skills_Form1.Click
        event_call_add_Skill()
    End Sub

    Private Sub event_call_add_Skill()
        Dim skill_Form As SkillsForm = New SkillsForm()
        skill_Form.ShowDialog()
        MessageBox.Show(SkillsForm.show_Table_Data())
    End Sub

    Private Sub btn_Remove_Skills_Form1_Click(sender As Object, e As EventArgs) Handles btn_Remove_Skills_Form1.Click
        event_Call_Remove_Skill()
    End Sub

    Private Sub event_Call_Remove_Skill()
        If info_Skills_ListOfString.Count > 0 Then
            If display_Question_YesNo("Do you really want to delete this Row?" + vbNewLine +
                                  SkillsForm.view_Row_Data(), "Delete Last Row of Educational BackGround") = DialogResult.Yes Then
                info_Skills_ListOfString.RemoveAt(info_Skills_ListOfString.Count - 1)
                SkillsForm.displayTable_SkillsTable()
            End If
        Else
            display_Warning_Ok("Empty Table", "Educational BackGround Table")
        End If

    End Sub

    Public Sub print_ListView_Skils(info_Skills_ListOfString As List(Of String))
        Me.info_Skills_ListOfString = info_Skills_ListOfString
        lstVw_Skills.Items.Clear()
        For Each row_Skill_str As String In info_Skills_ListOfString
            Dim new_ListViewItem As New ListViewItem(row_Skill_str)
            lstVw_Skills.Items.Add(new_ListViewItem)
        Next
    End Sub

End Class



Module MyModule


    <Serializable>
    Class UserData
        Public FirstName As String
        Public MiddleName As String
        Public LastName As String
        Public Address As String
        Public ContactNumber As String
        Public EmailAddress As String
        Public Summary As String

        Public info_EducationaBackGround_LisOfDictionary As List(Of Dictionary(Of String, String))
        Public info_Skills_ListOfString As List(Of String)



    End Class

    Public Class InputDataForm

        Public txtBxFirstName As TextBox
        Public txtBxMiddleName As TextBox
        Public txtBxLastName As TextBox
        Public txtBxAddress As TextBox
        Public txtBxCellNumber As TextBox
        Public txtBxEmail As TextBox
        Public txtBxSummary As TextBox

        Public info_EducationaBackGround_LisOfDictionary As List(Of Dictionary(Of String, String))
        Public info_Skills_ListOfString As List(Of String)



        Public Shared Sub convert_USERData_to_InputFORM(ByRef myUserData As UserData, ByRef inputsFromForm As InputDataForm)

            inputsFromForm.txtBxFirstName.Text = myUserData.FirstName
            inputsFromForm.txtBxMiddleName.Text = myUserData.MiddleName
            inputsFromForm.txtBxLastName.Text = myUserData.LastName
            inputsFromForm.txtBxAddress.Text = myUserData.Address
            inputsFromForm.txtBxCellNumber.Text = myUserData.ContactNumber
            inputsFromForm.txtBxEmail.Text = myUserData.EmailAddress
            inputsFromForm.txtBxSummary.Text = myUserData.Summary

            If (myUserData.info_EducationaBackGround_LisOfDictionary IsNot Nothing) Then
                'inputsFromForm.info_EducationaBackGround_LisOfDictionary = myUserData.info_EducationaBackGround_LisOfDictionary
                Form1.print_ListView_EducationalBackGround(myUserData.info_EducationaBackGround_LisOfDictionary)
                'EducationalBackGroundForm.displayTable_EducationaBackGround()
            End If
            If (myUserData.info_Skills_ListOfString IsNot Nothing) Then
                Form1.print_ListView_Skils(myUserData.info_Skills_ListOfString)
            End If


        End Sub

        Public Shared Sub convert_InputFORM_to_USERData(ByRef inputsFromForm As InputDataForm, ByRef myUserData As UserData)

            myUserData.FirstName = inputsFromForm.txtBxFirstName.Text
            myUserData.MiddleName = inputsFromForm.txtBxMiddleName.Text
            myUserData.LastName = inputsFromForm.txtBxLastName.Text
            myUserData.Address = inputsFromForm.txtBxAddress.Text
            myUserData.ContactNumber = inputsFromForm.txtBxCellNumber.Text
            myUserData.EmailAddress = inputsFromForm.txtBxEmail.Text
            myUserData.Summary = inputsFromForm.txtBxSummary.Text
            myUserData.info_EducationaBackGround_LisOfDictionary = inputsFromForm.info_EducationaBackGround_LisOfDictionary
            myUserData.info_Skills_ListOfString = inputsFromForm.info_Skills_ListOfString
        End Sub



    End Class


    Public Class JSON_Module_Class

        Function CreateUserData(ByRef inputsFromForm As InputDataForm) As UserData
            Dim myUserData As UserData = New UserData()
            InputDataForm.convert_InputFORM_to_USERData(inputsFromForm, myUserData)
            Return myUserData
        End Function


        Public Function createJFileJSON(path As String, ByRef inputsFromForm As InputDataForm) As Boolean
            Dim myUserData As UserData = CreateUserData(inputsFromForm)
            Dim jsonContent As String = JsonConvert.SerializeObject(myUserData, Formatting.Indented)
            Dim fileNameStr As String = $"\{myUserData.LastName}, {myUserData.FirstName}.json"

            File.WriteAllText(path + fileNameStr, jsonContent)
            Return True
        End Function


        Public Function uploadFileJSON(path As String, ByRef inputsFromForm As InputDataForm) As Boolean
            Dim jsonContent As String = File.ReadAllText(path)
            Dim myUserData As UserData

            Try
                myUserData = JsonConvert.DeserializeObject(Of UserData)(jsonContent)
            Catch ex As Exception
                MessageBox.Show("Invalid", "Error")
            End Try
            If myUserData IsNot Nothing Then
                InputDataForm.convert_USERData_to_InputFORM(myUserData, inputsFromForm)

                Return True
            Else
                Return False
            End If

        End Function


    End Class

    Public Class PDF_Module_CLass

        Dim myJSON As JSON_Module_Class = New JSON_Module_Class()



        Public Function GeneratePDF(path As String, ByRef inputsFromForm As InputDataForm) As Boolean
            Dim myUserData As UserData = myJSON.CreateUserData(inputsFromForm)
            Dim doc As Document = New Document(PageSize.LETTER, 48, 48, 48, 48)
            Dim fileNameStr As String = $"\{myUserData.LastName}, {myUserData.FirstName}.pdf"
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(path + fileNameStr, FileMode.Create))
            Dim baseFontStyle As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
            Dim fontStyle_Name As New Font(baseFontStyle, 20, Font.BOLD)
            Dim fontStyle_SubHeader As New Font(baseFontStyle, 12, Font.BOLD)
            Dim fontStyle_Body As New Font(baseFontStyle, 11)
            Dim tableHeader As New Font(baseFontStyle, 11, Font.BOLD)


            Dim nameParagraph As Paragraph
            If myUserData.MiddleName.Trim() IsNot "" Then
                nameParagraph = New Paragraph(
                    $"{myUserData.FirstName} {myUserData.MiddleName} {myUserData.LastName}",
                    fontStyle_Name)
            Else
                nameParagraph = New Paragraph(
                    $"{myUserData.FirstName} {myUserData.LastName}",
                    fontStyle_Name)
            End If
            nameParagraph.Alignment = Element.ALIGN_CENTER

            Dim contactParagraph As New Paragraph($"{myUserData.Address}" + vbCrLf +
                                                  $"{myUserData.ContactNumber}" + vbCrLf +
                                                  $"{myUserData.EmailAddress}", fontStyle_Body)
            contactParagraph.Alignment = Element.ALIGN_CENTER




            Dim educTable As New PdfPTable(3)
            If myUserData.info_EducationaBackGround_LisOfDictionary.Count > 0 Then
                educTable.WidthPercentage = 100
                educTable.AddCell(New Paragraph("School", tableHeader))
                educTable.AddCell(New Paragraph("Degree", tableHeader))
                educTable.AddCell(New Paragraph("Year Attended", tableHeader))
                For Each educDict As Dictionary(Of String, String) In myUserData.info_EducationaBackGround_LisOfDictionary
                    educTable.AddCell(New Paragraph(educDict(MyDictionary_EducationalBackGround.Key_Names.key_School_Name), fontStyle_Body))
                    educTable.AddCell(New Paragraph(educDict(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started), fontStyle_Body))
                    educTable.AddCell(New Paragraph(educDict(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended), fontStyle_Body))
                    educTable.AddCell(New Paragraph(educDict(MyDictionary_EducationalBackGround.Key_Names.key_Remarks), fontStyle_Body))
                Next
            End If



            Dim skillTable As PdfPTable = New PdfPTable(3)

            If myUserData.info_Skills_ListOfString.Count > 0 Then
                skillTable.WidthPercentage = 100
                skillTable.DefaultCell.Border = Rectangle.NO_BORDER
                For Each skill As String In myUserData.info_Skills_ListOfString
                    skillTable.AddCell(New Paragraph($"- {skill}", fontStyle_Body))
                Next
            End If

            doc.Open()
            doc.Add(nameParagraph)
            doc.Add(contactParagraph)
            doc.Add(New Paragraph(vbCrLf))
            doc.Add(New draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1))
            doc.Add(New Paragraph("Objectives/Summary:", fontStyle_SubHeader))
            doc.Add(New Paragraph(myUserData.Summary, fontStyle_Body))


            If myUserData.info_EducationaBackGround_LisOfDictionary.Count > 0 Then
                doc.Add(New Paragraph(vbCrLf))
                doc.Add(New Paragraph("Educational Attainment:", fontStyle_SubHeader))
                doc.Add(New Paragraph(vbCrLf))
                doc.Add(educTable)
            End If


            If myUserData.info_Skills_ListOfString.Count > 0 Then
                doc.Add(New Paragraph(vbCrLf))
                doc.Add(New Paragraph("Skills:", fontStyle_SubHeader))
                doc.Add(New Paragraph(vbCrLf))
                doc.Add(skillTable)
            End If

            doc.Close()
            Return True
        End Function

    End Class


End Module
