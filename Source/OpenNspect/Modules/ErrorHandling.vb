'********************************************************************************************************
'File Name: ErrorHandlng.vb
'Description: Legacy of the old error handling code, eventually will be replaced
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
Module ErrorHandling
    '
    ' FILE AUTOMATICALLY GENERATED BY ESRI ERROR HANDLER ADDIN
    ' DO NOT EDIT OR REMOVE THIS FILE FROM THE PROJECT
    '

    Private Sub DisplayVersion2Dialog (ByRef sProcedureName As String, ByRef sErrDescription As String)
        Beep()
        MsgBox( _
                "An error has occured in the application.   Record the call stack sequence" & vbCrLf & _
                "and the description of the error." & vbCrLf & vbCrLf & "Error Call Stack Sequence " & vbCrLf & vbTab & _
                sProcedureName & vbCrLf & sErrDescription, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, _
                "Unexpected Program Error")
    End Sub

    Private Sub DisplayVersion3Dialog(ByRef sProcedureName As String, ByRef sErrDescription As String, _
                                       ByRef parentHWND As Integer, ByRef raiseException As Boolean)
        Beep()
        MsgBox( _
                "An error has occured in the application.   Record the call stack sequence" & vbCrLf & _
                "and the description of the error." & vbCrLf & vbCrLf & "Error Call Stack Sequence " & vbCrLf & vbTab & _
                sProcedureName & vbCrLf & sErrDescription, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, _
                "Unexpected Program Error")
    End Sub

    Private Sub DisplayVersion4Dialog(ByRef sProcedureName As String, ByRef sErrDescription As String, _
                                       ByRef parentHWND As Integer)
        Beep()
        MsgBox( _
                "An error has occured in the application.   Record the call stack sequence" & vbCrLf & _
                "and the description of the error." & vbCrLf & vbCrLf & "Error Call Stack Sequence " & vbCrLf & vbTab & _
                sProcedureName & vbCrLf & sErrDescription, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, _
                "Unexpected Program Error")
    End Sub

    Public Sub HandleError2010(ByVal bTopProcedure As Boolean, ByVal sProcedureName As String, _
                                ByVal lErrNumber As Integer, ByVal sErrSource As String, ByVal sErrDescription As String, _
                                Optional ByVal version As Integer = 1, Optional ByVal parentHWND As Integer = 0, _
                                Optional ByVal reserved1 As Object = 0, Optional ByVal reserved2 As Object = 0, _
                                Optional ByVal reserved3 As Object = 0)
        ' Generic Error handling Function - This function should be called with
        ' the following Arguments
        '
        ' Boolean    -in-  True if called from a top level procedure - Event / Method / Property
        ' String     -in-  Name of function called from
        ' Long       -in-  Error Number (retrieved from Err object)
        ' String     -in-  Error Source (retrieved from Err object)
        ' String     -in-  Error Description (retrieved from Err object)
        ' Long       -in-  Version of Function (optional Default 1)
        ' parentHWND -in-  Parent Hwnd for error dialogs, NULL is valid
        ' reserved1  -in-
        ' reserved2  -in-
        ' reserved3  -in-

        ' Clear the error object
        Err.Clear()

        ' Static variable used to control the call stack formatting
        Static entered As Boolean

        Dim raiseError As Boolean
        If (bTopProcedure) Then
            ' Top most procedure in call stack so report error to user
            ' Via a dialog
            If (Not entered) Then
                sErrDescription = vbCrLf & "Error Number " & vbCrLf & vbTab & CStr(lErrNumber) & vbCrLf & "Description" & _
                                  vbCrLf & vbTab & sErrDescription & vbCrLf & vbCrLf
            End If
            entered = False
            If (version = 4) Then
                DisplayVersion4Dialog(sProcedureName, sErrDescription, parentHWND)
            ElseIf (version = 3) Then
                DisplayVersion3Dialog(sProcedureName, sErrDescription, parentHWND, raiseError)
                If (raiseError) Then _
                    Err.Raise(lErrNumber, sErrSource, vbTab & sProcedureName & vbCrLf & sErrDescription)
            ElseIf (version = 2) Then
                DisplayVersion2Dialog(sProcedureName, sErrDescription)
            Else
                Beep()
                MsgBox( _
                        "An error has occured in the application.   Record the call stack sequence" & vbCrLf & _
                        "and the description of the error." & vbCrLf & vbCrLf & "Error Call Stack Sequence " & vbCrLf & _
                        vbTab & sProcedureName & vbCrLf & sErrDescription, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, _
                        "Unexpected Program Error")
            End If
        Else
            ' An error has occured but we are not at the top of the call stack
            ' so append the callstack and raise another error
            If (Not entered) Then _
                sErrDescription = vbCrLf & "Error Number " & vbCrLf & vbTab & CStr(lErrNumber) & vbCrLf & "Description" & _
                                  vbCrLf & vbTab & sErrDescription & vbCrLf & vbCrLf
            entered = True
            Err.Raise(lErrNumber, sErrSource, vbTab & sProcedureName & vbCrLf & sErrDescription)
        End If
    End Sub

    Public Function GetErrorLineNumberString(ByVal lLineNumber As Integer) As String
        ' Test the line number if it is non zero create a string
        If (lLineNumber <> 0) Then GetErrorLineNumberString = "Line : " & lLineNumber Else GetErrorLineNumberString = ""
    End Function
End Module