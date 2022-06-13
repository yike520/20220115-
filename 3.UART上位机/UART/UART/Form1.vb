Imports System.IO.Ports
Imports System.Text

Public Class Form1

    '触发接收事件
    Public Sub Sp_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.Invoke(New EventHandler(AddressOf Sp_Receiving))    '调用接收数据函数
    End Sub

    '接收数据（等待新行）
    Private Sub Sp_Receiving(ByVal sender As Object, ByVal e As EventArgs)
        Dim strIncoming As String                              '存储接收的数据
        Try
            strIncoming = SerialPort1.ReadLine() & vbCrLf      '等待接收到新行
            SerialPort1.DiscardInBuffer()                      '清空输入缓冲区
            TextBox_Recieve_Send.Text =
            TextBox_Recieve_Send.Text & "received: " _
            & strIncoming                                      '显示接收的数据
        Catch

        End Try
        SerialPort1.DiscardInBuffer()                          '清空输入缓冲区
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True                                   '注册窗体的键盘事件
        GetSerialPortNames()                                   '获取系统可用串口号                                             
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        If SerialPort1.IsOpen Then
            SerialPort1.Close()                                '如果串口打开则关闭
        End If
    End Sub

    Sub GetSerialPortNames()                                   '计算机串口读取
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_ComList.Items.Add(sp)                     '添加串口号
        Next
        ComboBox_ComList.Sorted = True
        ComboBox_ComList.SelectedIndex = 0
    End Sub

    Sub PortSet()                                              '串口设置
        SerialPort1.PortName = ComboBox_ComList.Text           '串口编号设置
        SerialPort1.BaudRate = ComboBox_BaudRate.Text          '波特率设置
        SerialPort1.DataBits = ComboBox_DataBits.Text          '数据位设置
        SerialPort1.StopBits = ComboBox_StopBits.Text          '停止位设置
        SerialPort1.Encoding = System.Text.Encoding.Default    '编码格式设置
        SerialPort1.ReadTimeout = 500                          '超时时间设置
    End Sub

    Sub PortOpen()
        PortSet()                                              '串口设置
        Try
            SerialPort1.Open()                                 '尝试打开串口
        Catch ex As UnauthorizedAccessException
            MsgBox("串口被占用或串口错误！", MsgBoxStyle.Information, "提示！")
        End Try
        Label_ConnectStatus.Text = "已打开"
    End Sub

    Sub PortClose()
        Try
            SerialPort1.Close()                                '尝试关闭串口
        Catch ex As Exception
            MsgBox("串口未打开或串口异常！", MsgBoxStyle.Information, "提示！")
        End Try
        Label_ConnectStatus.Text = "已关闭"
    End Sub

    Private Sub Button_Connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Connect.Click
        PortOpen()                                             '打开串口
    End Sub

    Private Sub Button_Disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Disconnect.Click
        PortClose()                                            '关闭串口
    End Sub

    Private Sub Button_Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Send.Click
        Send()                                                 '启动发送
    End Sub

    Sub Send()
        Dim Text As String                                     '待发送数据
        If CheckBox_Send_New_Row.Checked = True Then           '如果发送新行被勾选
            Text = TextBox_Send.Text & vbCrLf                  '数据后增加回车换行
        Else
            Text = TextBox_Send.Text                           '否则不做处理
        End If
        If CheckBox_Com_Mode.Checked = True Then               '如果对话模式被勾选
            TextBox_Recieve_Send.Text =
            TextBox_Recieve_Send.Text & "send:     " _
            & Text                                             '显示发送的数据
        End If
        Try
            SerialPort1.Write(Text)                            '启动数据发送过程
        Catch ex As Exception
            MessageBox.Show(ex.Message)                        '错误处理显示消息
        End Try
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then                         '回车键检测
            Send()                                             '启动发送
        End If
    End Sub

    Private Sub TextBox_Recieve_Send_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_Recieve_Send.TextChanged
        TextBox_Recieve_Send.SelectionStart = Len(TextBox_Recieve_Send.Text)
        TextBox_Recieve_Send.ScrollToCaret()                   '接收文本框滚动控制
    End Sub
End Class

''接收数据（定时读取）
'Private Sub Sp_Receiving(ByVal sender As Object, ByVal e As EventArgs)
'    Dim strIncoming As String                              '存储接收的数据
'    If SerialPort1.BytesToRead > 0 Then
'        Threading.Thread.Sleep(200)                        '添加的延时
'        strIncoming = SerialPort1.ReadExisting.ToString    '读取缓冲区数据
'        SerialPort1.DiscardInBuffer()                      '清空输入缓冲区
'        TextBox_Recieve_Send.Text = _
'        TextBox_Recieve_Send.Text + strIncoming            '显示接收的数据
'    End If
'End Sub