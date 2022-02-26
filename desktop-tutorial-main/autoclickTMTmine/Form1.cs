using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace autoclickTMTmine
{
    public partial class Form1 : Form
    {
       
        private ListPointer listPointer = null;
 
        public string textCountP { get; set; }
        public bool StartClick = false;
        public string HotKey = "";
        // 2. Import the RegisterHotKey Method
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool mouse_event(int mouseflag, int dx, int dy, int dwdata, int dwex);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }
        public enum MouseKey
        {
            leftDown = 0x0002,
            leftUp = 0x0004,
            rightDown = 0x0008,
            rightUp = 0x0010
        }
        public Form1(string countTxt="0")
        {
            InitializeComponent();
            listPointer = new ListPointer();
            this.textCountP = countTxt;
            txtCntPoint.Text = listPointer.Length.ToString();
            InitHoyKeys();


        }
        public void InitHoyKeys()
        {
            // 3. Register HotKeys

            // Set an unique id to your Hotkey, it will be used to
            // identify which hotkey was pressed in your code to execute something
            int FirstHotkeyId = 1;
            // Set the Hotkey 
            int FirstHotKeyKey = (int)Keys.Right;
            //MessageBox.Show(Convert.ToString((int)Keys.Right));
            // Register the "F9" hotkey
            Boolean HotkeyRegistered = RegisterHotKey(
                this.Handle, FirstHotkeyId, (int)KeyModifier.Control, FirstHotKeyKey
            );
            HotKey = Convert.ToString(KeyModifier.Control) + " + " + Convert.ToString(Keys.Right);

            // 4. Verify if both hotkeys were succesfully registered, if not, show message in the console
            if (!HotkeyRegistered)
            {
                Console.WriteLine("Global Hotkey F9 couldn't be registered !");
            }
        }
        public int IClick=0;
        protected override void WndProc(ref Message m)
        {

            // 5. Catch when a HotKey is pressed !
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                // 6. Handle what will happen once a respective hotkey is pressed
                switch (id)
                {
                    case 1:
                        
                        StartClick = (StartClick) ? false : true;
                        if (StartClick)
                        {
                            timer1.Interval = Convert.ToInt32(TimeClickAT.Text);
                            IClick = 0;
                            timer1.Start();
                            btnStatus.Text = "Ran";
                        }
                        else
                        {
                            timer1.Stop();
                            btnStatus.Text = "Stopped";
                        }

                        break;
       
                }
            }

            base.WndProc(ref m);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timer2.Start();
            timer2.Interval = 1;
        }

        public void MouseAT_Click(int type, System.Drawing.Point p)
        {
            
            if (listBoxPoint.SelectedItem.Equals("None"))
            {
                switch (type)
                {
                    case (int)MouseButtons.Left:
                        mouse_event((int)MouseKey.leftDown, p.X, p.Y, 0, 0);
                        mouse_event((int)MouseKey.leftUp, p.X, p.Y, 0, 0);
                        break;
                    case (int)MouseButtons.Right:
                        mouse_event((int)MouseKey.rightDown, p.X, p.Y, 0, 0);
                        mouse_event(0x0010, p.X, p.Y, 0, 0);
                        break;

                }
            }
            else if(listBoxPoint.SelectedItem.Equals("Left"))
            {
                mouse_event((int)MouseKey.leftDown, p.X, p.Y, 0, 0);
                mouse_event((int)MouseKey.leftUp, p.X, p.Y, 0, 0);
            }
            else if(listBoxPoint.SelectedItem.Equals("Right"))
            {
                mouse_event((int)MouseKey.rightDown, p.X, p.Y, 0, 0);
                mouse_event(0x0010, p.X, p.Y, 0, 0);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IClick >= listPointer.Length) IClick = 0;

            if (checkBoxFreeze.Checked == true)
            {
                System.Windows.Forms.Cursor.Position = new System.Drawing.Point(listPointer.GetAll()[IClick].X, listPointer.GetAll()[IClick].Y);
            }

            MouseAT_Click(listPointer.GetAll()[IClick].Type, new System.Drawing.Point(listPointer.GetAll()[IClick].X, listPointer.GetAll()[IClick].Y));
            IClick++;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStatus.Enabled = false;
            btnStatus.Text = "Stopped";
            SetHotKey.Text = HotKey;
            textCountP = listPointer.Length.ToString();
            txtCntPoint.Text = textCountP;
            txtCntPoint.ReadOnly = true;
            checkBoxFreeze.Checked = true;
            listBoxPoint.SetSelected(listBoxPoint.FindString("None"),true);
            
            if (TimeClickAT.Text.Equals(""))
            {
                TimeClickAT.Text = "1000";
            }
            panelSetKey.Top = 0;
            panelSetKey.Left = 0;
            panelSetKey.Visible = false;
            textBox1.Visible = false;
            this.Height = 141;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really want to delete???", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            if (dr == DialogResult.Yes)
            {
                listPointer.RemoveAll();
                txtCntPoint.Text = "0";
            }
            
        }

        private void SetHotKey_Click(object sender, EventArgs e)
        {
            panelSetKey.Visible = true;
            this.ActiveControl = textBox1;
    
        }

        /// <summary>
        /// Set point to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            PositionVal.Text = "X: " + Cursor.Position.X.ToString() + ":" + "Y: " + Cursor.Position.Y.ToString();
        
            if (MouseButtons == MouseButtons.Left)
            {
                listPointer.AddPoint(new Point(Convert.ToInt32(listPointer.Length) + 1,(int)MouseButtons.Left,Cursor.Position.X, Cursor.Position.Y));
                txtCntPoint.Text = listPointer.Length.ToString();
                this.Show();
                timer2.Stop();
            }

            if (MouseButtons == MouseButtons.Right)
            {
                listPointer.AddPoint(new Point(Convert.ToInt32(listPointer.Length) +1, (int)MouseButtons.Right, Cursor.Position.X, Cursor.Position.Y));
                txtCntPoint.Text = listPointer.Length.ToString();
                this.Show();
                timer2.Stop();
            }

        }
        


        private void txtCntPoint_Click(object sender, EventArgs e)
        {
            FrmListPoint listForm = new FrmListPoint();
            listForm.Show(); 
            this.Dispose(false);
            
        }
        public string HoyKeySetTmp = "";
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            //MessageBox.Show(e.KeyChar.ToString());
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
        }

        
       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = "";
            
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(panelSetKey.Visible == true)
            {
                string[] HotKeyCheck = HoyKeySetTmp.Split('+');
                //MessageBox.Show(HotKeyCheck.Length.ToString());
                if (HotKeyCheck.Length > 2) HoyKeySetTmp = "";
                HoyKeySetTmp = HoyKeySetTmp + e.KeyCode.ToString() + " + ";
                lblHoykeySet.Text = HoyKeySetTmp.Substring(0, HoyKeySetTmp.Length - 3);
                this.ActiveControl = textBox1;
            }
            
        }
    }
}
