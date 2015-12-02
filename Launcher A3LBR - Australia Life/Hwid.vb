Imports System.Net, System.IO, System.Management, System, System.Security.Cryptography, System.Text
'------------------------------------
'Criado dia 11/9/2015 as 00:20
'Creditos AugmentedSkillsBR
'WebSite www.developerscheatsbr.com
'E-mail: krsolucoesweb@gmail.com
'-----------------------------------
Public Module Hwid
    Public Function CheckLogin(ByVal Username As String, ByVal Password As String) As String
        Dim Answer1, Answer2, Answer3 As String
        Using md5Hash As MD5 = MD5.Create()
            Dim Hwid As String = GetID()
            'Não Mude esta area!
            Answer1 = GetMd5Hash(md5Hash, Hwid & " Not Banned " & Username & " " & Password & " 0")
            'Não Mude esta area!
            Answer2 = GetMd5Hash(md5Hash, Hwid & " Banned " & Username & " " & Password & " 1")
            'Não Mude esta area!
            Answer3 = GetMd5Hash(md5Hash, Hwid & " Not On System " & Username & " " & Password)
        End Using
        'Aqui sistema de login no sistema.
        Dim GET_Data As String = Login.URL & "/api.php?Action=Login&usr=" & Username & "&pas=" & Password & "&hwid=" & GetID()
        Try
            Dim WebReq As HttpWebRequest = HttpWebRequest.Create(GET_Data)
            Using WebRes As HttpWebResponse = WebReq.GetResponse
                Using Reader As New StreamReader(WebRes.GetResponseStream)
                    Dim Str As String = Reader.ReadLine
                    Select Case True
                        Case Str.Contains(Answer1)
                            Return "True"
                        Case Str.Contains(Answer2)
                            Return "Banned"
                        Case Str.Contains(Answer3)
                            Return "Invalid"
                        Case Else
                            Return "Invalid"
                    End Select
                End Using
            End Using
        Catch Ex As Exception
            MsgBox("Não é possível contatar servidor, por favor, tente novamente mais tarde!", MsgBoxStyle.Exclamation, "Error")
            Return "Invalid"
        End Try
    End Function
    'Sistema de registro.
    Public Sub RegisterUser(ByVal Username As String, ByVal Password As String, ByVal Code As String)
        Dim WebReq As HttpWebRequest = HttpWebRequest.Create(Login.URL & "/api.php?Action=Register&code=" & Code & "&usr=" & Username & "&pas=" & Password & "&hwid=" & GetID())
        Using WebRes As WebResponse = WebReq.GetResponse
            Using Reader As New StreamReader(WebRes.GetResponseStream)
                Dim Stream As String = Reader.ReadToEnd
            End Using
        End Using
        Select Case Hwid.CheckLogin(Username, Password)
            Case "True"
                MsgBox("Sua conta foi criada!", MsgBoxStyle.Information, "Criado!")
                Login.TextBox1.Text = Username
                Login.TextBox2.Text = Password
                Registro.Hide()
                Login.Show()
            Case "Banned"
                MsgBox("Você foi banido", MsgBoxStyle.Critical, "Banido")
            Case "Invalid"
                MsgBox("Código inválido", MsgBoxStyle.Critical, "Error")
            Case Else
                MsgBox("Um erro ocorreu. Por favor tente de novo mais tarde", MsgBoxStyle.Exclamation, "Error")
        End Select
    End Sub
    'Sistema de noticias
    Public Function GetMOTD()
        Using web As New WebClient
            Return web.DownloadString(Login.URL & "/Infomation.php?Action=Motd")
        End Using
    End Function
    'Sistema de Atualização!
    Public Sub ChechforUpdate()
        Using Web As New WebClient
            Dim Version As String = Web.DownloadString(Login.URL & "/Infomation.php?Action=Version")
            If Version = Login.PVerison Then
                GetMOTD()
            Else
                Dim Link As String = Web.DownloadString(Login.URL & "/Infomation.php?Action=Link")
                MsgBox("Atualização Encontrado", MsgBoxStyle.Information, "Atualização")
                'Downloader.DownloadLink = Link
                Process.Start("Update.exe")
                Application.Exit()
            End If
        End Using
    End Sub
    'Sistema de mudificação de senha.
    Public Sub Changepass(ByVal NewPass As String)
        Dim WebReq As HttpWebRequest = HttpWebRequest.Create(Login.URL & "/api.php?Action=ChangePass&usr=" & Login.TextBox1.Text & "&pas=" & Login.TextBox2.Text & "&hwid=" & Hwid.GetID & "&npas=" & NewPass)
        Using WebRes As WebResponse = DirectCast(WebReq.GetResponse, HttpWebResponse)
            Using Reader As New StreamReader(WebRes.GetResponseStream)
                Dim Stream As String = Reader.ReadToEnd
            End Using
        End Using
    End Sub
    'Sistema de HWID
    Public Function GetID() As String
        Dim HWID As String = SystemSerialNumber() & GetCPUID()
        If HWID.Contains(" ") Then HWID = HWID.Replace(" ", "")
        Return Convert.ToBase64String(New System.Text.ASCIIEncoding().GetBytes(HWID))
    End Function
    Private Function GetCPUID()
        Dim cpuInfo As String = String.Empty
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        For Each mo As ManagementObject In moc
            cpuInfo = mo.Properties("processorID").Value.ToString()
        Next
        Return cpuInfo
    End Function
    Private Function SystemSerialNumber() As String
        Try
            Dim wmi As Object = GetObject("WinMgmts:")
            Dim serial_numbers As String = String.Empty
            Dim mother_boards As Object = wmi.InstancesOf("Win32_BaseBoard")
            For Each board As Object In mother_boards
                serial_numbers &= board.SerialNumber
            Next board
            Return serial_numbers
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
    Public Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function
End Module
