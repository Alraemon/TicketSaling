namespace TicketSaling.AccountManagement
{
    partial class ManageRoleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRoleName = new System.Windows.Forms.TextBox();
            this.lbRoleRight = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.ttTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRoleName);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色名";
            // 
            // tbRoleName
            // 
            this.tbRoleName.Location = new System.Drawing.Point(20, 20);
            this.tbRoleName.Name = "tbRoleName";
            this.tbRoleName.Size = new System.Drawing.Size(100, 21);
            this.tbRoleName.TabIndex = 0;
            // 
            // lbRoleRight
            // 
            this.lbRoleRight.FormattingEnabled = true;
            this.lbRoleRight.ItemHeight = 12;
            this.lbRoleRight.Location = new System.Drawing.Point(6, 20);
            this.lbRoleRight.Name = "lbRoleRight";
            this.lbRoleRight.ScrollAlwaysVisible = true;
            this.lbRoleRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRoleRight.Size = new System.Drawing.Size(188, 76);
            this.lbRoleRight.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRoleRight);
            this.groupBox2.Location = new System.Drawing.Point(151, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色权限";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "添加角色";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(185, 118);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(166, 38);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除角色";
            this.ttTip.SetToolTip(this.btnDel, "删除角色时只需输入角色名，无需选择权限");
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ttTip
            // 
            this.ttTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ttTip.ForeColor = System.Drawing.Color.Red;
            this.ttTip.Tag = "删除角色时只需填写角色名";
            this.ttTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttTip.ToolTipTitle = "删除提示";
            // 
            // ManageRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 168);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageRoleForm";
            this.Text = "账户角色管理";
            this.Load += new System.EventHandler(this.ManageRoleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRoleName;
        private System.Windows.Forms.ListBox lbRoleRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ToolTip ttTip;
    }
}