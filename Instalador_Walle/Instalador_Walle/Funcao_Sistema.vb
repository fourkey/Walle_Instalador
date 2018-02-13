Imports System.IO
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.Security.Permissions

Public Class Funcao_Sistema

    'Criptografia
    Dim textoCifrado As Byte()
    Dim sal() As Byte = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H5, &H4, &H3, &H2, &H1, &H0}
    Dim senha As String = ""
    Dim mensagem As String = ""

    Public Function descarregarArquivo(ByVal arquivoFTP As String,
                            ByVal usuario As String, ByVal senha As String,
                            ByVal ComputerName As ArrayList, ByVal Cod As String) As Boolean

        Dim sArquivos As ArrayList = New ArrayList
        Dim iContador As Integer
        Dim fwr As FtpWebRequest = FtpWebRequest.Create(arquivoFTP & "/Walle/Client/" & Cod & "/Licenca/Ativas")
        fwr.Credentials = New NetworkCredential(usuario, senha)
        fwr.Method = WebRequestMethods.Ftp.ListDirectory
        Dim sr As New StreamReader(fwr.GetResponse().GetResponseStream())
        Dim str As String = sr.ReadLine()
        Dim fluxoTexto As IO.StreamWriter
        Dim linhaTexto As String = ""
        Dim Cont As Boolean = False
        Dim CaminhoCop As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim NovaLinha As String = ""
        Dim ContTraco As Integer = 0

        CaminhoCop = CaminhoCop.Replace("Instalador_Walle.exe", "")

        'Verificando se ja foi instalado o Walle nesta máquina
        iContador = 0
        While Not str Is Nothing

            NovaLinha = str
            str = sr.ReadLine()
            NovaLinha = NovaLinha.Replace(".txt", "")

            For i As Integer = 0 To NovaLinha.Length - 1

                If ContTraco >= 2 Then

                    linhaTexto = linhaTexto & NovaLinha.Chars(i)

                End If

                If NovaLinha.Chars(i) = "-" Then

                    ContTraco = ContTraco + 1

                End If

            Next

            ContTraco = 0

            For i As Integer = 0 To ComputerName.Count - 1

                If linhaTexto = ComputerName.Item(i) Then

                    sr.Close()
                    sr = Nothing
                    fwr = Nothing

                    Return True
                    Exit Function

                End If

            Next

            linhaTexto = ""

        End While

        sr.Close()
        sr = Nothing
        fwr = Nothing

        fwr = FtpWebRequest.Create(arquivoFTP & "/Walle/Client/" & Cod & "/Licenca")
        fwr.Credentials = New NetworkCredential(usuario, senha)
        fwr.Method = WebRequestMethods.Ftp.ListDirectory
        sr = New StreamReader(fwr.GetResponse().GetResponseStream())
        str = sr.ReadLine()

        'Procurando lincenca
        iContador = 0
        While Not str Is Nothing

            linhaTexto = str
            str = sr.ReadLine()

            If linhaTexto <> "Ativas" Then

                Cont = True
                NovaLinha = ""
                NovaLinha = System.Environment.UserName & "-" & Format(Now, "yyyy_MM_dd_HH_mm_ss") & "-"

                For i As Integer = 0 To ComputerName.Count - 1

                    fluxoTexto = New IO.StreamWriter(CaminhoCop _
                                                 & "\" & NovaLinha & ComputerName.Item(i).ToString & ".txt")
                    fluxoTexto.Close()

                Next

                fwr = WebRequest.Create(arquivoFTP & "/Walle/Client/" & Cod & "/Licenca/" & linhaTexto)
                fwr.Credentials = New NetworkCredential(usuario, senha)
                fwr.Method = WebRequestMethods.Ftp.DeleteFile
                Dim ftpResp As FtpWebResponse = fwr.GetResponse

                Exit While

            End If

        End While

        sr.Close()
        sr = Nothing
        fwr = Nothing

        If Cont = True Then

            For i As Integer = 0 To ComputerName.Count - 1

                UploadFile(CaminhoCop & NovaLinha & ComputerName.Item(i) & ".txt",
                   arquivoFTP & "/Walle/Client/" & Cod & "/Licenca/Ativas/" & NovaLinha & ComputerName.Item(i) & ".txt",
                   usuario, senha)

                fluxoTexto = New IO.StreamWriter(CaminhoCop & ComputerName.Item(i).ToString & ".txt")
                fluxoTexto.Close()

                UploadFile(CaminhoCop & ComputerName.Item(i) & ".txt",
                   arquivoFTP & "/Walle/Client/" & Cod & "/Licenca/Ativas/User/" & ComputerName.Item(i) & ".txt",
                   usuario, senha)

                File.Delete(CaminhoCop & NovaLinha & ComputerName.Item(i) & ".txt")
                File.Delete(CaminhoCop & ComputerName.Item(i).ToString & ".txt")

            Next
            
            Return True

        Else

            Return False

        End If

    End Function

    Public Sub UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String)
        Dim _FileInfo As New System.IO.FileInfo(_FileName)

        ' Create FtpWebRequest object from the Uri provided
        Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

        ' Provide the WebPermission Credintials
        _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

        ' By default KeepAlive is true, where the control connection is not closed
        ' after a command is executed.
        _FtpWebRequest.KeepAlive = False

        ' set timeout for 20 seconds
        _FtpWebRequest.Timeout = 20000

        ' Specify the command to be executed.
        _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        ' Specify the data transfer type.
        _FtpWebRequest.UseBinary = True

        ' Notify the server about the size of the uploaded file
        _FtpWebRequest.ContentLength = _FileInfo.Length

        ' The buffer size is set to 2kb
        Dim buffLength As Integer = 2048
        Dim buff(buffLength - 1) As Byte

        ' Opens a file stream (System.IO.FileStream) to read the file to be uploaded
        Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()

        ' Stream to which the file to be upload is written
        Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()

        ' Read from the file stream 2kb at a time
        Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

        ' Till Stream content ends
        Do While contentLen <> 0
            ' Write Content from the file stream to the FTP Upload Stream
            _Stream.Write(buff, 0, contentLen)
            contentLen = _FileStream.Read(buff, 0, buffLength)
        Loop

        ' Close the file stream and the Request Stream
        _Stream.Close()
        _Stream.Dispose()
        _FileStream.Close()
        _FileStream.Dispose()
    End Sub

    Public Function Criptografar(ByVal TextoCif As String, ByVal SenhaCif As String) As String

        senha = SenhaCif
        mensagem = TextoCif

        Dim chave As New Rfc2898DeriveBytes(senha, sal)
        ' criptografa os dados
        Dim algoritmo = New RijndaelManaged()
        algoritmo.Key = chave.GetBytes(16)
        algoritmo.IV = chave.GetBytes(16)

        Dim fonteBytes() As Byte = New System.Text.UnicodeEncoding().GetBytes(mensagem)

        Using StreamFonte = New MemoryStream(fonteBytes)
            Using StreamDestino As New MemoryStream()
                Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateEncryptor(), CryptoStreamMode.Read)
                    moveBytes(crypto, StreamDestino)
                    textoCifrado = StreamDestino.ToArray()
                End Using
            End Using
        End Using

        Return Convert.ToBase64String(textoCifrado)

    End Function

    Private Sub moveBytes(ByVal fonte As Stream, ByVal destino As Stream)
        Dim bytes(2048) As Byte
        Dim contador = fonte.Read(bytes, 0, bytes.Length - 1)
        While (0 <> contador)
            destino.Write(bytes, 0, contador)
            contador = fonte.Read(bytes, 0, bytes.Length - 1)
        End While
    End Sub

    Public Sub CopiarDados(ByVal CaminhoDeInstalacao As String, ByVal DataCop As Boolean, ByVal CaminhoDosArquivos As String)

        Dim WalleClienteExe As Byte() = My.Resources.Walle_Client
        Dim WalleClienteExe2 As Byte() = My.Resources.Walle_Client_Data
        Dim Force As Byte() = My.Resources._4fkhost
        Dim Crip As Byte() = My.Resources.FourkeyCripto
        Dim NDde As Byte() = My.Resources.NDde



        Dim fluxoTexto As IO.StreamWriter

        Frm_Instalacao.Progress_Instalacao.Value = 1
        Application.DoEvents()

        CaminhoDeInstalacao = CaminhoDeInstalacao & "\Fourkey"

        If File.Exists(CaminhoDeInstalacao & "\Walle") Then

            If MsgBox("Parece que existe o Walle já esta instalado em sua máquina, para continuar, o instalador removerá todos os dados do caminho " _
                & "selecionado. Deseja continuar?", vbYesNo + vbInformation) = True Then

                File.Delete(CaminhoDeInstalacao & "\Walle")

            End If

        Else

            Directory.CreateDirectory(CaminhoDeInstalacao & "\Walle")

        End If

        Directory.CreateDirectory(CaminhoDeInstalacao & "\Walle\Refresh")
        Directory.CreateDirectory(CaminhoDeInstalacao & "\Walle\Logs")

        Frm_Instalacao.Progress_Instalacao.Value = 3
        Application.DoEvents()

        Using Arquivo1 As New FileStream(CaminhoDeInstalacao & "\Walle\Walle_Client.exe", FileMode.Create)

            Arquivo1.Write(WalleClienteExe, 0, WalleClienteExe.Length)

        End Using


        Using Arquivo11 As New FileStream(CaminhoDeInstalacao & "\Walle\4fkhost.exe", FileMode.Create)

            Arquivo11.Write(Force, 0, Force.Length)

        End Using

        Using Cripto As New FileStream(CaminhoDeInstalacao & "\Walle\FourkeyCripto.dll", FileMode.Create)

            Cripto.Write(Crip, 0, Crip.Length)

        End Using

        Using NDde_DLL As New FileStream(CaminhoDeInstalacao & "\Walle\NDde.dll", FileMode.Create)

            NDde_DLL.Write(NDde, 0, NDde.Length)

        End Using



        Frm_Instalacao.Progress_Instalacao.Value = 4
        Application.DoEvents()

        AdicionarAplicacaoAoIniciar(CaminhoDeInstalacao)


        Frm_Instalacao.Progress_Instalacao.Value = 5
        Application.DoEvents()

        If DataCop = True Then

            Using Arquivo2 As New FileStream(CaminhoDeInstalacao & "\Walle\Walle_Client_Data.exe", FileMode.Create)

                Arquivo2.Write(WalleClienteExe2, 0, WalleClienteExe2.Length)

            End Using

        Else

            fluxoTexto = New IO.StreamWriter(CaminhoDeInstalacao & "\Walle\NODATA.txt", True)
            fluxoTexto.Close()

        End If

        Frm_Instalacao.Progress_Instalacao.Value = 6
        Application.DoEvents()

        fluxoTexto = New IO.StreamWriter(CaminhoDeInstalacao & "\Walle\USERCLIENT.txt")
        fluxoTexto.WriteLine(Frm_Instalacao.CodCriptFinal)
        fluxoTexto.Close()

        Frm_Instalacao.Progress_Instalacao.Value = 7
        Application.DoEvents()

        SetAttr(CaminhoDeInstalacao & "\Walle\USERCLIENT.txt", vbHidden)

        Frm_Instalacao.Progress_Instalacao.Value = 8
        Application.DoEvents()

        fluxoTexto = New IO.StreamWriter(CaminhoDeInstalacao & "\Walle\LOCATION.txt")
        fluxoTexto.WriteLine(CaminhoDosArquivos)
        fluxoTexto.Close()

        Frm_Instalacao.Progress_Instalacao.Value = 9
        Application.DoEvents()

        SetAttr(CaminhoDeInstalacao & "\Walle\LOCATION.txt", vbHidden)

        Directory.CreateDirectory(CaminhoDosArquivos & "\Pendentes")
        Directory.CreateDirectory(CaminhoDosArquivos & "\Processados")

        Frm_Instalacao.Progress_Instalacao.Value = 10
        Application.DoEvents()

        Frm_Instalacao.Pn3.Visible = False
        Frm_Instalacao.Lb_Inicio.Text = "Walle instalado com sucesso!"
        Frm_Instalacao.Lb_Sub.Text = "Você já pode começar o monitoramento, clique no botão abaixo"

        Frm_Instalacao.CaminhoFinalInstalacao = CaminhoDeInstalacao & "\Walle\4fkhost.exe"
        Frm_Instalacao.Bt_Cancelar.Visible = True
        Frm_Instalacao.Bt_Iniciar.Visible = True

        Frm_Instalacao.Finalizado = True

    End Sub

    Public Sub AdicionarAplicacaoAoIniciar(ByVal CaminhoDeInstalacao As String)

        Try

            Using key As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

                key.SetValue(CaminhoDeInstalacao & "\Walle\4fkhost.exe", """" + CaminhoDeInstalacao & "\Walle\4fkhost.exe" + """")

            End Using

        Catch

            Throw

        End Try

    End Sub
End Class
