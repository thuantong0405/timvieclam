using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoclickTMTmine
{
    public partial class FrmListPoint : Form
    {
        private ListPointer listPointer = null;
        [DllImport("user32.dll")]
        public static extern IntPtr SetCursor(IntPtr handle);
        [DllImport("User32.dll", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)]
        private static extern IntPtr LoadCursorFromFile(String str);
        public FrmListPoint()
        {
            

            InitializeComponent();
            listPointer = new ListPointer();
            GetDataList();
        }

        private void FrmListPoint_Load(object sender, EventArgs e)
        {
            //GetDataList();
        }

        private void GetDataList()
        {
            string tmpType = "";
            dataGridView1.Rows.Clear();
            for (int i = 0; i < listPointer.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = listPointer.GetAll()[i].ID.ToString();
                dataGridView1.Rows[i].Cells[1].Value = listPointer.GetAll()[i].X.ToString();
                dataGridView1.Rows[i].Cells[2].Value = listPointer.GetAll()[i].Y.ToString();
                switch (listPointer.GetAll()[i].Type)
                {
                    case (int)MouseButtons.Left:
                        tmpType = "Left";
                        break;
                    case (int)MouseButtons.Right:
                        tmpType = "Right";
                        break;
                    default:
                        tmpType = "";
                        break;

                }
                dataGridView1.Rows[i].Cells[3].Value = tmpType;
                dataGridView1.Rows[i].Cells[4].Value = false;
                //DataGridViewComboBoxCell comboBoxCell = (dataGridView1.Rows[i].Cells[4] as DataGridViewComboBoxCell);
                dataGridView1.Rows[i].Cells["SltType"].Value = tmpType;
                //comboBoxCell.Items[0] = tmpType;
                dataGridView1.Rows[i].Cells[5].Value = listPointer.GetAll()[i].Type.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Cnt = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value != null)
                {
                    DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chkchecking.Value))
                    {
                        Cnt++;
                    }
                }
            }

            if(Cnt > 0)
            {
                DialogResult dr = MessageBox.Show("Do you really want to delete selected???", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if (row.Cells[0].Value != null)
                        {
                            DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(chkchecking.Value))
                            {
                                listPointer.RemoveP(Convert.ToInt32(row.Cells[0].Value));
                            }
                        }
                    }
                }
                
                GetDataList();
            }


        }

        private void FrmListPoint_FormClosed(object sender, FormClosedEventArgs e)
        {

            Form1 frm1 = new Form1(listPointer.Length.ToString());
            frm1.Show();
            this.Dispose(false);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine(e.ColumnIndex);
            if (e.ColumnIndex == 6)
            {
                int Iindex = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                this.Hide();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combox = e.Control as ComboBox;
            if(combox != null)
            {
                //combox.SelectedIndexChanged -= new EventHandler(ComboBox_Changed);
                ////combox.SelectedIndexChanged += new EventHandler(ComboBox_Changed);
                combox.SelectedIndexChanged -= new EventHandler(ComboBox_Changed);
                combox.SelectedIndexChanged += new EventHandler(ComboBox_Changed);
            }
        
        }
        private void ComboBox_Changed(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            string cbText = cb.Text;
            if(cbText != null)
            {
                Console.WriteLine(dataGridView1.CurrentRow.Index);
                int idX = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                if(idX != -1)
                {
                    if (cbText.Equals("Left"))
                    {
                        int iX = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
                        int iY = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                        listPointer.Edit(idX, new Point(idX, (int)MouseButtons.Left, iX, iY));
                    }
                    else
                    {
                        int iX = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value);
                        int iY = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
                        listPointer.Edit(idX, new Point(idX, (int)MouseButtons.Right, iX, iY));
                    
                    }
                    GetDataList();
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int Cnt = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value != null)
                {
                    DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chkchecking.Value))
                    {
                        Cnt++;
                    }
                }
            }

            if (Cnt > 0)
            {
                

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        if (row.Cells[0].Value != null)
                        {
                            DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(chkchecking.Value))
                            {
                            int id = Convert.ToInt32(listPointer.Length + 1);
                            int Typen = Convert.ToInt32(row.Cells[5].Value);
                            int Xn = Convert.ToInt32(row.Cells[1].Value);
                            int Yn = Convert.ToInt32(row.Cells[2].Value);

                                listPointer.AddPoint(new Point(id,Typen,Xn,Yn));
                            }
                        }
                    }
                

                GetDataList();
            }

        }

        private void btnShowPos_Click(object sender, EventArgs e)
        {
            MouseOutSide1.Start();

        }

        private void MouseOutSide1_Tick(object sender, EventArgs e)
        {
            IntPtr handle = LoadCursorFromFile(Application.StartupPath + @"\Equis.cur");
            SetCursor(handle);
            int Cnt = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value != null)
                {
                    DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(chkchecking.Value))
                    {
                        Cnt++;
                    }
                }
            }

            if (Cnt > 0)
            {

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null)
                    {
                        DataGridViewCheckBoxCell chkchecking = row.Cells[4] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(chkchecking.Value))
                        {

                            int Xn = Convert.ToInt32(row.Cells[1].Value);
                            int Yn = Convert.ToInt32(row.Cells[2].Value);
                            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(Xn, Yn);
                            Thread.Sleep(300);
                            
                        }
                    }
                }
                

            }
            MouseOutSide1.Stop();
        }
    }
}
