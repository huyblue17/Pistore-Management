namespace PiStoreManagement.Control
{
    partial class OrderControl
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
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbClient = new System.Windows.Forms.RichTextBox();
            this.rtbEmployee = new System.Windows.Forms.RichTextBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOSearch = new System.Windows.Forms.TextBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnODelete = new System.Windows.Forms.Button();
            this.btnOEdit = new System.Windows.Forms.Button();
            this.btnOCancel = new System.Windows.Forms.Button();
            this.btnOSave = new System.Windows.Forms.Button();
            this.btnOAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dtpOrder);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtbClient);
            this.panel1.Controls.Add(this.rtbEmployee);
            this.panel1.Controls.Add(this.cbClient);
            this.panel1.Controls.Add(this.cbEmployee);
            this.panel1.Location = new System.Drawing.Point(42, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 168);
            this.panel1.TabIndex = 0;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrder.Location = new System.Drawing.Point(1057, 85);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(120, 22);
            this.dtpOrder.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(951, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Order date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(498, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Order management";
            // 
            // rtbClient
            // 
            this.rtbClient.Location = new System.Drawing.Point(719, 82);
            this.rtbClient.Name = "rtbClient";
            this.rtbClient.Size = new System.Drawing.Size(215, 25);
            this.rtbClient.TabIndex = 3;
            this.rtbClient.Text = "";
            // 
            // rtbEmployee
            // 
            this.rtbEmployee.Location = new System.Drawing.Point(272, 83);
            this.rtbEmployee.Name = "rtbEmployee";
            this.rtbEmployee.Size = new System.Drawing.Size(215, 24);
            this.rtbEmployee.TabIndex = 2;
            this.rtbEmployee.Text = "";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(560, 82);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(153, 24);
            this.cbClient.TabIndex = 1;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(117, 83);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(149, 24);
            this.cbEmployee.TabIndex = 0;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnOSearch);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtOSearch);
            this.panel2.Controls.Add(this.dgvOrder);
            this.panel2.Location = new System.Drawing.Point(42, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 430);
            this.panel2.TabIndex = 1;
            // 
            // btnOSearch
            // 
            this.btnOSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnOSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOSearch.Location = new System.Drawing.Point(645, 25);
            this.btnOSearch.Name = "btnOSearch";
            this.btnOSearch.Size = new System.Drawing.Size(123, 33);
            this.btnOSearch.TabIndex = 29;
            this.btnOSearch.Text = "Search";
            this.btnOSearch.UseVisualStyleBackColor = false;
            this.btnOSearch.Click += new System.EventHandler(this.btnOSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(205, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Search:";
            // 
            // txtOSearch
            // 
            this.txtOSearch.Location = new System.Drawing.Point(277, 28);
            this.txtOSearch.Name = "txtOSearch";
            this.txtOSearch.Size = new System.Drawing.Size(344, 22);
            this.txtOSearch.TabIndex = 27;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(46, 74);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(878, 323);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnODelete);
            this.panel3.Controls.Add(this.btnOEdit);
            this.panel3.Controls.Add(this.btnOCancel);
            this.panel3.Controls.Add(this.btnOSave);
            this.panel3.Controls.Add(this.btnOAdd);
            this.panel3.Location = new System.Drawing.Point(1039, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 430);
            this.panel3.TabIndex = 2;
            // 
            // btnODelete
            // 
            this.btnODelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnODelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnODelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnODelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnODelete.Location = new System.Drawing.Point(43, 203);
            this.btnODelete.Name = "btnODelete";
            this.btnODelete.Size = new System.Drawing.Size(123, 33);
            this.btnODelete.TabIndex = 37;
            this.btnODelete.Text = "Delete";
            this.btnODelete.UseVisualStyleBackColor = false;
            this.btnODelete.Click += new System.EventHandler(this.btnODelete_Click);
            // 
            // btnOEdit
            // 
            this.btnOEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnOEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOEdit.Location = new System.Drawing.Point(43, 129);
            this.btnOEdit.Name = "btnOEdit";
            this.btnOEdit.Size = new System.Drawing.Size(123, 33);
            this.btnOEdit.TabIndex = 36;
            this.btnOEdit.Text = "Edit";
            this.btnOEdit.UseVisualStyleBackColor = false;
            this.btnOEdit.Click += new System.EventHandler(this.btnOEdit_Click);
            // 
            // btnOCancel
            // 
            this.btnOCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnOCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOCancel.Location = new System.Drawing.Point(43, 345);
            this.btnOCancel.Name = "btnOCancel";
            this.btnOCancel.Size = new System.Drawing.Size(123, 33);
            this.btnOCancel.TabIndex = 35;
            this.btnOCancel.Text = "Cancel";
            this.btnOCancel.UseVisualStyleBackColor = false;
            this.btnOCancel.Click += new System.EventHandler(this.btnOCancel_Click);
            // 
            // btnOSave
            // 
            this.btnOSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnOSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOSave.Location = new System.Drawing.Point(43, 273);
            this.btnOSave.Name = "btnOSave";
            this.btnOSave.Size = new System.Drawing.Size(123, 33);
            this.btnOSave.TabIndex = 34;
            this.btnOSave.Text = "Save";
            this.btnOSave.UseVisualStyleBackColor = false;
            this.btnOSave.Click += new System.EventHandler(this.btnOSave_Click);
            // 
            // btnOAdd
            // 
            this.btnOAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnOAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOAdd.Location = new System.Drawing.Point(43, 54);
            this.btnOAdd.Name = "btnOAdd";
            this.btnOAdd.Size = new System.Drawing.Size(123, 33);
            this.btnOAdd.TabIndex = 33;
            this.btnOAdd.Text = "Add";
            this.btnOAdd.UseVisualStyleBackColor = false;
            this.btnOAdd.Click += new System.EventHandler(this.btnOAdd_Click);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "OrderControl";
            this.Size = new System.Drawing.Size(1266, 686);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.RichTextBox rtbClient;
        private System.Windows.Forms.RichTextBox rtbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOEdit;
        private System.Windows.Forms.Button btnOCancel;
        private System.Windows.Forms.Button btnOSave;
        private System.Windows.Forms.Button btnOAdd;
        private System.Windows.Forms.Button btnODelete;
        private System.Windows.Forms.Button btnOSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtOSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpOrder;
    }
}
