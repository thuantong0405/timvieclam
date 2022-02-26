
namespace autoclickTMTmine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.PositionVal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SetHotKey = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TimeClickAT = new System.Windows.Forms.TextBox();
            this.txtCntPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFreeze = new System.Windows.Forms.CheckBox();
            this.listBoxPoint = new System.Windows.Forms.ListBox();
            this.btnStatus = new System.Windows.Forms.Button();
            this.panelSetKey = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSelectedKey = new System.Windows.Forms.Button();
            this.lblHoykeySet = new System.Windows.Forms.Label();
            this.panelSetKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Point";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PositionVal
            // 
            this.PositionVal.AutoSize = true;
            this.PositionVal.Location = new System.Drawing.Point(3, 2);
            this.PositionVal.Name = "PositionVal";
            this.PositionVal.Size = new System.Drawing.Size(79, 12);
            this.PositionVal.TabIndex = 1;
            this.PositionVal.Text = "Position Value";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetHotKey
            // 
            this.SetHotKey.Location = new System.Drawing.Point(5, 62);
            this.SetHotKey.Name = "SetHotKey";
            this.SetHotKey.Size = new System.Drawing.Size(123, 30);
            this.SetHotKey.TabIndex = 3;
            this.SetHotKey.Text = "Set Key";
            this.SetHotKey.UseVisualStyleBackColor = true;
            this.SetHotKey.Click += new System.EventHandler(this.SetHotKey_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimeClickAT
            // 
            this.TimeClickAT.Location = new System.Drawing.Point(248, 20);
            this.TimeClickAT.Name = "TimeClickAT";
            this.TimeClickAT.Size = new System.Drawing.Size(89, 19);
            this.TimeClickAT.TabIndex = 6;
            // 
            // txtCntPoint
            // 
            this.txtCntPoint.Location = new System.Drawing.Point(79, 21);
            this.txtCntPoint.Name = "txtCntPoint";
            this.txtCntPoint.Size = new System.Drawing.Size(49, 19);
            this.txtCntPoint.TabIndex = 7;
            this.txtCntPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCntPoint.Click += new System.EventHandler(this.txtCntPoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Time:";
            // 
            // checkBoxFreeze
            // 
            this.checkBoxFreeze.AutoSize = true;
            this.checkBoxFreeze.Location = new System.Drawing.Point(6, 43);
            this.checkBoxFreeze.Name = "checkBoxFreeze";
            this.checkBoxFreeze.Size = new System.Drawing.Size(64, 16);
            this.checkBoxFreeze.TabIndex = 9;
            this.checkBoxFreeze.Text = "Freezee";
            this.checkBoxFreeze.UseVisualStyleBackColor = true;
            // 
            // listBoxPoint
            // 
            this.listBoxPoint.FormattingEnabled = true;
            this.listBoxPoint.ItemHeight = 12;
            this.listBoxPoint.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right"});
            this.listBoxPoint.Location = new System.Drawing.Point(217, 44);
            this.listBoxPoint.Name = "listBoxPoint";
            this.listBoxPoint.Size = new System.Drawing.Size(120, 52);
            this.listBoxPoint.TabIndex = 10;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(134, 66);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 21);
            this.btnStatus.TabIndex = 11;
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // panelSetKey
            // 
            this.panelSetKey.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelSetKey.Controls.Add(this.lblHoykeySet);
            this.panelSetKey.Controls.Add(this.btnSelectedKey);
            this.panelSetKey.Controls.Add(this.textBox1);
            this.panelSetKey.Location = new System.Drawing.Point(59, 117);
            this.panelSetKey.Name = "panelSetKey";
            this.panelSetKey.Size = new System.Drawing.Size(200, 81);
            this.panelSetKey.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSelectedKey
            // 
            this.btnSelectedKey.Location = new System.Drawing.Point(3, 55);
            this.btnSelectedKey.Name = "btnSelectedKey";
            this.btnSelectedKey.Size = new System.Drawing.Size(75, 23);
            this.btnSelectedKey.TabIndex = 1;
            this.btnSelectedKey.Text = "btnSelectedKey";
            this.btnSelectedKey.UseVisualStyleBackColor = true;
            // 
            // lblHoykeySet
            // 
            this.lblHoykeySet.AutoSize = true;
            this.lblHoykeySet.Location = new System.Drawing.Point(3, 25);
            this.lblHoykeySet.Name = "lblHoykeySet";
            this.lblHoykeySet.Size = new System.Drawing.Size(72, 12);
            this.lblHoykeySet.TabIndex = 2;
            this.lblHoykeySet.Text = "lblHoykeySet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 286);
            this.Controls.Add(this.panelSetKey);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.listBoxPoint);
            this.Controls.Add(this.checkBoxFreeze);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCntPoint);
            this.Controls.Add(this.TimeClickAT);
            this.Controls.Add(this.SetHotKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PositionVal);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoClickByTMT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panelSetKey.ResumeLayout(false);
            this.panelSetKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PositionVal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button SetHotKey;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox TimeClickAT;
        private System.Windows.Forms.TextBox txtCntPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxFreeze;
        private System.Windows.Forms.ListBox listBoxPoint;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Panel panelSetKey;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelectedKey;
        private System.Windows.Forms.Label lblHoykeySet;
    }
}

