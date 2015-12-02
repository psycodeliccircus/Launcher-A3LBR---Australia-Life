

Public Class Launcher
    Public servername = "A3LBR"
    Public modsname = "@A3LBR_Addons;@A3LBR_Map;@A3LBR_Misc"
    Public website = "http://arma3lifebrasil.com.br/"
    Public ipserveur = "198.50.139.187:2318"
    Public servpassword = "232b6653f7cf1012"

    Dim facebook As String = "https://www.facebook.com/LakesideValley"
    Dim twitter As String = "https://twitter.com/renildomarcio"
    Dim youtube As String = "https://www.youtube.com/user/renildomarcio"

    'Links de Download Steam / Mega
    Dim steam1 As String = "http://steamcommunity.com/sharedfiles/filedetails/?id=516580766"
    Dim steam2 As String = "http://steamcommunity.com/sharedfiles/filedetails/?id=516565915"
    Dim steam3 As String = "http://steamcommunity.com/sharedfiles/filedetails/?id=516561703"
    Dim mega1 As String = "http://arma3lifebrasil.com.br/foruns/topic/240-arma-iii-instalação-da-versão-pirata/"
    Dim direto1 As String = "http://arma3lifebrasil.com.br/foruns/files/file/2-userconfig/"
    'WebRadio
    Dim M3 As String = "http://pastebin.com/raw.php?i=WBAaQfrd"
    Dim M3Str As System.IO.Stream
    Dim M3srRead As System.IO.StreamReader

    'Publicidades
    'link do banner
    Dim iml As String = "http://pastebin.com/raw.php?i=U8nsFz8n"
    Dim imgplStr As System.IO.Stream
    Dim imgplRead As System.IO.StreamReader
    'imagem do banner
    Dim im As String = "http://pastebin.com/raw.php?i=FjrCv3jj"
    Dim imgps2 As System.IO.Stream
    Dim imgpRead2 As System.IO.StreamReader

    'status
    Dim a3 As String = "http://pastebin.com/raw.php?i=3cESpd87"
    Dim t3 As String = "http://pastebin.com/raw.php?i=suXe7PpX"
    Dim a3Str As System.IO.Stream
    Dim a3srRead As System.IO.StreamReader
    Dim tsStr2 As System.IO.Stream
    Dim tssrRead2 As System.IO.StreamReader

    Public ipTS = "a3lbr.megats.com.br"
    Public portTS = "none"

    Public darma3 As String = "C:\Program Files (x86)\Steam\SteamApps\common\Arma 3\"
    Public appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & servername & "\"
    Public startoption = "-skipIntro"
    Public speudo = "NewUser"

    Public user As String = Environment.UserName
    Public internet As String

    Private Sub Launcher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'CloseArma3.RunWorkerAsync()
        Application.Exit()
    End Sub
    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles Me.Load
        Hwid.ChechforUpdate()
        'RichTextBox1.Text = Hwid.GetMOTD
        ITalk_Label9.Text = "Versão:" & Login.PVerison & ""
        ITalk_Label3.Text = "Bem-vindo(a): " & Login.TextBox1.Text & "!"

        If My.Computer.FileSystem.FileExists(appdata & "startoption.a3") Then
            startoption = My.Computer.FileSystem.ReadAllText(appdata & "startoption.a3")
        End If

        If My.Computer.FileSystem.FileExists(appdata & "speudo.a3") Then
            speudo = My.Computer.FileSystem.ReadAllText(appdata & "speudo.a3")
        End If
        My.Computer.FileSystem.CreateDirectory(appdata)

        If My.Computer.FileSystem.FileExists(appdata & "destination.a3") Then
            darma3 = My.Computer.FileSystem.ReadAllText(appdata & "destination.a3")
            If My.Computer.FileSystem.FileExists(darma3 & "arma3.exe") Then
            Else
                play_game.Visible = False
                MsgBox("O destino de arma3 é inválido!" & vbNewLine & "Antes de baixar mods, certifique-se de escolher o destino!")
            End If
        Else
            If My.Computer.FileSystem.FileExists(darma3 & "arma3.exe") Then
                darma3 = ("C:\Program Files (x86)\Steam\SteamApps\common\Arma 3\")
            Else
                Folder.ShowDialog()
                darma3 = Folder.SelectedPath & "\"
                My.Computer.FileSystem.WriteAllText(appdata & "destination.a3", darma3, False)
            End If
            If My.Computer.FileSystem.FileExists(darma3 & "arma3.exe") Then
            Else
                play_game.Visible = False
                ITalk_Icon_Info1.Visible = True
                MsgBox("O destino escolhido não é válido!")
                destino_pasta.Text = ("O destino escolhido não é válido!")
            End If
        End If
        destino_pasta.Text = ("Destino do Arma 3: " & darma3)
        'WebRadio
        Dim M3req As System.Net.WebRequest = System.Net.WebRequest.Create(M3)
        Dim M3resp As System.Net.WebResponse = M3req.GetResponse
        M3Str = M3resp.GetResponseStream
        M3srRead = New System.IO.StreamReader(M3Str)
        AxWindowsMediaPlayer1.URL = M3srRead.ReadToEnd
        AxWindowsMediaPlayer1.settings.volume = "5"
        TrackBar1.Value = "5"
        ITalk_Label7.Text = "Volume: 5"

        'Publicidades
        'imagem banner
        Dim imgp As System.Net.WebRequest = System.Net.WebRequest.Create(im)
        Dim imgp2 As System.Net.WebResponse = imgp.GetResponse
        imgps2 = imgp2.GetResponseStream
        imgpRead2 = New System.IO.StreamReader(imgps2)

        TextBox3.Text = imgpRead2.ReadToEnd

        Dim MyWebClient As New System.Net.WebClient
        Dim ImageInBytes() As Byte = MyWebClient.DownloadData(TextBox3.Text)
        Dim ImageStream As New IO.MemoryStream(ImageInBytes)
        PictureBox11.Image = New System.Drawing.Bitmap(ImageStream)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.Image = New System.Drawing.Bitmap(New IO.MemoryStream(New System.Net.WebClient().DownloadData(TextBox3.Text)))

        'link banner
        Dim imgpl As System.Net.WebRequest = System.Net.WebRequest.Create(iml)
        Dim imgplp As System.Net.WebResponse = imgpl.GetResponse
        imgplStr = imgplp.GetResponseStream
        imgplRead = New System.IO.StreamReader(imgplStr)

        TextBox4.Text = imgplRead.ReadToEnd

        'status
        Dim tsreq2 As System.Net.WebRequest = System.Net.WebRequest.Create(t3)
        Dim tsresp2 As System.Net.WebResponse = tsreq2.GetResponse
        tsStr2 = tsresp2.GetResponseStream
        tssrRead2 = New System.IO.StreamReader(tsStr2)

        TextBox2.Text = tssrRead2.ReadToEnd

        Dim a3req As System.Net.WebRequest = System.Net.WebRequest.Create(a3)
        Dim a3resp As System.Net.WebResponse = a3req.GetResponse
        a3Str = a3resp.GetResponseStream
        a3srRead = New System.IO.StreamReader(a3Str)

        TextBox1.Text = a3srRead.ReadToEnd

        If (TextBox1.Text = "statusoff") Then
            PictureBox2.Image = My.Resources.statusoff
            ITalk_Button_12.Visible = True
            play_game.Visible = False
        End If
        If (TextBox1.Text = "statuson") Then
            PictureBox2.Image = My.Resources.statuson
            ITalk_Button_12.Visible = False
            play_game.Visible = True
        End If
        If (TextBox2.Text = "statusoff") Then
            PictureBox3.Image = My.Resources.statusoff
        End If
        If (TextBox2.Text = "statuson") Then
            PictureBox3.Image = My.Resources.statuson
        End If
    End Sub

    Private Sub ITalk_Button_11_Click(sender As Object, e As EventArgs) Handles ITalk_Button_11.Click
        Folder.ShowDialog()
        darma3 = Folder.SelectedPath & "\"
        destino_pasta.Text = ("Destino do Arma 3: " & darma3)

        If My.Computer.FileSystem.FileExists(darma3 & "arma3.exe") Then
        Else
            play_game.Visible = False
            ITalk_Icon_Info1.Visible = True
            destino_pasta.Text = ("O destino de arma3 escolhido não é válido!")
            MsgBox("O destino de arma3 escolhido não é válido!")
        End If
        If My.Computer.FileSystem.FileExists(appdata & "destination.a3") Then
            My.Computer.FileSystem.DeleteFile(appdata & "destination.a3")
        End If
        My.Computer.FileSystem.WriteAllText(appdata & "destination.a3", darma3, False)
    End Sub

    Private Sub StartArma_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles StartArma.DoWork
        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
            If servpassword = "none" Then
                If startoption = "any" Then
                    If speudo = "NewUser" Then
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur)
                        End If

                    Else
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " -name=" & speudo)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " -name=" & speudo)
                        End If

                    End If
                Else
                    If speudo = "NewUser" Then
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " " & startoption)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " " & startoption)
                        End If

                    Else
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " " & startoption & " -name=" & speudo)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " " & startoption & " -name=" & speudo)
                        End If

                    End If

                End If

            Else
                If startoption = "any" Then
                    If speudo = "NewUser" Then
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword)
                        End If

                    Else
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " -name=" & speudo)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " -name=" & speudo)
                        End If

                    End If

                Else
                    If speudo = "NewUser" Then
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " " & startoption)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " " & startoption)
                        End If

                    Else
                        If My.Computer.FileSystem.FileExists(darma3 & "arma3battleye.exe") Then
                            Process.Start(darma3 & "arma3battleye.exe", "0 1 -mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " " & startoption & " -name=" & speudo)
                        Else
                            Process.Start(darma3 & "arma3.exe", "-mod=" & modsname & " -connect=" & ipserveur & " -password=" & servpassword & " " & startoption & " -name=" & speudo)
                        End If

                    End If

                End If

            End If
        Else
            MsgBox("Escolha o destino certo para arma 3 antes de fazer isso!", "Launcher" & servername)
        End If
    End Sub

    Private Sub play_game_Click(sender As Object, e As EventArgs) Handles play_game.Click
        StartArma.RunWorkerAsync()
    End Sub

    Private Sub CloseArma3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles CloseArma3.DoWork
        Dim a3
        Dim a3bis
        Dim a3battle
        Do
            a3 = 1
            a3bis = 1
            a3battle = 1
            If UBound(Diagnostics.Process.GetProcessesByName("arma3")) < 0 Then
                a3 = 0
            Else
                Dim myProcesses As Process() = Process.GetProcessesByName("arma3")
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    myProcess.Kill()
                Next myProcess
            End If
            If UBound(Diagnostics.Process.GetProcessesByName("arma3launcher")) < 0 Then
                a3bis = 0
            Else
                Dim myProcesses As Process() = Process.GetProcessesByName("arma3launcher")
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    myProcess.Kill()
                Next myProcess
            End If
            If UBound(Diagnostics.Process.GetProcessesByName("arma3battleye")) < 0 Then
                a3battle = 0
            Else
                Dim myProcesses As Process() = Process.GetProcessesByName("arma3battleye")
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    myProcess.Kill()
                Next myProcess
            End If
            If a3 = 0 And a3bis = 0 And a3battle = 0 Then
                Exit Sub
            End If
        Loop
    End Sub

    Private Sub ITalk_Button_12_Click(sender As Object, e As EventArgs) Handles ITalk_Button_12.Click
        MsgBox("Servidor esta em manutenção!" + vbCrLf + "Por favor tente de novo mais tarde!", MsgBoxStyle.Information, "Manutenção")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start(website)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Process.Start(facebook)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start(twitter)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Process.Start(youtube)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If portTS = "none" Then
            Process.Start("ts3server://" & ipTS)
        Else
            Process.Start("ts3server://" & ipTS & "?port=" & portTS)
        End If
    End Sub

    Private Sub ITalk_Button_13_Click(sender As Object, e As EventArgs) Handles ITalk_Button_13.Click
        Process.Start(steam1)
    End Sub

    Private Sub ITalk_Button_14_Click(sender As Object, e As EventArgs) Handles ITalk_Button_14.Click
        Process.Start(steam2)
    End Sub

    Private Sub ITalk_Button_15_Click(sender As Object, e As EventArgs) Handles ITalk_Button_15.Click
        Process.Start(steam3)
    End Sub

    Private Sub ITalk_Button_16_Click(sender As Object, e As EventArgs) Handles ITalk_Button_16.Click
        Process.Start(direto1)
    End Sub

    Private Sub ITalk_Button_17_Click(sender As Object, e As EventArgs) Handles ITalk_Button_17.Click
        Process.Start(mega1)
    End Sub

    Private Sub ITalk_Button_18_Click(sender As Object, e As EventArgs) Handles ITalk_Button_18.Click
        Process.Start(direto1)
    End Sub

    Private Sub ITalk_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ITalk_LinkLabel1.LinkClicked
        Process.Start("http://arma3lifebrasil.com.br/foruns/profile/1-renildomarcio/")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Process.Start(TextBox4.Text)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
        ITalk_Label7.Text = "Volume:" & TrackBar1.Value & ""
    End Sub

    Private Sub ITalk_Button_21_Click(sender As Object, e As EventArgs) Handles ITalk_Button_21.Click
        tf_instalador.Show()
    End Sub

End Class