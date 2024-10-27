namespace PiStoreManagement.Control
{
    partial class EmployeeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEExport = new System.Windows.Forms.Button();
            this.btnESearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEEdit = new System.Windows.Forms.Button();
            this.btnECancel = new System.Windows.Forms.Button();
            this.btnESave = new System.Windows.Forms.Button();
            this.btnEDelete = new System.Windows.Forms.Button();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpHiredate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEname = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEaddress = new System.Windows.Forms.TextBox();
            this.txtEPhone = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnEExport);
            this.panel1.Controls.Add(this.btnESearch);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvEmployee);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 379);
            this.panel1.TabIndex = 0;
            // 
            // btnEExport
            // 
            this.btnEExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEExport.Location = new System.Drawing.Point(943, 46);
            this.btnEExport.Name = "btnEExport";
            this.btnEExport.Size = new System.Drawing.Size(123, 33);
            this.btnEExport.TabIndex = 23;
            this.btnEExport.Text = "Export CSV";
            this.btnEExport.UseVisualStyleBackColor = false;
            this.btnEExport.Click += new System.EventHandler(this.btnEExport_Click);
            // 
            // btnESearch
            // 
            this.btnESearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnESearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnESearch.Location = new System.Drawing.Point(786, 46);
            this.btnESearch.Name = "btnESearch";
            this.btnESearch.Size = new System.Drawing.Size(123, 33);
            this.btnESearch.TabIndex = 22;
            this.btnESearch.Text = "Search";
            this.btnESearch.UseVisualStyleBackColor = false;
            this.btnESearch.Click += new System.EventHandler(this.btnESearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(312, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(394, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(344, 22);
            this.txtSearch.TabIndex = 14;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(30, 88);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1136, 267);
            this.dgvEmployee.TabIndex = 10;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee management";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnEEdit);
            this.panel2.Controls.Add(this.btnECancel);
            this.panel2.Controls.Add(this.btnESave);
            this.panel2.Controls.Add(this.btnEDelete);
            this.panel2.Controls.Add(this.btnEAdd);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtpHiredate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtEname);
            this.panel2.Controls.Add(this.txtSalary);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtEaddress);
            this.panel2.Controls.Add(this.txtEPhone);
            this.panel2.Controls.Add(this.txtEID);
            this.panel2.Location = new System.Drawing.Point(53, 419);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1192, 254);
            this.panel2.TabIndex = 1;
            // 
            // btnEEdit
            // 
            this.btnEEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEEdit.Location = new System.Drawing.Point(804, 110);
            this.btnEEdit.Name = "btnEEdit";
            this.btnEEdit.Size = new System.Drawing.Size(123, 33);
            this.btnEEdit.TabIndex = 27;
            this.btnEEdit.Text = "Edit";
            this.btnEEdit.UseVisualStyleBackColor = false;
            this.btnEEdit.Click += new System.EventHandler(this.btnEEdit_Click);
            // 
            // btnECancel
            // 
            this.btnECancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnECancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnECancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnECancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnECancel.Location = new System.Drawing.Point(804, 153);
            this.btnECancel.Name = "btnECancel";
            this.btnECancel.Size = new System.Drawing.Size(123, 33);
            this.btnECancel.TabIndex = 26;
            this.btnECancel.Text = "Cancel";
            this.btnECancel.UseVisualStyleBackColor = false;
            this.btnECancel.Click += new System.EventHandler(this.btnECancel_Click);
            // 
            // btnESave
            // 
            this.btnESave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnESave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnESave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnESave.Location = new System.Drawing.Point(804, 193);
            this.btnESave.Name = "btnESave";
            this.btnESave.Size = new System.Drawing.Size(123, 33);
            this.btnESave.TabIndex = 25;
            this.btnESave.Text = "Save";
            this.btnESave.UseVisualStyleBackColor = false;
            this.btnESave.Click += new System.EventHandler(this.btnESave_Click);
            // 
            // btnEDelete
            // 
            this.btnEDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEDelete.Location = new System.Drawing.Point(804, 65);
            this.btnEDelete.Name = "btnEDelete";
            this.btnEDelete.Size = new System.Drawing.Size(123, 33);
            this.btnEDelete.TabIndex = 24;
            this.btnEDelete.Text = "Delete";
            this.btnEDelete.UseVisualStyleBackColor = false;
            this.btnEDelete.Click += new System.EventHandler(this.btnEDelete_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnEAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEAdd.Location = new System.Drawing.Point(804, 23);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(123, 33);
            this.btnEAdd.TabIndex = 23;
            this.btnEAdd.Text = "Add";
            this.btnEAdd.UseVisualStyleBackColor = false;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(568, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salary:";
            // 
            // dtpHiredate
            // 
            this.dtpHiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiredate.Location = new System.Drawing.Point(399, 193);
            this.dtpHiredate.Name = "dtpHiredate";
            this.dtpHiredate.Size = new System.Drawing.Size(109, 22);
            this.dtpHiredate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(312, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hire date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(312, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(312, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(312, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(497, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(312, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID:";
            // 
            // txtEname
            // 
            this.txtEname.Location = new System.Drawing.Point(572, 37);
            this.txtEname.Name = "txtEname";
            this.txtEname.Size = new System.Drawing.Size(166, 22);
            this.txtEname.TabIndex = 5;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(638, 193);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(394, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(344, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtEaddress
            // 
            this.txtEaddress.Location = new System.Drawing.Point(394, 153);
            this.txtEaddress.Name = "txtEaddress";
            this.txtEaddress.Size = new System.Drawing.Size(344, 22);
            this.txtEaddress.TabIndex = 2;
            // 
            // txtEPhone
            // 
            this.txtEPhone.Location = new System.Drawing.Point(394, 116);
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.Size = new System.Drawing.Size(163, 22);
            this.txtEPhone.TabIndex = 1;
            // 
            // txtEID
            // 
            this.txtEID.Location = new System.Drawing.Point(365, 37);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(100, 22);
            this.txtEID.TabIndex = 0;
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(1266, 686);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEname;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEaddress;
        private System.Windows.Forms.TextBox txtEPhone;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpHiredate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnESearch;
        private System.Windows.Forms.Button btnEDelete;
        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.Button btnECancel;
        private System.Windows.Forms.Button btnESave;
        private System.Windows.Forms.Button btnEExport;
        private System.Windows.Forms.Button btnEEdit;
    }
}
