Imports System
Imports System.Resources
Imports System.Drawing

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim localizedAudio As New SoundClass
    Dim localizedAudioFile As String

    Dim currentResX As ResXResourceSet

    Dim americanResX As ResXResourceSet = New ResXResourceSet("american.resx")
    Dim norwayResX As ResXResourceSet = New ResXResourceSet("norway.resx")
    Dim italyResX As ResXResourceSet = New ResXResourceSet("italy.resx")

#Region " Windows Form Designer generated code "
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        currentResX = americanResX
        MyRefresh()
    End Sub

    Private Sub MyRefresh()
        exitButton.Text = currentResX.GetString("exit")
        localGreetingLabel.Text = currentResX.GetString("greeting")
        localScenePictureBox.Image = Image.FromFile(currentResX.GetString("image"))
        localizedAudioFile = currentResX.GetString("sound")
        localizedAudio.PlaySoundFile(localizedAudioFile)
    End Sub

    Private Sub usaFlagPictureBox__Click(sender As System.Object, e As System.EventArgs) Handles usaFlagPictureBox_.Click
        currentResX = americanResX
        My.Computer.Audio.Play("C:\Users\Ki\Downloads\GoodDay.wav", AudioPlayMode.Background)
        MyRefresh()
    End Sub

    Private Sub norwayFlagPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles norwayFlagPictureBox.Click
        currentResX = norwayResX
        My.Computer.Audio.Play("C:\Users\Ki\Downloads\GodDag.wav", AudioPlayMode.Background)
        MyRefresh()
    End Sub

    Private Sub italyFlagPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles italyFlagPictureBox.Click
        currentResX = italyResX
        My.Computer.Audio.Play("C:\Users\Ki\Downloads\BuonaGiornata.wav", AudioPlayMode.Background)
        MyRefresh()
    End Sub

    Public Class SoundClass
        Declare Auto Function PlaySound Lib "winmm.dll" (ByVal name As String, ByVal hmod As Integer, ByVal flags As Integer) As Integer
        Public Const SND_FILENAME = &H20000
        Public Const SND_ASYNC = &H1

        Public Sub PlaySoundFile(ByVal filename As String)
            PlaySound(filename, Nothing, SND_FILENAME Or SND_ASYNC)
        End Sub
    End Class

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        End
    End Sub

End Class
