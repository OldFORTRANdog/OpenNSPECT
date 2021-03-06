'********************************************************************************************************
'File Name: frmPrecipitation.vb
'Description: Form for displaying Precipitation data
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
Imports System.Data
Imports MapWinGIS
Imports System.Data.OleDb

Friend Class PrecipitationScenariosForm
    Private _boolLoad As Boolean

    Private _pInputPrecipDS As Grid

#Region "Events"

    Private Sub frmPrecipitation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            _boolLoad = True
            InitComboBox(cboScenName, "PRECIPSCENARIO")
            OK_Button.Enabled = False
            _boolLoad = False
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboScenName_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboScenName.SelectedIndexChanged
        Try
            Dim strSQLPrecip As String
            strSQLPrecip = "SELECT * FROM PRECIPSCENARIO WHERE NAME LIKE '" & cboScenName.Text & "'"

            Using precipCmd As New OleDbCommand(strSQLPrecip, g_DBConn)
                Using precip As OleDbDataReader = precipCmd.ExecuteReader()
                    precip.Read()
                    'Populate the controls...
                    txtDesc.Text = precip.Item("Description")
                    txtPrecipFile.Text = precip.Item("PrecipFileName")
                    'select defaults
                    cboGridUnits.SelectedIndex = CShort(precip.Item("PrecipGridUnits"))
                    cboPrecipUnits.SelectedIndex = CShort(precip.Item("PrecipUnits"))
                    cboTimePeriod.SelectedIndex = precip.Item("Type")
                    cboPrecipType.SelectedIndex = precip.Item("PrecipType")
                    If precip.Item("Type") = 0 Then
                        txtRainingDays.Text = precip.Item("RainingDays")
                    End If
                End Using
            End Using

            OK_Button.Enabled = False
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub txtDesc_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtDesc.TextChanged
        Try
            MakeDirty()
            txtDesc.Text = Replace(txtDesc.Text, "'", "")
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub txtPrecipFile_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPrecipFile.TextChanged
        Try
            MakeDirty()
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cmdBrowseFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBrowseFile.Click
        Try
            Dim pPrecipRasterDataset As Grid
            Dim strProj As String

            _pInputPrecipDS = AddInputFromGxBrowserText(txtPrecipFile, "Choose Precipitation GRID")

            If _pInputPrecipDS Is Nothing Then
                Return
            Else

                pPrecipRasterDataset = _pInputPrecipDS
                strProj = CheckSpatialReference(pPrecipRasterDataset)
                If strProj = "" Then

                    MsgBox("The GRID you have choosen has no spatial reference information.  Please define a projection before continuing.", MsgBoxStyle.Exclamation, "No Project Information Detected")
                    txtPrecipFile.Text = ""
                    Return

                Else
                    If strProj.ToLower.Contains("units=m") Then
                        cboPrecipUnits.SelectedIndex = 0
                    Else
                        cboPrecipUnits.SelectedIndex = 1
                    End If
                End If

            End If

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboGridUnits_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboGridUnits.SelectedIndexChanged
        Try
            MakeDirty()
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboPrecipUnits_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPrecipUnits.SelectedIndexChanged
        Try
            MakeDirty()
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboTimePeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboTimePeriod.SelectedIndexChanged
        Try
            If cboTimePeriod.SelectedIndex = 0 Then
                lblRainingDays.Visible = True
                txtRainingDays.Visible = True
            Else
                lblRainingDays.Visible = False
                txtRainingDays.Visible = False
            End If

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub txtRainingDays_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRainingDays.TextChanged
        Try
            MakeDirty()

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub cboPrecipType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboPrecipType.SelectedIndexChanged
        Try
            If Not _boolLoad Then
                MakeDirty()
            End If
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub SaveRecord()
        Dim strSQLPrecip As String = "SELECT * FROM PRECIPSCENARIO WHERE NAME LIKE '" & cboScenName.Text & "'"

        Using precipCmd As New OleDbCommand(strSQLPrecip, g_DBConn)
            Dim precipAdapter As New OleDbDataAdapter(precipCmd)
            Using cBuilder As New OleDbCommandBuilder(precipAdapter)
                cBuilder.QuotePrefix = "["
                cBuilder.QuoteSuffix = "]"
            End Using
            Using dt As New DataTable()
                precipAdapter.Fill(dt)

                dt.Rows(0)("Name") = cboScenName.Text
                dt.Rows(0)("Description") = txtDesc.Text
                dt.Rows(0)("PrecipFileName") = txtPrecipFile.Text
                dt.Rows(0)("PrecipGridUnits") = cboGridUnits.SelectedIndex
                dt.Rows(0)("PrecipUnits") = cboPrecipUnits.SelectedIndex
                dt.Rows(0)("PrecipType") = cboPrecipType.SelectedIndex
                dt.Rows(0)("Type") = cboTimePeriod.SelectedIndex

                If cboTimePeriod.SelectedIndex = 0 Then
                    dt.Rows(0)("RainingDays") = CShort(txtRainingDays.Text)
                Else
                    dt.Rows(0)("RainingDays") = 0
                End If
                precipAdapter.Update(dt)
            End Using
        End Using

        IsDirty = False
    End Sub

    Private Sub mnuNewPrecip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuNewPrecip.Click
        Try
            Using newpre As New NewPrecipitationScenarioForm()
                newpre.Init(Nothing, Me)
                newpre.ShowDialog()
            End Using
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub mnuDelPrecip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuDelPrecip.Click
        Try
            Dim intAns As Object
            Dim strSQLPrecipDel As String
            'Dim cntrl As System.Windows.Forms.Control

            strSQLPrecipDel = "DELETE FROM PRECIPSCENARIO WHERE NAME LIKE '" & cboScenName.Text & "'"

            If Not (cboScenName.Text = "") Then
                intAns = MsgBox("Are you sure you want to delete the precipitation scenario '" & cboScenName.SelectedItem & "'?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Confirm Delete")
                'code to handle response
                If intAns = MsgBoxResult.Yes Then
                    'Set up a delete rs and get rid of it
                    Using cmdDel As New DataHelper(strSQLPrecipDel)
                        cmdDel.ExecuteNonQuery()
                    End Using

                    MsgBox(cboScenName.SelectedItem & " deleted.", MsgBoxStyle.OkOnly, "Record Deleted")

                    'Clear everything, clean up form
                    cboScenName.Items.Clear()

                    txtDesc.Text = ""
                    'txtDuration.Text = ""
                    txtPrecipFile.Text = ""

                    InitComboBox(cboScenName, "PRECIPSCENARIO")

                    Me.Refresh()

                ElseIf intAns = MsgBoxResult.No Then
                    Return
                End If
            Else
                MsgBox("Please select a Precipitation Scenario", MsgBoxStyle.Critical, "No Scenario Selected")
            End If
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

    Private Sub mnuPrecipHelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuPrecipHelp.Click
        Try
            Help.ShowHelp(Me, g_nspectPath & "\Help\nspect.chm", "precip.htm")
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

#End Region

#Region "Helper Functions"

    Private Function CheckParams() As Boolean
        Try
            'Check the inputs of the form, before saving
            If Len(txtDesc.Text) = 0 Then
                MsgBox("Please enter a description for this scenario", MsgBoxStyle.Critical, "Description Missing")
                txtDesc.Focus()
                CheckParams = False
                Exit Function
            End If

            If txtPrecipFile.Text = " " Or txtPrecipFile.Text = "" Then
                MsgBox("Please select a valid precipitation GRID before saving.", MsgBoxStyle.Critical, "GRID Missing")
                txtPrecipFile.Focus()
                CheckParams = False
                Exit Function
            End If

            If cboGridUnits.Text = "" Then
                MsgBox("Please select GRID units.", MsgBoxStyle.Critical, "Units Missing")
                cboGridUnits.Focus()
                CheckParams = False
                Exit Function
            End If

            If cboPrecipUnits.Text = "" Then
                MsgBox("Please select precipitation units.", MsgBoxStyle.Critical, "Units Missing")
                cboPrecipUnits.Focus()
                CheckParams = False
                Exit Function
            End If

            If Len(cboPrecipType.Text) = 0 Then
                MsgBox("Please select a Precipitation Type.", MsgBoxStyle.Critical, "Precipitation Type Missing")
                cboPrecipType.Focus()
                CheckParams = False
                Exit Function
            End If

            If Len(cboTimePeriod.Text) = 0 Then
                MsgBox("Please select a Time Period.", MsgBoxStyle.Critical, "Precipitation Time Period Missing")
                cboTimePeriod.Focus()
                CheckParams = False
                Exit Function
            End If

            If cboTimePeriod.SelectedIndex = 0 Then
                If Not IsNumeric(txtRainingDays.Text) Or Len(txtRainingDays.Text) = 0 Then
                    MsgBox("Please enter a numeric value for Raining Days.", MsgBoxStyle.Critical, "Raining Days Value Incorrect")
                    txtRainingDays.Focus()
                    CheckParams = False
                    Exit Function
                End If
            End If

            'if it got through all that, then set it to true
            CheckParams = True

        Catch ex As Exception
            HandleError(ex)
        End Try
    End Function

    Private Sub MakeDirty()
        OK_Button.Enabled = True
        IsDirty = True
    End Sub

    Public Sub UpdatePrecip(ByVal strPrecName As String)
        Try
            cboScenName.Items.Clear()
            InitComboBox(cboScenName, "PrecipScenario")
            cboScenName.SelectedIndex = GetIndexOfEntry(strPrecName, cboScenName)
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub

#End Region

    Protected Overrides Sub OK_Button_Click(sender As Object, e As EventArgs)

        Try
            If CheckParams() = True Then
                SaveRecord()

                MsgBox(cboScenName.Text & " saved successfully.", MsgBoxStyle.OkOnly, "Record Saved")
                MyBase.OK_Button_Click(sender, e)

            End If
        Catch ex As Exception
            HandleError(ex)
        End Try
    End Sub
End Class