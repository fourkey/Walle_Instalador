Imports System
Imports System.Net.Dns
Imports System.IO
Imports Microsoft.Win32
Imports System.Net.NetworkInformation
Imports System.Management

Public Class Frm_Instalacao

    Dim WalleValidation As String = My.Settings.ProductKey
    Dim Funcao As New Funcao_Sistema

    'CRIPTOGRAFIA
    Public Shared UserCript As String = My.Settings.CriptUser
    Public Shared PassCript As String = My.Settings.CriptPass
    Public Shared CodCript As String = My.Settings.CodCript
    Public Shared KeyFourkey As String = My.Settings.KeyFourkey
    Public Shared ComputerName As New ArrayList
    Public Shared CodCriptFinal As String = ""
    Public Shared CaminhoWindows As String = ""
    Public Shared CaminhoFinalInstalacao As String = ""
    Public Shared Finalizado As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Iniciar_Instalacao.Click


        If Directory.Exists(CaminhoWindows & "\Fourkey\Walle") = True Then

            If MsgBox("Parece que ja existe uma instalação no seu computador, se continuar o Walle irá deletar todos os dados, referentes a ele, " _
                      & "na pasta de instalação padrão, deseja continuar?", vbInformation + vbYesNo) = vbYes Then

                Try

                    For Each nome In Directory.GetFiles(CaminhoWindows & "\Fourkey\Walle")

                        File.Delete(nome)

                    Next

                    My.Computer.FileSystem.DeleteDirectory(CaminhoWindows & "\Fourkey\Walle",
                                            FileIO.DeleteDirectoryOption.ThrowIfDirectoryNonEmpty)

                Catch ex As Exception

                    MsgBox("Não foi possível deletar os dados, pode ser que os mesmos estejam abertos ou você não tenha permissão de exclui-los. " _
                           & "Por favor entre em contato com o seu fornecedor ou tente novamente.")

                    Exit Sub

                End Try

            Else

                Exit Sub

            End If

        End If

        Pn1.Visible = True
        Btn_Iniciar_Instalacao.Visible = False
        Btn_Avancar.Visible = True

    End Sub

    Private Sub Txt_Produt_Key_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Produt_Key.KeyDown

        If Txt_Produt_Key.Text.Length = 34 And e.KeyCode <> Keys.Back Then

            Txt_Produt_Key.Enabled = False

            If Txt_Produt_Key.Text = WalleValidation Then

                Lab_Validacao.Text = "Validando..."
                Lab_Validacao.Visible = True
                Lab_Validacao.ForeColor = Color.DarkGreen
                Application.DoEvents()

                Try

                    'If Funcao.descarregarArquivo("ftp://ftp.fourkey.com.br", UserCript,
                    '                             PassCript, ComputerName, CodCript) = False Then

                    '    Lab_Validacao.Text = "Infelizmente não existem licenças dispoíveis para o seu usuário, " _
                    '        & "acesse o painel gerencial e veja as licenças alocadas."

                    '    Lab_Validacao.Visible = True
                    '    Lab_Validacao.ForeColor = Color.DarkRed
                    '    Btn_Avancar.Enabled = False
                    '    Txt_Produt_Key.Enabled = True

                    'Else

                    Lab_Validacao.Text = "Chave validada com sucesso!"
                    Btn_Avancar.Enabled = True

                    'End If

                Catch ex As Exception

                    Lab_Validacao.Text = "Não foi possível concluir a validação da chave, verifique sua conexão com a internet " _
                        & "ou entre em contato com seu fornecedor."
                    Lab_Validacao.Visible = True
                    Lab_Validacao.ForeColor = Color.DarkRed
                    Btn_Avancar.Enabled = False
                    Txt_Produt_Key.Enabled = True

                End Try

            Else

                Lab_Validacao.Text = "Chave inválida, por favor tente novamente"
                Lab_Validacao.Visible = True
                Lab_Validacao.ForeColor = Color.DarkRed
                Btn_Avancar.Enabled = False
                Txt_Produt_Key.Enabled = True

            End If

        ElseIf Txt_Produt_Key.Text.Length = 0 Then

            Lab_Validacao.Visible = False

        ElseIf Txt_Produt_Key.Text.Length = 6 And e.KeyCode <> Keys.Back Then

            Txt_Produt_Key.Text = Txt_Produt_Key.Text & "-"
            Txt_Produt_Key.SelectionStart = Txt_Produt_Key.Text.Length
            Txt_Produt_Key.ScrollToCaret()

        ElseIf Txt_Produt_Key.Text.Length = 13 And e.KeyCode <> Keys.Back Then

            Txt_Produt_Key.Text = Txt_Produt_Key.Text & "-"
            Txt_Produt_Key.SelectionStart = Txt_Produt_Key.Text.Length
            Txt_Produt_Key.ScrollToCaret()

        ElseIf Txt_Produt_Key.Text.Length = 20 And e.KeyCode <> Keys.Back Then

            Txt_Produt_Key.Text = Txt_Produt_Key.Text & "-"
            Txt_Produt_Key.SelectionStart = Txt_Produt_Key.Text.Length
            Txt_Produt_Key.ScrollToCaret()

        ElseIf Txt_Produt_Key.Text.Length = 27 And e.KeyCode <> Keys.Back Then

            Txt_Produt_Key.Text = Txt_Produt_Key.Text & "-"
            Txt_Produt_Key.SelectionStart = Txt_Produt_Key.Text.Length
            Txt_Produt_Key.ScrollToCaret()

        End If

    End Sub

    Private Sub Txt_Produt_Key_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Produt_Key.KeyPress

        If e.KeyChar = "-" Then

            e.Handled = True

        End If

        If Char.IsLower(e.KeyChar) Then

            Txt_Produt_Key.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim CaminhoWindonsPAC As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject

        For i As Integer = 0 To CaminhoWindonsPAC.Length - 1

            If CaminhoWindonsPAC.Chars(i) <> "\" Then

                CaminhoWindows = CaminhoWindows & CaminhoWindonsPAC.Chars(i)

            Else

                Exit For

            End If

        Next

        'Buscar endereco Processador
        For Each info In search.Get()

            strProcessorId = info("processorId").ToString()

        Next

        strProcessorId = strProcessorId.Replace(":", "-")
        strProcessorId = strProcessorId.Replace(".", "-")
        strProcessorId = strProcessorId.Replace("{", "")
        strProcessorId = strProcessorId.Replace("}", "")

        ComputerName.Add(strProcessorId)

        CodCriptFinal = Funcao.Criptografar(CodCript, KeyFourkey)

        Pn1.Left = 12
        Pn1.Top = 27
        Pn1.Width = 592
        Pn1.Height = 270

    End Sub

    Private Sub Btn_Avancar_Click(sender As Object, e As EventArgs) Handles Btn_Avancar.Click

        Pn2.Left = 12
        Pn2.Top = 27
        Pn2.Width = 592
        Pn2.Height = 270

        Pn2.Visible = True
        Pn1.Visible = False

        Btn_Avancar.Visible = False
        Btn_Avancar2.Visible = True

    End Sub


    Private Sub Btn_Avancar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_Avancar2_Click_1(sender As Object, e As EventArgs) Handles Btn_Avancar2.Click

        Pn3.Left = 12
        Pn3.Top = 27
        Pn3.Width = 592
        Pn3.Height = 270

        Pn3.Visible = True
        Pn2.Visible = False

        Btn_Avancar2.Visible = False

        Funcao.CopiarDados(CaminhoWindows, Check_Data.Checked, Txt_Local2.Text)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Folder_Pesq2.Description = "Selecione a pasta de instalação"
        Folder_Pesq2.RootFolder = Environment.SpecialFolder.MyComputer
        Folder_Pesq2.ShowNewFolderButton = True

        If Folder_Pesq2.ShowDialog = Windows.Forms.DialogResult.OK Then

            Txt_Local2.Text = Folder_Pesq.SelectedPath

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub Bt_Iniciar_Click(sender As Object, e As EventArgs) Handles Bt_Iniciar.Click

        Shell(Frm_Instalacao.CaminhoFinalInstalacao)
        Application.Exit()

    End Sub

    Private Sub Bt_Cancelar_Click(sender As Object, e As EventArgs) Handles Bt_Cancelar.Click

        Application.Exit()

    End Sub

    Private Sub Pn_Fechar_Click(sender As Object, e As EventArgs) Handles Pn_Fechar.Click

        Application.Exit()

    End Sub

    Private Sub Frm_Instalacao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Finalizado = False Then

            If MsgBox("Atenção: Pode ser que o Walle já tenha alocado a licença para esta maquina, caso isso tenha acontecido você só poderá remover esta " _
                   & "licença no painel administrativo, deseja continuar?", vbExclamation + vbYesNo) = vbYes Then

                Application.Exit()
                Finalizado = True

            Else

                e.Cancel = True

            End If

        End If

    End Sub

    Private Sub Pn_Mini_Click(sender As Object, e As EventArgs) Handles Pn_Mini.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Txt_Produt_Key_TextChanged(sender As Object, e As EventArgs) Handles Txt_Produt_Key.TextChanged

        If Txt_Produt_Key.Text.Length = 34 Then

            Txt_Produt_Key.Enabled = False

            If Txt_Produt_Key.Text = WalleValidation Then

                Lab_Validacao.Text = "Procurando Licença..."
                Lab_Validacao.Visible = True
                Lab_Validacao.ForeColor = Color.DarkGreen
                Application.DoEvents()

                Try

                    'If Funcao.descarregarArquivo("ftp://ftp.fourkey.com.br", UserCript,
                    '                             PassCript, ComputerName, CodCript) = False Then

                    '    Lab_Validacao.Text = "Infelizmente não existem licenças dispoíveis para o seu usuário, " _
                    '        & "acesse o painel gerencial e veja as licenças alocadas."

                    '    Lab_Validacao.Visible = True
                    '    Lab_Validacao.ForeColor = Color.DarkRed
                    '    Btn_Avancar.Enabled = False
                    '    Txt_Produt_Key.Enabled = True

                    'Else

                    Lab_Validacao.Text = "Chave validada com sucesso!"
                    Btn_Avancar.Enabled = True

                    'End If

                Catch ex As Exception

                    Lab_Validacao.Text = "Não foi possível concluir a validação da chave, verifique sua conexão com a internet " _
                        & "ou entre em contato com seu fornecedor."
                    Lab_Validacao.Visible = True
                    Lab_Validacao.ForeColor = Color.DarkRed
                    Btn_Avancar.Enabled = False
                    Txt_Produt_Key.Enabled = True

                End Try

            End If

        End If

    End Sub

End Class
