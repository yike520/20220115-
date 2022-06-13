#include <reg52.h>
#include <string.h>
#include <ds1602.c>
sbit P10 =P1^0;
sbit P11 =P1^1;
sbit P12 =P1^2;
sbit P13 =P1^3;
sbit P17 =P1^7;


#define Uart_Buf_Max 50                          //���ջ���������




bit ReceiveOK = 0;                               //������ɱ�־λ
bit on_off = 0;
unsigned char 	 usart_data =0,main_mode = 0;
//unsigned char code Head[] = {"MCU received: "};  //Head���鶨��
unsigned char data RX_Buffer[Uart_Buf_Max];      //���ջ���������                 

void ConfigUART(unsigned int baud);              //���п����ú���
void SendData(unsigned char ch);                 //�ַ����ͺ���
void SendString(char *s);                        //�ַ������ͺ���

/* ������ */
void main()
{
    EA = 1;                                   	 //ʹ�����ж�
    ConfigUART(9600);                            //���ô��пڹ���ģʽ������
	memset(RX_Buffer,0,Uart_Buf_Max);            //�״�����ʱ��ս��ջ�����
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
		while(ReceiveOK)                         //�ȴ��������
		{
			ReceiveOK = 0;                       //���������ɱ�־λ
//			SendString(Head);                    //����Head����
//			SendString(RX_Buffer);               //���ͽ��յ�������
			memset(RX_Buffer,0,Uart_Buf_Max);    //���ͽ�������ս��ջ�����
		}
	}
}
/* �������ú�����baud-ͨ�Ų����� */
void ConfigUART(unsigned int baud)
{
//	SCON  = 0x50;        //���ô���Ϊģʽ1	
//	TH2 = 0xFF;          
//	TL2 = 0xDC;          //������:9600 ����=11.0592MHz 
//	RCAP2H = 0xFF;   
//	RCAP2L = 0xDC;       //16λ�Զ���װ��ֵ
//	
//	TCLK = 1;            //T2�����ڷ��Ͳ����ʷ�������ʽ
//	RCLK = 1;            //T2�����ڽ��ղ����ʷ�������ʽ
//	C_T2 = 0;            //T2��ʱ��ģʽ
//	EXEN2 = 0;           //��ֹT2�ⲿ�źŴ���
//	CP_RL2 = 0;          //T2Ϊ16λ�Զ�װ�ط�ʽ
//	
//	ET2 = 0;             //��ֹT2�ж�
//	ES  = 1;             //ʹ�ܴ����ж�
//	TR2 = 1;             //��ʱ��T2����
    SCON  = 0x50;                                //���ô���Ϊģʽ1
    TMOD &= 0x0F;                                //����T1�Ŀ���λ
    TMOD |= 0x20;                                //����T1Ϊģʽ2
    TH1 = 256 - (11059200/12/32)/baud;           //����T1����ֵ
    TL1 = TH1;                                   //��ֵ��������ֵ
    ET1 = 0;                                     //��ֹT1�ж�
    ES  = 1;                                     //ʹ�ܴ����ж�
    TR1 = 1;                                     //����T1
}
/* UART�жϷ����� */
void InterruptUART() interrupt 4
{
	static unsigned char data RX_Count = 0;      //��̬��������
    if(RI)                                       //���յ��ֽ�
    {
        RI = 0;                                  //��������жϱ�־λ
		usart_data = SBUF;            //�����ֽڴ滺����
//		RX_Buffer[RX_Count++]  = SBUF;            //�����ֽڴ滺����
//		if(RX_Count >= Uart_Buf_Max)             //�ж����
//		{
//			RX_Count = 0;                        //����󸲸�ԭ����
//		}
		if(SBUF == '\n')                         //�ж�֡����
		{
			ReceiveOK = 1;                       //�������
			RX_Count = 0;                        //�������
		}
    }
    if(TI)                                       //�ֽڷ������
    {
        TI = 0;                                  //���㷢���жϱ�־λ
    }
}
/* UART�ַ����ͺ��� */
void SendData(unsigned char ch)
{
    SBUF = ch;                                   //��������
	while(!TI);                                  //�ȴ�����
}
/* UART�ַ������ͺ��� */
void SendString(char *s)
{
    while(*s)                                    //ѭ������
    {
        SendData(*s++);
    }
}