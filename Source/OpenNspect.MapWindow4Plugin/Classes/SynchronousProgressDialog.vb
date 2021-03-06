﻿Imports System.Windows.Forms

Public Class SynchronousProgressDialog
    Implements IDisposable

    Private form As ProgressForm
    Public Shared KeepRunning As Boolean

    Public Sub New(title As String, max As Integer, owner As Form)
        KeepRunning = True
        form = New ProgressForm

        If Not owner Is Nothing Then
            owner.AddOwnedForm(form)
        End If

        With form
            .CancelEnabled = True
            .Title = title
            .MinRange = 0
            .MaxRange = max
            .TimerEnabled = True
            .Show()
        End With
    End Sub

    ' This method increments the value by one to mimic the previous behavior
    Public Sub New(message As String, title As String, max As Integer, ByRef owner As Form)
        Me.New(title, max, owner)
        Increment(message)
    End Sub


    ''' <summary>
    ''' Increments the value by one and displays specified message.
    ''' </summary>
    ''' <param name="message">The message.</param><returns>Whether the process should continue to run.</returns>
    Public Function Increment(message As String) As Boolean
        Return StepTo(message, form.Progress + 1)
    End Function

    Public Function StepTo(message As String, value As Integer) As Boolean
        form.Description = message
        form.Progress = value
        Application.DoEvents()
        Return KeepRunning
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                With form
                    .TimerEnabled = False
                    .Close()
                    form = Nothing
                End With
            End If
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
