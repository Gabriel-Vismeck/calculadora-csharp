using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using calculadora_csharp.Properties;

namespace calculadora_csharp
{
    public partial class Form1 : Form
    {


        //FORM
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 20, 20));
            button2.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 20, 20));
            button3.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 20, 20));
            button4.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button5.Height, 20, 20));
            button5.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 20, 20));
            button6.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button6.Width, button6.Height, 20, 20));
            button7.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button7.Width, button7.Height, 20, 20));
            button8.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button8.Width, button8.Height, 20, 20));
            button9.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button9.Width, button9.Height, 20, 20));
            button10.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button10.Width, button10.Height, 20, 20));
            button11.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button11.Width, button11.Height, 20, 20));
            button12.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button12.Width, button12.Height, 20, 20));
            button13.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button13.Width, button13.Height, 20, 20));
            button14.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button14.Width, button14.Height, 20, 20));
            button15.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button15.Width, button15.Height, 20, 20));
            button16.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button16.Width, button16.Height, 20, 20));
            button17.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button17.Width, button17.Height, 20, 20));
            button18.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button18.Width, button18.Height, 20, 20));

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeft,
           int nTop,
           int nRight,
           int nBottom,
           int nWidthEllipse,
           int nHeightEllipse
       );

        private void exitButton_Click(object sender, EventArgs e)
        {
            fadeTimer.Start();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fadeTimer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0.0)
            {
                Opacity -= 0.025;
            }
            else
            {
                fadeTimer.Stop();
                Application.Exit();
            }
        }

       



        //FORM


    }
}
