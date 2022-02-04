using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace UioTest
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>

    public struct USB_INPUT     // UIO 입력 패킷으로부터 데이타를 얻기 위한 구조체 
    {
        public int ProductID;   // 장치 ID 
        public Byte Status;     // 패킷 수신 상태값  0=입력 변화에 의한 수신, 1=데이타 재전송 요구에 의한 수신 
        public Byte Button;     // 입력 버턴값
        public Byte Output;     // USB 장치의 입출력 상태값
        public Byte Mask;       // 포트의 입출력 설정값. bit값이 '0'이면 출력, '1'이면 입력
    };

    public class Form1 : System.Windows.Forms.Form
	{
        /// <summary>
        /// uio.dll을 사용하기 위한 선언부입니다.
        /// </summary>
        /// 
        Control_Light ctr = new Control_Light();

        [DllImport("uio.dll")]
        private static extern int usb_io_init(int pID);
        [DllImport("uio.dll")]
        private static extern void set_usb_events(int hWnd);
        [DllImport("uio.dll")]
        private static extern void get_usb_input(int lParam, ref USB_INPUT uInput);
        [DllImport("uio.dll")]
        private static extern bool usb_io_output(int pID, int cmd, int io1, int io2, int io3, int io4);
        [DllImport("uio.dll")]
        private static extern bool usb_io_reset(int pID);
        [DllImport("uio.dll")]
        private static extern bool usb_in_request(int pID);
        /// 여기까지 uio.dll을 사용하기 위한 선언부

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ComboBox comboBox1;
        private Label label7;
        public StatusStrip statusStrip1;
        private Label label8;
        private Button button13;
        private Button button14;
        private Button button15;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ToolStripStatusLabel toolStripStatusLabel1;
        public ToolStripStatusLabel toolStripStatusLabel2;

		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();
			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "5";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(35, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "5";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(271, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 21);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(271, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(35, 21);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "USB I/O Module Test .... (c) Hando Computer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "USB Produc ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "[ Output 1 ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "[ Output 2 ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "[ Output 3 ]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "[ Output 4 ]";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(312, 117);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(35, 21);
            this.textBox5.TabIndex = 22;
            this.textBox5.Text = "5";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(312, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(35, 21);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = "5";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(312, 174);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(35, 21);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "5";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(312, 202);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 21);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "High";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(105, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "High";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(105, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "High";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(105, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "High";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 117);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Low";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 145);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "Low";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(158, 173);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "Low";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(158, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 23);
            this.button8.TabIndex = 30;
            this.button8.Text = "Low";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(213, 116);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 24);
            this.button9.TabIndex = 31;
            this.button9.Text = "Blink";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(213, 144);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(52, 24);
            this.button10.TabIndex = 32;
            this.button10.Text = "Blink";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(213, 173);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 24);
            this.button11.TabIndex = 33;
            this.button11.Text = "Blink";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(213, 201);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 23);
            this.button12.TabIndex = 34;
            this.button12.Text = "Blink";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "261",
            "262",
            "263",
            "264",
            "265",
            "266",
            "267",
            "268",
            "269",
            "281",
            "282",
            "283",
            "284",
            "285",
            "286",
            "287",
            "288",
            "289"});
            this.comboBox1.Location = new System.Drawing.Point(126, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 20);
            this.comboBox1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 12);
            this.label7.TabIndex = 36;
            this.label7.Text = "Function Call :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 352);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 22);
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel1.Text = " INPUT ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(310, 17);
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 12);
            this.label8.TabIndex = 38;
            this.label8.Text = "Return Value :";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(222, 61);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 24);
            this.button13.TabIndex = 39;
            this.button13.Text = "Search";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(84, 258);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 25);
            this.button14.TabIndex = 40;
            this.button14.Text = "Input Request";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(203, 258);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(110, 25);
            this.button15.TabIndex = 41;
            this.button15.Text = "Output Reset";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 12);
            this.label9.TabIndex = 42;
            this.label9.Text = "High/Low Time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 43;
            this.label10.Text = "---";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 44;
            this.label11.Text = "---";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "점멸시간 : 1~15(단위 0.1초)";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(382, 374);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            MessageFilter uioMf = new MessageFilter();      
            Form1 uioFrm = new Form1();

            uioMf.UIO_FORM = uioFrm;                // Form1 객체를 전달해준다.

            Application.AddMessageFilter(uioMf);    // 윈도우 이벤트(WM_????)를 받을 수 있도록 하는 함수
            Application.Run(uioFrm);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            set_usb_events(this.Handle.ToInt32());  // USB로부터 입력 패킷이 수신 되었을 때 WM_INPUT 이벤트가 발생하로록 설정
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int selectID;
            int usbID;

            selectID=0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_init(0x{0:x})", selectID);
            usbID = usb_io_init(selectID);
            label11.Text = string.Format("0x{0:x}", usbID); 
            if (usbID==0) label11.Text="0 = Device not found";
            if (usbID == 0xffff) label11.Text = "0xFFFF = Access denide";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID=0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_reset(0x{0:x})", selectID);
            result=usb_io_reset(selectID);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_in_request(0x{0:x})", selectID);
            result = usb_in_request(selectID);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,1,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, 1, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,2,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, 2, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,3,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, 3, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,4,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, 4, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,-1,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, -1, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,-2,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, -2, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,-3,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, -3, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int selectID;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            label10.Text = string.Format("usb_io_output(0x{0:x},0,-4,0,0,0)", selectID);
            result = usb_io_output(selectID, 0, -4, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int selectID;
            int blink;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            blink = Convert.ToInt32(textBox1.Text, 10) * 16;
            blink += Convert.ToInt32(textBox5.Text, 10);
            label10.Text = string.Format("usb_io_output(0x{0:x},0x{1:x},1,0,0,0)", selectID, blink);
            result = usb_io_output(selectID, blink, 1, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int selectID;
            int blink;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            blink = Convert.ToInt32(textBox2.Text, 10) * 16;
            blink += Convert.ToInt32(textBox6.Text, 10);
            label10.Text = string.Format("usb_io_output(0x{0:x},0x{1:x},2,0,0,0)", selectID, blink);
            //result = usb_io_output(selectID, blink, 2, 0, 0, 0);
            ctr.control_light(2, true, 1,0);
            //if (result) label11.Text = "True";
            //else label11.Text = "False";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int selectID;
            int blink;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            blink = Convert.ToInt32(textBox3.Text, 10) * 16;
            blink += Convert.ToInt32(textBox7.Text, 10);
            label10.Text = string.Format("usb_io_output(0x{0:x},0x{1:x},3,0,0,0)", selectID, blink);
            result = usb_io_output(selectID, blink, 3, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int selectID;
            int blink;
            bool result;

            selectID = 0;
            if (comboBox1.SelectedIndex >= 0) selectID = Convert.ToInt32(comboBox1.Text, 16);
            blink = Convert.ToInt32(textBox4.Text, 10) * 16 ;
            blink += Convert.ToInt32(textBox8.Text, 10);
            label10.Text = string.Format("usb_io_output(0x{0:x},0x{1:x},4,0,0,0)", selectID, blink);
            result = usb_io_output(selectID, blink, 4, 0, 0, 0);
            if (result) label11.Text = "True";
            else label11.Text = "False";
        }

	}

    public class MessageFilter : System.Windows.Forms.IMessageFilter
    {
        [DllImport("uio.dll")]
        private static extern void get_usb_input(int lParam, ref USB_INPUT uInput);
        
        const int WM_CREATE = 1;
        const int WM_INPUT = 255;
        const int WM_WM_DEVICECHANGE = 537;

        static int cnt;

        USB_INPUT uInput= new USB_INPUT ();
        Form1 frm = null;

        public Form1 UIO_FORM
        {
            set
            {
                frm = value;
            }
            get
            {
                return frm;
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CREATE:
                    break;

                case WM_INPUT:              // USB로부터 입력 패킷이 수신 되었을 때 발생하는 이벤트 
                    get_usb_input(m.LParam.ToInt32(), ref uInput);
                    frm.toolStripStatusLabel2.Text = string.Format(" pID:{0:X}, Status:{1:X2}, Button:{2:X2}, Mask:{3:X2}, Count:{4:0} ", 
                        uInput.ProductID, uInput.Status, uInput.Button, uInput.Mask, cnt++);
                    break;

                case WM_WM_DEVICECHANGE:    // USB 장치가 연결되거나 분리될 때 발생하는 이벤트 
                    break;
            }
            return false;
        }
    }
}
