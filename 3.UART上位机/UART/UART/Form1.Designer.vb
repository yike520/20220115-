<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Disconnect = New System.Windows.Forms.Button()
        Me.ComboBox_DataBits = New System.Windows.Forms.ComboBox()
        Me.ComboBox_StopBits = New System.Windows.Forms.ComboBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.ComboBox_BaudRate = New System.Windows.Forms.ComboBox()
        Me.Label_ConnectStatus = New System.Windows.Forms.Label()
        Me.ComboBox_ComList = New System.Windows.Forms.ComboBox()
        Me.CheckBox_Send_New_Row = New System.Windows.Forms.CheckBox()
        Me.Button_Send = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Recieve_Send = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Send = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.CheckBox_Com_Mode = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button_Disconnect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_DataBits)
        Me.GroupBox1.Controls.Add(Me.ComboBox_StopBits)
        Me.GroupBox1.Controls.Add(Me.Button_Connect)
        Me.GroupBox1.Controls.Add(Me.ComboBox_BaudRate)
        Me.GroupBox1.Controls.Add(Me.Label_ConnectStatus)
        Me.GroupBox1.Controls.Add(Me.ComboBox_ComList)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 169)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "串口信息"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "串口状态："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "数据位"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "停止位"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "波特率"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "串口号"
        '
        'Button_Disconnect
        '
        Me.Button_Disconnect.Location = New System.Drawing.Point(105, 119)
        Me.Button_Disconnect.Name = "Button_Disconnect"
        Me.Button_Disconnect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Disconnect.TabIndex = 4
        Me.Button_Disconnect.Text = "关闭串口"
        Me.Button_Disconnect.UseVisualStyleBackColor = True
        '
        'ComboBox_DataBits
        '
        Me.ComboBox_DataBits.FormattingEnabled = True
        Me.ComboBox_DataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.ComboBox_DataBits.Location = New System.Drawing.Point(63, 67)
        Me.ComboBox_DataBits.Name = "ComboBox_DataBits"
        Me.ComboBox_DataBits.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_DataBits.TabIndex = 1
        Me.ComboBox_DataBits.Text = "8"
        '
        'ComboBox_StopBits
        '
        Me.ComboBox_StopBits.FormattingEnabled = True
        Me.ComboBox_StopBits.Items.AddRange(New Object() {"1", "1.5", "2"})
        Me.ComboBox_StopBits.Location = New System.Drawing.Point(63, 91)
        Me.ComboBox_StopBits.Name = "ComboBox_StopBits"
        Me.ComboBox_StopBits.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_StopBits.TabIndex = 1
        Me.ComboBox_StopBits.Text = "1"
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(17, 119)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 3
        Me.Button_Connect.Text = "打开串口"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'ComboBox_BaudRate
        '
        Me.ComboBox_BaudRate.FormattingEnabled = True
        Me.ComboBox_BaudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200", "128000", "256000"})
        Me.ComboBox_BaudRate.Location = New System.Drawing.Point(63, 42)
        Me.ComboBox_BaudRate.Name = "ComboBox_BaudRate"
        Me.ComboBox_BaudRate.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_BaudRate.TabIndex = 1
        Me.ComboBox_BaudRate.Text = "9600"
        '
        'Label_ConnectStatus
        '
        Me.Label_ConnectStatus.AutoSize = True
        Me.Label_ConnectStatus.Location = New System.Drawing.Point(85, 150)
        Me.Label_ConnectStatus.Name = "Label_ConnectStatus"
        Me.Label_ConnectStatus.Size = New System.Drawing.Size(41, 12)
        Me.Label_ConnectStatus.TabIndex = 2
        Me.Label_ConnectStatus.Text = "未连接"
        '
        'ComboBox_ComList
        '
        Me.ComboBox_ComList.FormattingEnabled = True
        Me.ComboBox_ComList.Location = New System.Drawing.Point(63, 18)
        Me.ComboBox_ComList.Name = "ComboBox_ComList"
        Me.ComboBox_ComList.Size = New System.Drawing.Size(121, 20)
        Me.ComboBox_ComList.TabIndex = 1
        '
        'CheckBox_Send_New_Row
        '
        Me.CheckBox_Send_New_Row.AutoSize = True
        Me.CheckBox_Send_New_Row.Checked = True
        Me.CheckBox_Send_New_Row.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Send_New_Row.Location = New System.Drawing.Point(406, 189)
        Me.CheckBox_Send_New_Row.Name = "CheckBox_Send_New_Row"
        Me.CheckBox_Send_New_Row.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_Send_New_Row.TabIndex = 19
        Me.CheckBox_Send_New_Row.Text = "发送新行"
        Me.CheckBox_Send_New_Row.UseVisualStyleBackColor = True
        '
        'Button_Send
        '
        Me.Button_Send.Location = New System.Drawing.Point(393, 15)
        Me.Button_Send.Name = "Button_Send"
        Me.Button_Send.Size = New System.Drawing.Size(75, 40)
        Me.Button_Send.TabIndex = 12
        Me.Button_Send.Text = "发送"
        Me.Button_Send.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox_Recieve_Send)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(276, 204)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "接收显示"
        '
        'TextBox_Recieve_Send
        '
        Me.TextBox_Recieve_Send.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox_Recieve_Send.Location = New System.Drawing.Point(3, 17)
        Me.TextBox_Recieve_Send.Multiline = True
        Me.TextBox_Recieve_Send.Name = "TextBox_Recieve_Send"
        Me.TextBox_Recieve_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Recieve_Send.Size = New System.Drawing.Size(270, 184)
        Me.TextBox_Recieve_Send.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_Send)
        Me.GroupBox3.Controls.Add(Me.TextBox_Send)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(482, 60)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "发送输入"
        '
        'TextBox_Send
        '
        Me.TextBox_Send.Location = New System.Drawing.Point(14, 28)
        Me.TextBox_Send.Name = "TextBox_Send"
        Me.TextBox_Send.Size = New System.Drawing.Size(367, 21)
        Me.TextBox_Send.TabIndex = 11
        Me.TextBox_Send.Text = "This is a test!"
        '
        'SerialPort1
        '
        '
        'CheckBox_Com_Mode
        '
        Me.CheckBox_Com_Mode.AutoSize = True
        Me.CheckBox_Com_Mode.Checked = True
        Me.CheckBox_Com_Mode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Com_Mode.Location = New System.Drawing.Point(312, 189)
        Me.CheckBox_Com_Mode.Name = "CheckBox_Com_Mode"
        Me.CheckBox_Com_Mode.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox_Com_Mode.TabIndex = 22
        Me.CheckBox_Com_Mode.Text = "对话模式"
        Me.CheckBox_Com_Mode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 296)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox_Send_New_Row)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CheckBox_Com_Mode)
        Me.Name = "Form1"
        Me.Text = "UART"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button_Disconnect As System.Windows.Forms.Button
    Friend WithEvents ComboBox_DataBits As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_StopBits As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Connect As System.Windows.Forms.Button
    Friend WithEvents ComboBox_BaudRate As System.Windows.Forms.ComboBox
    Friend WithEvents Label_ConnectStatus As System.Windows.Forms.Label
    Friend WithEvents ComboBox_ComList As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox_Send_New_Row As System.Windows.Forms.CheckBox
    Friend WithEvents Button_Send As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Recieve_Send As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_Send As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents CheckBox_Com_Mode As System.Windows.Forms.CheckBox

End Class
