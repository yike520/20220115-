#include <reg52.h>
#include <string.h>
#include <ds1602.c>
sbit P10 =P1^0;
sbit P11 =P1^1;
sbit P12 =P1^2;
sbit P13 =P1^3;
sbit P17 =P1^7;


#define Uart_Buf_Max 50                          //接收缓冲区长度




bit ReceiveOK = 0;                               //接收完成标志位
bit on_off = 0;
unsigned char 	 usart_data =0,main_mode = 0;
//unsigned char code Head[] = {"MCU received: "};  //Head数组定义
unsigned char data RX_Buffer[Uart_Buf_Max];      //接收缓冲区定义                 

void ConfigUART(unsigned int baud);              //串行口配置函数
void SendData(unsigned char ch);                 //字符发送函数
void SendString(char *s);                        //字符串发送函数

/* 主函数 */
void main()
{
    EA = 1;                                   	 //使能总中断
    ConfigUART(9600);                            //配置串行口工作模式及参数
	memset(RX_Buffer,0,Uart_Buf_Max);            //首次运行时清空接收缓冲区
	init_1602();
	LCD_clr1602();
//	goto_xy(1,0);
//	display_string("hello");
    while(1)
	{
			goto_xy(1,0);	
		display_string("Stc Car sys");
			 if(P17 == 1)
			 {
			 		on_off = 1;
			 			goto_xy(2,9);
		   		 display_string("ON "); 
			 }
			 else if(P17 == 0)
			 {
			 		on_off = 0;
			 			goto_xy(2,9);
		   		 display_string("OFF");
			 }
			if(usart_data == 0x00)
			{
				main_mode = 0;
				P1 = 0x00; 
					goto_xy(2,0);
		   		 display_string("stop  ");
			}
			if(usart_data == 0x01)
			{
				main_mode = 1;
				P1 = 0x01;  
					goto_xy(2,0);
		   		 display_string("left   ");  
			}		
			if(usart_data == 0x02)
			{
				main_mode = 2;
				P1 = 0x05;    
					goto_xy(2,0);
		   		 display_string("forward"); 
			}	
			if(usart_data == 0x03)
			{
				main_mode = 3;
				P1 = 0x04;  
					goto_xy(2,0);
		   		 display_string("right  ");   
			}		
	   		if(usart_data == 0x04)
			{
				main_mode = 4;
				P1 = 0x0a;  
					goto_xy(2,0);
		   		 display_string("back   ");   
			}
		while(ReceiveOK)                         //等待接收完成
		{
			ReceiveOK = 0;                       //清零接收完成标志位
//			SendString(Head);                    //发送Head部分
//			SendString(RX_Buffer);               //发送接收到的数据
			memset(RX_Buffer,0,Uart_Buf_Max);    //发送结束后清空接收缓冲区
		}
	}
}
/* 串口配置函数，baud-通信波特率 */
void ConfigUART(unsigned int baud)
{
//	SCON  = 0x50;        //配置串口为模式1	
//	TH2 = 0xFF;          
//	TL2 = 0xDC;          //波特率:9600 晶振=11.0592MHz 
//	RCAP2H = 0xFF;   
//	RCAP2L = 0xDC;       //16位自动再装入值
//	
//	TCLK = 1;            //T2工作于发送波特率发生器方式
//	RCLK = 1;            //T2工作于接收波特率发生器方式
//	C_T2 = 0;            //T2定时器模式
//	EXEN2 = 0;           //禁止T2外部信号触发
//	CP_RL2 = 0;          //T2为16位自动装载方式
//	
//	ET2 = 0;             //禁止T2中断
//	ES  = 1;             //使能串口中断
//	TR2 = 1;             //定时器T2开启
    SCON  = 0x50;                                //配置串口为模式1
    TMOD &= 0x0F;                                //清零T1的控制位
    TMOD |= 0x20;                                //配置T1为模式2
    TH1 = 256 - (11059200/12/32)/baud;           //计算T1重载值
    TL1 = TH1;                                   //初值等于重载值
    ET1 = 0;                                     //禁止T1中断
    ES  = 1;                                     //使能串口中断
    TR1 = 1;                                     //启动T1
}
/* UART中断服务函数 */
void InterruptUART() interrupt 4
{
	static unsigned char data RX_Count = 0;      //静态计数变量
    if(RI)                                       //接收到字节
    {
        RI = 0;                                  //清零接收中断标志位
		usart_data = SBUF;            //接收字节存缓冲区
//		RX_Buffer[RX_Count++]  = SBUF;            //接收字节存缓冲区
//		if(RX_Count >= Uart_Buf_Max)             //判断溢出
//		{
//			RX_Count = 0;                        //溢出后覆盖原数据
//		}
		if(SBUF == '\n')                         //判断帧结束
		{
			ReceiveOK = 1;                       //接收完成
			RX_Count = 0;                        //清零计数
		}
    }
    if(TI)                                       //字节发送完毕
    {
        TI = 0;                                  //清零发送中断标志位
    }
}
/* UART字符发送函数 */
void SendData(unsigned char ch)
{
    SBUF = ch;                                   //启动发送
	while(!TI);                                  //等待结束
}
/* UART字符串发送函数 */
void SendString(char *s)
{
    while(*s)                                    //循环发送
    {
        SendData(*s++);
    }
}