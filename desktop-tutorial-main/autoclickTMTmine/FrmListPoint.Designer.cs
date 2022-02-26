
namespace autoclickTMTmine
{
    partial class FrmListPoint
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckSlt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TypeVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SltType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowPos = new System.Windows.Forms.Button();
            this.MouseOutSide1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDp,
            this.Xp,
            this.Yp,
            this.Typep,
            this.CheckSlt,
            this.TypeVal,
            this.SltType,
            this.btnEdit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(613, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // IDp
            // 
            this.IDp.HeaderText = "Id";
            this.IDp.Name = "IDp";
            this.IDp.Visible = false;
            // 
            // Xp
            // 
            this.Xp.HeaderText = "X";
            this.Xp.Name = "Xp";
            // 
            // Yp
            // 
            this.Yp.HeaderText = "Y";
            this.Yp.Name = "Yp";
            // 
            // Typep
            // 
            this.Typep.HeaderText = "Type";
            this.Typep.Name = "Typep";
            // 
            // CheckSlt
            // 
            this.CheckSlt.HeaderText = "Select";
            this.CheckSlt.Name = "CheckSlt";
            // 
            // TypeVal
            // 
            this.TypeVal.HeaderText = "Type Value";
            this.TypeVal.Name = "TypeVal";
            this.TypeVal.Visible = false;
            // 
            // SltType
            // 
            this.SltType.HeaderText = "Change Type";
            this.SltType.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.SltType.Name = "SltType";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Edit";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(634, 31);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(96, 21);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy To Last";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(655, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowPos
            // 
            this.btnShowPos.Location = new System.Drawing.Point(634, 58);
            this.btnShowPos.Name = "btnShowPos";
            this.btnShowPos.Size = new System.Drawing.Size(96, 21);
            this.btnShowPos.TabIndex = 3;
            this.btnShowPos.Text = "Show Position";
            this.btnShowPos.UseVisualStyleBackColor = true;
            this.btnShowPos.Click += new System.EventHandler(this.btnShowPos_Click);
            // 
            // MouseOutSide1
            // 
            this.MouseOutSide1.Tick += new System.EventHandler(this.MouseOutSide1_Tick);
            // 
            // FrmListPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 300);
            this.Controls.Add(this.btnShowPos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListPoint";
            this.Text = "FrmListPoint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmListPoint_FormClosed);
            this.Load += new System.EventHandler(this.FrmListPoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typep;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckSlt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeVal;
        private System.Windows.Forms.DataGridViewComboBoxColumn SltType;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.Timer MouseOutSide1;
    }
}