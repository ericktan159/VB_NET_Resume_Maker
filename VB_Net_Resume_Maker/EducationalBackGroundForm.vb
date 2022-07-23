
Public Class EducationalBackGroundForm
    Dim lstVw_EducatuonalBackGorund_Local As ListView
    Private Sub EducationalBackGroundForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstVw_EducatuonalBackGorund_Local = Form1.lstVw_EducatuonalBackGorund

    End Sub
    Private Sub btn_Add_EducationalBackGround_Click(sender As Object, e As EventArgs) Handles btn_Add_EducationalBackGround.Click

        event_btn_Add_EducationalBackGround_Click()
        event_closeForm()
    End Sub

    Private Sub event_btn_Add_EducationalBackGround_Click()


        Dim row_EducationaBackGround_Dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_School_Name, txtBx_SchoolName.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started, txtBx_YearStarted.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended, txtBx_YearEnded.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Remarks, txtBx_Remarks.Text)


        Form1.info_EducationaBackGround_LisOfDictionary.Add(row_EducationaBackGround_Dictionary)

        displayTable_EducationaBackGround()
    End Sub

    Private Sub add_New_row_ListView_Educ(row_EducationaBackGround_Dictionary As Dictionary(Of String, String))
        Dim new_ListViewItem As New ListViewItem(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_School_Name))
        new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started))
        new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended))
        new_ListViewItem.SubItems.Add(row_EducationaBackGround_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Remarks))

        Form1.lstVw_EducatuonalBackGorund.Items.Add(new_ListViewItem)
    End Sub

    Public Sub displayTable_EducationaBackGround()
        Form1.lstVw_EducatuonalBackGorund.Items.Clear()
        For Each row_EducationaBackGround_Dictionary As Dictionary(Of String, String) In Form1.info_EducationaBackGround_LisOfDictionary
            add_New_row_ListView_Educ(row_EducationaBackGround_Dictionary)
        Next

    End Sub

    Public Function show_Table_Data() As String
        Dim contentStr As String = ""
        Dim columnStr As String = ""
        columnStr += $"{MyDictionary_EducationalBackGround.Key_Names.key_School_Name} {vbTab} " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Year_Started} {vbTab} " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended} {vbTab} " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Remarks} {vbNewLine}"
        For Each row_Dictionary As Dictionary(Of String, String) In Form1.info_EducationaBackGround_LisOfDictionary

            contentStr += $"{row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_School_Name)} {vbTab} " +
            $"{row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started)} {vbTab} " +
            $"{row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended)} {vbTab} " +
            $"{row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Remarks)} {vbNewLine}"

        Next
        Return columnStr + vbNewLine + contentStr
        'MessageBox.Show(temStr)
    End Function
    Public Function view_Row_Data() As String
        Dim contentStr As String = ""
        If Form1.info_EducationaBackGround_LisOfDictionary.Count > 0 Then
            Dim row_Dictionary As Dictionary(Of String, String) = Form1.info_EducationaBackGround_LisOfDictionary(Form1.info_EducationaBackGround_LisOfDictionary.Count - 1)

            contentStr += $" {MyDictionary_EducationalBackGround.Key_Names.key_School_Name}: {row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_School_Name)} {vbNewLine} " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Year_Started}: {row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started)} {vbNewLine } " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended}: {row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended)} {vbNewLine} " +
            $"{MyDictionary_EducationalBackGround.Key_Names.key_Remarks}: {row_Dictionary(MyDictionary_EducationalBackGround.Key_Names.key_Remarks)} {vbNewLine}"

        End If
        Return contentStr
        'MessageBox.Show(temStr)
    End Function


    Private Sub btn_Update_EducationalBackGround_Click(sender As Object, e As EventArgs) Handles btn_Update_EducationalBackGround.Click

    End Sub

    Private Sub btn_Remove_EducationalBackGround_Click(sender As Object, e As EventArgs) Handles btn_Remove_EducationalBackGround.Click

    End Sub

    Private Sub btn_Cancel_EducationalBackGround_Click(sender As Object, e As EventArgs) Handles btn_Cancel_EducationalBackGround.Click

    End Sub


    Private Sub event_closeForm()
        Me.Close()
    End Sub

End Class

Module Educ
    Public Class MyDictionary_EducationalBackGround
        Public Class Key_Names

            Public Const key_School_Name As String = "School Name"
            Public Const key_Year_Started As String = "Year Started"
            Public Const key_Year_Ended As String = "Year Ended"
            Public Const key_Remarks As String = "Remarks"

        End Class
    End Class

End Module