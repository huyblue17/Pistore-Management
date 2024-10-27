namespace PiStoreManagement.Control
{
    partial class ItemControl
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
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIDelete = new System.Windows.Forms.Button();
            this.btnIEdit = new System.Windows.Forms.Button();
            this.btnICancel = new System.Windows.Forms.Button();
            this.btnISave = new System.Windows.Forms.Button();
            this.btnIAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgvOrderItem);
            this.panel1.Location = new System.Drawing.Point(641, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 640);
            this.panel1.TabIndex = 0;
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Location = new System.Drawing.Point(25, 26);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowHeadersWidth = 51;
            this.dgvOrderItem.RowTemplate.Height = 24;
            this.dgvOrderItem.Size = new System.Drawing.Size(550, 584);
            this.dgvOrderItem.TabIndex = 0;
            this.dgvOrderItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderItem_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtIID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbProductID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbOrderID);
            this.panel2.Location = new System.Drawing.Point(54, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 425);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(66, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(178, 279);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(67, 22);
            this.txtQuantity.TabIndex = 32;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Location = new System.Drawing.Point(174, 343);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 23);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(66, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 30;
            this.label5.Text = "Total price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(72, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "ID:";
            // 
            // txtIID
            // 
            this.txtIID.Location = new System.Drawing.Point(178, 61);
            this.txtIID.Name = "txtIID";
            this.txtIID.Size = new System.Drawing.Size(113, 22);
            this.txtIID.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Item management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product ID:";
            // 
            // cbProductID
            // 
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(178, 207);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(161, 24);
            this.cbProductID.TabIndex = 17;
            this.cbProductID.SelectedIndexChanged += new System.EventHandler(this.cbProductID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(66, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order ID:";
            // 
            // cbOrderID
            // 
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(178, 129);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(161, 24);
            this.cbOrderID.TabIndex = 15;
            this.cbOrderID.SelectedIndexChanged += new System.EventHandler(this.cbOrderID_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnIDelete);
            this.panel3.Controls.Add(this.btnIEdit);
            this.panel3.Controls.Add(this.btnICancel);
            this.panel3.Controls.Add(this.btnISave);
            this.panel3.Controls.Add(this.btnIAdd);
            this.panel3.Location = new System.Drawing.Point(54, 474);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 189);
            this.panel3.TabIndex = 1;
            // 
            // btnIDelete
            // 
            this.btnIDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnIDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIDelete.Location = new System.Drawing.Point(291, 109);
            this.btnIDelete.Name = "btnIDelete";
            this.btnIDelete.Size = new System.Drawing.Size(123, 33);
            this.btnIDelete.TabIndex = 43;
            this.btnIDelete.Text = "Delete";
            this.btnIDelete.UseVisualStyleBackColor = false;
            this.btnIDelete.Click += new System.EventHandler(this.btnIDelete_Click);
            // 
            // btnIEdit
            // 
            this.btnIEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnIEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIEdit.Location = new System.Drawing.Point(216, 59);
            this.btnIEdit.Name = "btnIEdit";
            this.btnIEdit.Size = new System.Drawing.Size(123, 33);
            this.btnIEdit.TabIndex = 42;
            this.btnIEdit.Text = "Edit";
            this.btnIEdit.UseVisualStyleBackColor = false;
            this.btnIEdit.Click += new System.EventHandler(this.btnIEdit_Click);
            // 
            // btnICancel
            // 
            this.btnICancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnICancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnICancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnICancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnICancel.Location = new System.Drawing.Point(147, 109);
            this.btnICancel.Name = "btnICancel";
            this.btnICancel.Size = new System.Drawing.Size(123, 33);
            this.btnICancel.TabIndex = 41;
            this.btnICancel.Text = "Cancel";
            this.btnICancel.UseVisualStyleBackColor = false;
            this.btnICancel.Click += new System.EventHandler(this.btnICancel_Click);
            // 
            // btnISave
            // 
            this.btnISave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnISave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnISave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnISave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnISave.Location = new System.Drawing.Point(368, 59);
            this.btnISave.Name = "btnISave";
            this.btnISave.Size = new System.Drawing.Size(123, 33);
            this.btnISave.TabIndex = 39;
            this.btnISave.Text = "Save";
            this.btnISave.UseVisualStyleBackColor = false;
            this.btnISave.Click += new System.EventHandler(this.btnISave_Click);
            // 
            // btnIAdd
            // 
            this.btnIAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(42)))), ((int)(((byte)(94)))));
            this.btnIAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIAdd.Location = new System.Drawing.Point(72, 59);
            this.btnIAdd.Name = "btnIAdd";
            this.btnIAdd.Size = new System.Drawing.Size(123, 33);
            this.btnIAdd.TabIndex = 38;
            this.btnIAdd.Text = "Add";
            this.btnIAdd.UseVisualStyleBackColor = false;
            this.btnIAdd.Click += new System.EventHandler(this.btnIAdd_Click);
            // 
            // ItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ItemControl";
            this.Size = new System.Drawing.Size(1266, 686);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOrderID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIID;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnISave;
        private System.Windows.Forms.Button btnIAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnICancel;
        private System.Windows.Forms.Button btnIDelete;
        private System.Windows.Forms.Button btnIEdit;
    }
}
