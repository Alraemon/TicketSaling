namespace TicketSaling.TicketManagement
{
    partial class RemainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTimeId = new System.Windows.Forms.RadioButton();
            this.rbPassId = new System.Windows.Forms.RadioButton();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvTicketInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSerach = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPassId);
            this.groupBox1.Controls.Add(this.rbTimeId);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择查询方式";
            // 
            // rbTimeId
            // 
            this.rbTimeId.AutoSize = true;
            this.rbTimeId.Location = new System.Drawing.Point(18, 20);
            this.rbTimeId.Name = "rbTimeId";
            this.rbTimeId.Size = new System.Drawing.Size(47, 16);
            this.rbTimeId.TabIndex = 0;
            this.rbTimeId.TabStop = true;
            this.rbTimeId.Text = "车次";
            this.rbTimeId.UseVisualStyleBackColor = true;
            // 
            // rbPassId
            // 
            this.rbPassId.AutoSize = true;
            this.rbPassId.Location = new System.Drawing.Point(83, 20);
            this.rbPassId.Name = "rbPassId";
            this.rbPassId.Size = new System.Drawing.Size(95, 16);
            this.rbPassId.TabIndex = 1;
            this.rbPassId.TabStop = true;
            this.rbPassId.Text = "乘客证件号码";
            this.rbPassId.UseVisualStyleBackColor = true;
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(6, 20);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(164, 21);
            this.tbInfo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbInfo);
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 51);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息填写";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvTicketInfo);
            this.groupBox3.Location = new System.Drawing.Point(12, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车票信息";
            // 
            // lvTicketInfo
            // 
            this.lvTicketInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvTicketInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTicketInfo.Location = new System.Drawing.Point(3, 17);
            this.lvTicketInfo.Name = "lvTicketInfo";
            this.lvTicketInfo.Size = new System.Drawing.Size(371, 135);
            this.lvTicketInfo.TabIndex = 0;
            this.lvTicketInfo.UseCompatibleStateImageBehavior = false;
            this.lvTicketInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "车票号码";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "乘车人";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "证件号码";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "车次";
            this.columnHeader4.Width = 90;
            // 
            // btnSerach
            // 
            this.btnSerach.Location = new System.Drawing.Point(12, 66);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(374, 42);
            this.btnSerach.TabIndex = 4;
            this.btnSerach.Text = "查询";
            this.btnSerach.UseVisualStyleBackColor = true;
            this.btnSerach.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // RemainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 281);
            this.Controls.Add(this.btnSerach);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RemainForm";
            this.Text = "售出票查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPassId;
        private System.Windows.Forms.RadioButton rbTimeId;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvTicketInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSerach;
    }
}