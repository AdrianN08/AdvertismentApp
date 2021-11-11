
namespace AdvertisementApp
{
    partial class FrmUserOnline
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblUserId = new System.Windows.Forms.Label();
            this.grpAdverts = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxDateIn = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.grpUserAdverts = new System.Windows.Forms.GroupBox();
            this.grpAdverts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpUserAdverts.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(15, 25);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(66, 13);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "User Name: ";
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(227, 16);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(40, 13);
            this.lnkLogout.TabIndex = 8;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(15, 52);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(49, 13);
            this.lblUserId.TabIndex = 2;
            this.lblUserId.Text = "User ID: ";
            // 
            // grpAdverts
            // 
            this.grpAdverts.Controls.Add(this.label6);
            this.grpAdverts.Controls.Add(this.btnClear);
            this.grpAdverts.Controls.Add(this.btnDelete);
            this.grpAdverts.Controls.Add(this.btnUpdate);
            this.grpAdverts.Controls.Add(this.btnAdd);
            this.grpAdverts.Controls.Add(this.tbxDescription);
            this.grpAdverts.Controls.Add(this.lnkLogout);
            this.grpAdverts.Controls.Add(this.lblUserId);
            this.grpAdverts.Controls.Add(this.tbxDateIn);
            this.grpAdverts.Controls.Add(this.tbxPrice);
            this.grpAdverts.Controls.Add(this.lblUserName);
            this.grpAdverts.Controls.Add(this.tbxTitle);
            this.grpAdverts.Controls.Add(this.cbxCategory);
            this.grpAdverts.Controls.Add(this.label5);
            this.grpAdverts.Controls.Add(this.label4);
            this.grpAdverts.Controls.Add(this.label3);
            this.grpAdverts.Controls.Add(this.label2);
            this.grpAdverts.Controls.Add(this.label1);
            this.grpAdverts.Location = new System.Drawing.Point(12, 12);
            this.grpAdverts.Name = "grpAdverts";
            this.grpAdverts.Size = new System.Drawing.Size(273, 328);
            this.grpAdverts.TabIndex = 3;
            this.grpAdverts.TabStop = false;
            this.grpAdverts.Text = "Advert";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(yyyy-mm-dd)";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(87, 287);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(170, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(87, 147);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(158, 20);
            this.tbxDescription.TabIndex = 1;
            // 
            // tbxDateIn
            // 
            this.tbxDateIn.Location = new System.Drawing.Point(87, 217);
            this.tbxDateIn.Name = "tbxDateIn";
            this.tbxDateIn.Size = new System.Drawing.Size(158, 20);
            this.tbxDateIn.TabIndex = 3;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(87, 182);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(158, 20);
            this.tbxPrice.TabIndex = 2;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(87, 112);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(158, 20);
            this.tbxTitle.TabIndex = 0;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(87, 78);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(158, 21);
            this.cbxCategory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publish date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 16);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(506, 308);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // grpUserAdverts
            // 
            this.grpUserAdverts.Controls.Add(this.dataGridView);
            this.grpUserAdverts.Location = new System.Drawing.Point(286, 13);
            this.grpUserAdverts.Name = "grpUserAdverts";
            this.grpUserAdverts.Size = new System.Drawing.Size(512, 327);
            this.grpUserAdverts.TabIndex = 5;
            this.grpUserAdverts.TabStop = false;
            this.grpUserAdverts.Text = "User Adverts";
            // 
            // FrmUserOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 354);
            this.Controls.Add(this.grpUserAdverts);
            this.Controls.Add(this.grpAdverts);
            this.Name = "FrmUserOnline";
            this.Text = "FrmUserOnline";
            this.Load += new System.EventHandler(this.FrmUserOnline_Load);
            this.grpAdverts.ResumeLayout(false);
            this.grpAdverts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpUserAdverts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.GroupBox grpAdverts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxDateIn;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox grpUserAdverts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
    }
}