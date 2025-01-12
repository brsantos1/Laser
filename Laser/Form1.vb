
Imports System.IO
Imports System.IO.Ports
Imports FxResources.System.IO


Public Class Form1
    Private Sub btn_Sair_Click(sender As Object, e As EventArgs) Handles btn_Sair.Click
        'Sair do programa
        '
        End

    End Sub

    Private _port As SerialPort
    Private Sub btn_Conectar_Click(sender As Object, e As EventArgs) Handles btn_Conectar.Click
        Try
            If _port Is Nothing Then
                _port = New SerialPort(cmb_portas.SelectedItem.ToString(), 115200)
                _port.Open()
                MessageBox.Show("Conectado ao GRBL com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Xmenos_Click(sender As Object, e As EventArgs) Handles btn_Xmenos.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("G91 G01 X-1 F500") ' Decrementa 1 unidade no eixo X
        End If
    End Sub

    Private Sub btn_Xmais_Click(sender As Object, e As EventArgs) Handles btn_Xmais.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("G91 G01 X1 F500") ' Decrementa 1 unidade no eixo X
        End If
    End Sub

    Private Sub btn_Rmenos_Click(sender As Object, e As EventArgs) Handles btn_Rmenos.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("G91 G01 Y-1 F500") ' Decrementa 1 unidade no eixo X
        End If
    End Sub

    Private Sub btn_Rmais_Click(sender As Object, e As EventArgs) Handles btn_Rmais.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("G91 G01 Y1 F500") ' Decrementa 1 unidade no eixo X
        End If
    End Sub

    Private Sub btn_Ligar_Click(sender As Object, e As EventArgs) Handles btn_Ligar.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("M03 S1000") ' Liga o laser
        End If
    End Sub

    Private Sub btn_Desligar_Click(sender As Object, e As EventArgs) Handles btn_Desligar.Click
        If _port IsNot Nothing AndAlso _port.IsOpen Then
            _port.WriteLine("M05") ' Desliga o laser
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Obtem todas as portas disponíveis e as adiciona ao ComboBox.
        cmb_portas.Items.Clear()
        cmb_portas.Items.AddRange(SerialPort.GetPortNames())
    End Sub
    Private Sub cmb_portas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_portas.SelectedIndexChanged

    End Sub

    Private Sub txt_GCode_TextChanged(sender As Object, e As EventArgs) Handles txt_GCode.TextChanged

    End Sub

    Private Sub btn_Enviar_Click(sender As Object, e As EventArgs) Handles btn_Enviar.Click
        Dim linhasGCode As String() = txt_GCode.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)

        If Not _port.IsOpen Then
            MessageBox.Show("A porta serial não está aberta!")
            Return
        End If


        For Each linha As String In linhasGCode
            ' Remove espaços em branco extras e envia a linha.
            linha = linha.Trim()
            If Not String.IsNullOrEmpty(linha) Then
                _port.WriteLine(linha)
                ' Aguarda resposta do GRBL.
                Dim resposta As String = _port.ReadLine()
                Console.WriteLine($"GRBL: {resposta}")
            End If
        Next
    End Sub

    Private Sub Btn_unlock_Click(sender As Object, e As EventArgs) Handles Btn_unlock.Click
        Try
            ' Verifica se a porta serial está aberta.
            If _port Is Nothing Then

            End If
            _port.WriteLine("$X")
            Dim resposta = _port.ReadLine
            Console.WriteLine($"GRBL (Unlock): {resposta}")
            MessageBox.Show("Desbloqueio enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Erro ao enviar o comando de desbloqueio: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_lock_Click(sender As Object, e As EventArgs) Handles Btn_lock.Click
        Try
            ' Verifica se a porta serial está aberta.
            If Not _port.IsOpen Then
                MessageBox.Show("Conecte-se a uma porta antes de enviar comandos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Envia o comando de travamento ($H ou outro comando para o GRBL).
            _port.WriteLine("$H")
            Dim resposta As String = _port.ReadLine()
            Console.WriteLine($"GRBL (Lock): {resposta}")
            MessageBox.Show("Travamento enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show($"Erro ao enviar o comando de travamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
