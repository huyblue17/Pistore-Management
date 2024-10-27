namespace PiStoreManagement.Control
{
    partial class ClientControl
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.btnCExport = new System.Windows.Forms.Button();
            this.btnCSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCEdit = new System.Windows.Forms.Button();
            this.btnCCancel = new System.Windows.Forms.Button();
            this.btnCSave = new System.Windows.Forms.Button();
            this.btnCDelete = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnCEdit);
            this.panel1.Controls.Add(this.btnCCancel);
            this.panel1.Controls.Add(this.btnCSave);
            this.panel1.Controls.Add(this.btnCAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCAddress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCID);
            this.panel1.Location = new System.Drawing.Point(51, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 637);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnCExport);
            this.panel2.Controls.Add(this.btnCSearch);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnCDelete);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvClient);
            this.panel2.Location = new System.Drawing.Point(394, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 637);
            this.panel2.TabIndex = 1;
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(18, 13);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.Size = new System.Drawing.Size(810, 317);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(45, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(100, 141);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 22);
            this.txtCID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Client management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(23, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(100, 183);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(201, 22);
            this.txtCName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(32, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mail:";
            // 
            // txtCmail
            // 
            this.txtCmail.Location = new System.Drawing.Point(100, 230);
            this.txtCmail.Name = "txtCmail";
            this.txtCmail.Size = new System.Drawing.Size(201, 22);
            this.txtCmail.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(9, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Address:";
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(100, 326);
            this.txtCAddress.Multiline = true;
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(201, 58);
            this.txtCAddress.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(21, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Phone:";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(100, 275);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(201, 22);
            this.txtCPhone.TabIndex = 20;
            // 
            // btnCExport
            // 
            this.btnCExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCExport.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCExport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCExport.Location = new System.Drawing.Point(496, 452);
            this.btnCExport.Name = "btnCExport";
            this.btnCExport.Size = new System.Drawing.Size(123, 33);
            this.btnCExport.TabIndex = 27;
            this.btnCExport.Text = "Export CSV";
            this.btnCExport.UseVisualStyleBackColor = false;
            this.btnCExport.Click += new System.EventHandler(this.btnCExport_Click);
            // 
            // btnCSearch
            // 
            this.btnCSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSearch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCSearch.Location = new System.Drawing.Point(198, 452);
            this.btnCSearch.Name = "btnCSearch";
            this.btnCSearch.Size = new System.Drawing.Size(123, 33);
            this.btnCSearch.TabIndex = 26;
            this.btnCSearch.Text = "Search";
            this.btnCSearch.UseVisualStyleBackColor = false;
            this.btnCSearch.Click += new System.EventHandler(this.btnCSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(203, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(275, 408);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(344, 22);
            this.txtSearch.TabIndex = 24;
            // 
            // btnCEdit
            // 
            this.btnCEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCEdit.Location = new System.Drawing.Point(178, 428);
            this.btnCEdit.Name = "btnCEdit";
            this.btnCEdit.Size = new System.Drawing.Size(123, 33);
            this.btnCEdit.TabIndex = 32;
            this.btnCEdit.Text = "Edit";
            this.btnCEdit.UseVisualStyleBackColor = false;
            this.btnCEdit.Click += new System.EventHandler(this.btnCEdit_Click);
            // 
            // btnCCancel
            // 
            this.btnCCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCCancel.Location = new System.Drawing.Point(178, 483);
            this.btnCCancel.Name = "btnCCancel";
            this.btnCCancel.Size = new System.Drawing.Size(123, 33);
            this.btnCCancel.TabIndex = 31;
            this.btnCCancel.Text = "Cancel";
            this.btnCCancel.UseVisualStyleBackColor = false;
            this.btnCCancel.Click += new System.EventHandler(this.btnCCancel_Click);
            // 
            // btnCSave
            // 
            this.btnCSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCSave.Location = new System.Drawing.Point(21, 483);
            this.btnCSave.Name = "btnCSave";
            this.btnCSave.Size = new System.Drawing.Size(123, 33);
            this.btnCSave.TabIndex = 30;
            this.btnCSave.Text = "Save";
            this.btnCSave.UseVisualStyleBackColor = false;
            this.btnCSave.Click += new System.EventHandler(this.btnCSave_Click);
            // 
            // btnCDelete
            // 
            this.btnCDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCDelete.Location = new System.Drawing.Point(345, 452);
            this.btnCDelete.Name = "btnCDelete";
            this.btnCDelete.Size = new System.Drawing.Size(123, 33);
            this.btnCDelete.TabIndex = 29;
            this.btnCDelete.Text = "Delete";
            this.btnCDelete.UseVisualStyleBackColor = false;
            this.btnCDelete.Click += new System.EventHandler(this.btnCDelete_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnCAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCAdd.Location = new System.Drawing.Point(21, 428);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(123, 33);
            this.btnCAdd.TabIndex = 28;
            this.btnCAdd.Text = "Add";
            this.btnCAdd.UseVisualStyleBackColor = false;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(1266, 686);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Button btnCExport;
        private System.Windows.Forms.Button btnCSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCEdit;
        private System.Windows.Forms.Button btnCCancel;
        private System.Windows.Forms.Button btnCSave;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.Button btnCDelete;
    }
}
