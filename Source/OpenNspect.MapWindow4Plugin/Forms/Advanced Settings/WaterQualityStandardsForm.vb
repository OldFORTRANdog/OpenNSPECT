'********************************************************************************************************
'File Name: frmWaterQualityStandard.vb
'Description: Form for displaying Water Quality standards data
'********************************************************************************************************
'The contents of this file are subject to the Mozilla Public License Version 1.1 (the "License"); 
'you may not use this file except in compliance with the License. You may obtain a copy of the License at 
'http://www.mozilla.org/MPL/ 
'Software distributed under the License is distributed on an "AS IS" basis, WITHOUT WARRANTY OF 
'ANY KIND, either express or implied. See the License for the specificlanguage governing rights and 
'limitations under the License. 
'
'Note: This code was converted from the vb6 NSPECT ArcGIS extension and so bears many of the old comments
'in the files where it was possible to leave them.
'
'Contributor(s): (Open source contributors should list themselves and their modifications here). 
'Oct 20, 2010:  Allen Anselmo allen.anselmo@gmail.com - 
'               Added licensing and comments to code
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Friend Class WaterQualityStandardsForm

#Region "Events"

    Private Sub frmWaterQualityStandard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            IsDirty = False
            InitComboBox(cboWQStdName, "WQCRITERIA")
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboWQStdName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboWQStdName.SelectedIndexChanged
        Try
            Dim intYesNo As Short

            If IsDirty Then
                intYesNo = MsgBox("You have made changes to the data.  Would you like to save before coninuing?", MsgBoxStyle.YesNo, "Save Changes?")
                If intYesNo = MsgBoxResult.Yes Then
                    UpdateData()
                    IsDirty = False
                ElseIf intYesNo = MsgBoxResult.No Then
                    IsDirty = False
                End If

            End If

            Dim strSQLWQStd As String
            Dim strSQLWQStdPoll As String

            'Selection based on combo box
            strSQLWQStd = "SELECT * FROM WQCRITERIA WHERE NAME LIKE '" & cboWQStdName.Text & "'"
            Dim WQCritCmd As New OleDbCommand(strSQLWQStd, g_DBConn)
            Dim WQCrit As OleDbDataReader = WQCritCmd.ExecuteReader()

            If WQCrit.HasRows Then
                WQCrit.Read()
                txtWQStdDesc.Text = WQCrit.Item("Description")

                strSQLWQStdPoll = "SELECT POLLUTANT.NAME, POLL_WQCRITERIA.THRESHOLD, POLL_WQCRITERIA.POLL_WQCRITID " & "FROM POLL_WQCRITERIA INNER JOIN POLLUTANT " & "ON POLL_WQCRITERIA.POLLID = POLLUTANT.POLLID Where POLL_WQCRITERIA.WQCRITID = " & WQCrit.Item("WQCRITID")

                Using WQCmd As New OleDbCommand(strSQLWQStdPoll, g_DBConn)
                    Using WQ As New OleDbDataAdapter(WQCmd)
                        Dim dt As New DataTable()
                        WQ.Fill(dt)
                        dgvWaterQuality.DataSource = dt
                    End Using
                End Using
            Else

                MsgBox("Warning: There are no water quality standards remaining.  Please add a new one.", MsgBoxStyle.Critical, "Recordset Empty")
            End If

            OK_Button.Enabled = False

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub txtWQStdDesc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtWQStdDesc.TextChanged
        Try
            OK_Button.Enabled = True

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub mnuNewWQStd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuNewWQStd.Click
        Try
            Using addwq As New NewWaterQualityStandardForm()
                addwq.Init(Me, Nothing)
                addwq.ShowDialog()
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try

    End Sub

    Private Sub mnuDelWQStd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuDelWQStd.Click
        Try
            Dim intAns As Short
            intAns = MsgBox("Are you sure you want to delete the Water Quality Standard '" & cboWQStdName.SelectedItem & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirm Delete")
            'code to handle response

            'WQ Recordset
            Dim strWQStdDelete As String

            strWQStdDelete = "DELETE FROM WQCriteria WHERE NAME LIKE '" & cboWQStdName.Text & "'"
            Dim cmdWQ As New DataHelper(strWQStdDelete)

            'strWQStdDelete = "SELECT * FROM WQCriteria WHERE NAME LIKE '" & cboWQStdName.Text & "'"
            'Dim cmdWQ As New DataHelper(strWQStdDelete)
            'Dim wqSel As OleDbDataReader = cmdWQ.ExecuteReader()
            'wqSel.Read()
            'Doesn't seem to be used anymore
            'strWQPollDelete = "Delete * FROM POLL_WQCRITERIA WHERE WQCRITID =" & wqSel("WQCRITID").Value

            If Not (cboWQStdName.Text = "") Then
                'code to handle response
                If intAns = MsgBoxResult.Yes Then

                    'Delete the WaterQuality Standard
                    cmdWQ.ExecuteNonQuery()

                    MsgBox(cboWQStdName.SelectedItem & " deleted.", MsgBoxStyle.OkOnly, "Record Deleted")

                    cboWQStdName.Items.Clear()
                    InitComboBox(cboWQStdName, "WQCRITERIA")
                    Me.Refresh()

                ElseIf intAns = MsgBoxResult.No Then
                    Return
                End If
            Else
                MsgBox("Please select a water quality standard", MsgBoxStyle.Critical, "No Standard Selected")
            End If

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub mnuCopyWQStd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuCopyWQStd.Click
        Try
            Using copywq As New CopyWaterQualityStandardForm()
                copywq.Init(Me)
                copywq.ShowDialog()
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try

    End Sub

    Private Sub mnuImpWQStd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuImpWQStd.Click
        Try
            Using impwq As New ImportWaterQualityStandardForm()
                impwq.Init(Me)
                impwq.ShowDialog()
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try

    End Sub

    Private Sub mnuExpWQStd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuExpWQStd.Click
        Try
            Using dlgSave As New SaveFileDialog()
                dlgSave.Filter = Replace(MSG1TextFile, "<name>", "Water Quality Standard")
                dlgSave.Title = Replace(MSG3, "<name>", "Water Quality Standard")
                dlgSave.DefaultExt = ".txt"

                If dlgSave.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    'Export Water Quality Standard to file - dlgCMD1.FileName
                    ExportStandard(dlgSave.FileName)
                End If
            End Using

        Catch ex As Exception
            HandleError(ex)
        End Try

    End Sub

    Private Sub mnuWQHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuWQHelp.Click
        Try
            Help.ShowHelp(Me, g_nspectPath & "\Help\nspect.chm", "wq_stnds.htm")
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub dgvWaterQuality_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvWaterQuality.CellValueChanged
        OK_Button.Enabled = True
    End Sub

#End Region

#Region "Helper Functions"

    Private Function UpdateData() As Boolean
        Try
            'Selection based on combo box, update Description
            Dim updateDescription = String.Format("UPDATE WQCRITERIA SET Description = '{0}' WHERE NAME = '{1}'", txtWQStdDesc.Text, cboWQStdName.Text)
            Using updateCommand As OleDbCommand = New OleDbCommand(updateDescription, g_DBConn)
                updateCommand.ExecuteNonQuery()
            End Using

            'Now update Threshold values
            For i = 0 To dgvWaterQuality.Rows.Count - 1
                Dim updateThreshold = String.Format("UPDATE POLL_WQCRITERIA SET Threshold = {0} WHERE POLL_WQCRITID = {1}",
                                          dgvWaterQuality.Rows(i).Cells(1).Value,
                                          dgvWaterQuality.Rows(i).Cells(2).Value)
                Using updateCommand As OleDbCommand = New OleDbCommand(updateThreshold, g_DBConn)
                    updateCommand.ExecuteNonQuery()
                End Using
            Next i

            IsDirty = False
            Return True
        Catch ex As Exception
            HandleError(ex)
            Return False
        End Try
    End Function

    Private Function ValidateData() As Boolean
        Try
            Dim i As Short
            Dim val As String
            For i = 0 To dgvWaterQuality.Rows.Count - 1
                val = dgvWaterQuality.Rows(i).Cells(1).Value
                If IsNumeric(val) Then
                    If CShort(val) >= 0 Then
                        ValidateData = True
                    Else
                        MsgBox("Warning: Values must be greater than or equal to 0.", MsgBoxStyle.Critical, "Invalid Value")
                        Return False
                    End If
                ElseIf val <> "" Then
                    MsgBox("Numeric values only please.", MsgBoxStyle.Critical, "Numeric Values Only")
                    Return False
                End If
            Next
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Function

    Public Sub UpdateWQ(ByVal strWQName As String)
        Try
            cboWQStdName.Items.Clear()
            InitComboBox(cboWQStdName, "WQCRITERIA")
            cboWQStdName.SelectedIndex = GetIndexOfEntry(strWQName, cboWQStdName)
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    'Exports your current standard and pollutants to text or csv.

    Private Sub ExportStandard(ByRef strFileName As String)
        Try
            Using out As New StreamWriter(strFileName)
                'Write the name and descript.
                out.WriteLine(String.Format("{0},{1}", cboWQStdName.Text, txtWQStdDesc.Text))

                'Write name of pollutant and threshold
                For i = 0 To dgvWaterQuality.Rows.Count - 1
                    out.WriteLine(String.Format("{0},{1}", dgvWaterQuality.Rows(i).Cells(0).Value, dgvWaterQuality.Rows(i).Cells(1).Value))
                Next

            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

#End Region

    Protected Overrides Sub OK_Button_Click(sender As Object, e As EventArgs)
        Try
            If ValidateData() Then
                If (UpdateData()) Then
                    MsgBox("Data saved successfully.", MsgBoxStyle.Information, "Data Saved")
                    MyBase.OK_Button_Click(sender, e)
                End If
            End If

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub
End Class