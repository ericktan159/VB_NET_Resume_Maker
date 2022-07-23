
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
        add_New_row_ListView_Educ()

        Dim row_EducationaBackGround_Dictionary As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_School_Name, txtBx_SchoolName.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Year_Started, txtBx_YearStarted.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Year_Ended, txtBx_YearEnded.Text)
        row_EducationaBackGround_Dictionary.Add(MyDictionary_EducationalBackGround.Key_Names.key_Remarks, txtBx_Remarks.Text)

        Form1.info_EducationaBackGround_LisOfDictionary.Add(row_EducationaBackGround_Dictionary)

    End Sub

    Private Sub add_New_row_ListView_Educ()
        Dim new_ListViewItem As New ListViewItem(txtBx_SchoolName.Text)
        new_ListViewItem.SubItems.Add(txtBx_YearStarted.Text)
        new_ListViewItem.SubItems.Add(txtBx_YearEnded.Text)
        new_ListViewItem.SubItems.Add(txtBx_Remarks.Text)

        Form1.lstVw_EducatuonalBackGorund.Items.Add(new_ListViewItem)
    End Sub

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