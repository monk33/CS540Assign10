Imports System
Imports System.IO

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim bWeHaveAValidInputFile As Boolean = False
    Dim stringInputStringFile As FileStream
    Dim stringReader As StreamReader
    Dim workingString As String = ""
    Const FILE_PATH As String = "C:\Users\Ki\Documents\CS540Proj8\CS540Proj8\cs540hw8input.txt"

    Private Function readValidInputTextfile(ByVal fileName As String)
        Try
            stringInputStringFile = New FileStream(fileName, FileMode.Open, FileAccess.Read)
            stringReader = New StreamReader(stringInputStringFile)
            bWeHaveAValidInputFile = True
            Return True
        Catch ex As Exception
            bWeHaveAValidInputFile = False
            Return False
        End Try
    End Function

    Private Function getNextString(ByRef reader As StreamReader)
        Dim readString As String
        If reader.Peek() > -1 Then
            readString = reader.ReadLine()
        Else
            readString = ""
        End If
        Return readString
    End Function



    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If readValidInputTextfile(FILE_PATH) Then
            statusBarLabel.Text = ""
            workingString = getNextString(stringReader)
            processString(workingString)
        Else
            statusBarLabel.Text = "Input text file not found or is invalid"
        End If
    End Sub

    Private Sub processString(ByVal str As String)
        Dim f1 As Font
        Dim g1 As Graphics
        Dim s1 As SizeF
        Dim marginBuffer As Integer
        g1 = Me.resizeFontLabel.CreateGraphics
        s1 = g1.MeasureString(str, resizeControlLabel.Font)
        marginBuffer = g1.MeasureString("  ", resizeControlLabel.Font).Width
        resizeControlLabel.Width = s1.Width + marginBuffer
        g1.Dispose()

        resizeControlLabel.Text = str
        Dim f2 As Font
        Dim g2 As Graphics
        Dim s2 As SizeF
        Dim Faktor, FaktorX, FaktorY As Single
        g2 = Me.resizeFontLabel.CreateGraphics
        s2 = g2.MeasureString(" " + str, resizeFontLabel.Font)
        g2.Dispose()
        FaktorX = resizeFontLabel.Width / s2.Width
        FaktorY = resizeFontLabel.Height / s2.Height
        If FaktorX > FaktorY Then
            Faktor = FaktorX
        Else
            Faktor = FaktorX
        End If
        f2 = resizeFontLabel.Font
        resizeFontLabel.Font = New Font(f2.Name, f2.SizeInPoints * Faktor)
        resizeFontLabel.Height = resizeFontLabel.Font.Height
        resizeFontLabel.Text = str

        Dim f3 As Font
        Dim g3 As Graphics
        Dim s3 As SizeF
        Dim faktor1, faktor1x, faktor1y As Single
        g3 = Me.resizeFontLabelAlt.CreateGraphics
        s3 = g3.MeasureString("   " + str, resizeFontLabelAlt.Font)
        g3.Dispose()
        faktor1 = resizeFontLabelAlt.Width / s3.Width
        f3 = resizeFontLabelAlt.Font
        resizeFontLabelAlt.Font = New Font(f3.Name, f3.SizeInPoints * faktor1)

        resizeFontLabelAlt.Height = resizeFontLabelAlt.Font.Height

        resizeFontLabelAlt.Text = str
    End Sub

    Private Sub bNext_Click(sender As System.Object, e As System.EventArgs) Handles bNext.Click
        If bWeHaveAValidInputFile Then
            workingString = getNextString(stringReader)
            If workingString <> "" Then
                processString(workingString)
            Else
                End
            End If
        End If
    End Sub

    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        End
    End Sub
End Class
