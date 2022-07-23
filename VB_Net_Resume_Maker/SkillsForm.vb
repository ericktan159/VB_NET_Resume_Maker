

Public Class SkillsForm

    Dim lstVw_Skills_Local As ListView


    Private Sub SkillsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstVw_Skills_Local = Form1.lstVw_Skills
    End Sub

    Private Sub btn_Add_Input_Skills_Click(sender As Object, e As EventArgs) Handles btn_Add_Input_Skills.Click
        event_btn_Add_Input_Skills_Click()
    End Sub



    Private Sub event_btn_Add_Input_Skills_Click()

        If IsInputsComplete() Then
            Dim new_Skills_Str As String = ""

            new_Skills_Str = txtBx_Input_Skills.Text

            Form1.info_Skills_ListOfString.Add(new_Skills_Str)
            displayTable_SkillsTable()
            event_closeForm()
        Else

            Form1.display_Warning_Ok("incomplete input", "Incomplete input")
            displayTable_SkillsTable()
        End If


    End Sub

    Private Sub add_New_row_ListView_Skill(row_Skill_Str As String)
        Dim new_ListViewItem As New ListViewItem(row_Skill_Str)

        Form1.lstVw_Skills.Items.Add(new_ListViewItem)
    End Sub

    Public Sub displayTable_SkillsTable()
        Form1.lstVw_Skills.Items.Clear()
        For Each row_Skill_Str As String In Form1.info_Skills_ListOfString
            add_New_row_ListView_Skill(row_Skill_Str)
        Next

    End Sub

    Public Function show_Table_Data() As String
        Dim contentStr As String = ""
        For Each row_Skill_Str As String In Form1.info_Skills_ListOfString
            contentStr += row_Skill_Str + vbNewLine
        Next
        Return "Skills" + vbNewLine + contentStr
        'MessageBox.Show(temStr)
    End Function


    Public Function IsInputsComplete() As Boolean
        Dim listOfIncompleteFields As New List(Of String)
        Dim isSucces As Boolean = True

        If txtBx_Input_Skills.Text.Trim() = "" Then
            listOfIncompleteFields.Add("Skill")
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
    Public Function view_Row_Data() As String
        Dim contentStr As String = ""
        If Form1.info_Skills_ListOfString.Count > 0 Then
            contentStr = Form1.info_Skills_ListOfString(Form1.info_Skills_ListOfString.Count - 1)
        End If
        Return contentStr
        'MessageBox.Show(temStr)
    End Function



    Private Sub btn_Cancel_Input_Skills_Click(sender As Object, e As EventArgs) Handles btn_Cancel_Input_Skills.Click
        event_btn_Cancel_Input_Skills_Click()
    End Sub

    Private Sub event_btn_Cancel_Input_Skills_Click()
        event_closeForm()
    End Sub

    Private Sub event_closeForm()
        'MessageBox.Show("Nag close")
        Me.Close()
    End Sub

End Class