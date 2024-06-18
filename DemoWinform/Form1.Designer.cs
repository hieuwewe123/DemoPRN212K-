namespace DemoWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvEmployees = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbEmpId = new TextBox();
            tbFirstName = new TextBox();
            tbLastname = new TextBox();
            tbAddress = new TextBox();
            btRefresh = new Button();
            btAdd = new Button();
            btUpdate = new Button();
            btDelete = new Button();
            dtpBirthDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(815, 59);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 78);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(618, 451);
            dgvEmployees.TabIndex = 1;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 126);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "EmployeeId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 185);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 3;
            label3.Text = "FirstName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(670, 254);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(670, 327);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(670, 393);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 6;
            label6.Text = "BirthDate";
            // 
            // tbEmpId
            // 
            tbEmpId.Location = new Point(785, 119);
            tbEmpId.Name = "tbEmpId";
            tbEmpId.ReadOnly = true;
            tbEmpId.Size = new Size(269, 27);
            tbEmpId.TabIndex = 7;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(785, 178);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(269, 27);
            tbFirstName.TabIndex = 8;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(785, 247);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(269, 27);
            tbLastname.TabIndex = 9;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(785, 324);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(269, 27);
            tbAddress.TabIndex = 10;
            // 
            // btRefresh
            // 
            btRefresh.Location = new Point(664, 465);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(94, 29);
            btRefresh.TabIndex = 12;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = true;
            btRefresh.Click += btRefresh_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(774, 465);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 13;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(888, 465);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(94, 29);
            btUpdate.TabIndex = 14;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(1002, 465);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 15;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(785, 386);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(269, 27);
            dtpBirthDate.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 660);
            Controls.Add(dtpBirthDate);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(btAdd);
            Controls.Add(btRefresh);
            Controls.Add(tbAddress);
            Controls.Add(tbLastname);
            Controls.Add(tbFirstName);
            Controls.Add(tbEmpId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvEmployees);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmployees;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbEmpId;
        private TextBox tbFirstName;
        private TextBox tbLastname;
        private TextBox tbAddress;
        private Button btRefresh;
        private Button btAdd;
        private Button btUpdate;
        private Button btDelete;
        private DateTimePicker dtpBirthDate;
    }
}
