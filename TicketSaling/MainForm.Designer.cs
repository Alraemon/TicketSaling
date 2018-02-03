namespace TicketSaling
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lvComplex = new System.Windows.Forms.ListView();
            this.gbLvName = new System.Windows.Forms.GroupBox();
            this.btnAccList = new System.Windows.Forms.Button();
            this.btnRoleList = new System.Windows.Forms.Button();
            this.btnRightList = new System.Windows.Forms.Button();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.gbCar = new System.Windows.Forms.GroupBox();
            this.btnCarList = new System.Windows.Forms.Button();
            this.btnTimeList = new System.Windows.Forms.Button();
            this.btnTrainList = new System.Windows.Forms.Button();
            this.权限系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车次信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车次管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车组方式管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车厢型号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.票务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.售出票查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLvName.SuspendLayout();
            this.gbAcc.SuspendLayout();
            this.gbCar.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvComplex
            // 
            this.lvComplex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvComplex.Location = new System.Drawing.Point(3, 17);
            this.lvComplex.Name = "lvComplex";
            this.lvComplex.Size = new System.Drawing.Size(658, 219);
            this.lvComplex.TabIndex = 1;
            this.lvComplex.UseCompatibleStateImageBehavior = false;
            this.lvComplex.View = System.Windows.Forms.View.Details;
            // 
            // gbLvName
            // 
            this.gbLvName.Controls.Add(this.lvComplex);
            this.gbLvName.Location = new System.Drawing.Point(12, 28);
            this.gbLvName.Name = "gbLvName";
            this.gbLvName.Size = new System.Drawing.Size(664, 239);
            this.gbLvName.TabIndex = 2;
            this.gbLvName.TabStop = false;
            this.gbLvName.Text = "信息视图";
            // 
            // btnAccList
            // 
            this.btnAccList.Location = new System.Drawing.Point(6, 24);
            this.btnAccList.Name = "btnAccList";
            this.btnAccList.Size = new System.Drawing.Size(95, 32);
            this.btnAccList.TabIndex = 3;
            this.btnAccList.Text = "账号列表";
            this.btnAccList.UseVisualStyleBackColor = true;
            this.btnAccList.Click += new System.EventHandler(this.btnAccList_Click);
            // 
            // btnRoleList
            // 
            this.btnRoleList.Location = new System.Drawing.Point(107, 24);
            this.btnRoleList.Name = "btnRoleList";
            this.btnRoleList.Size = new System.Drawing.Size(95, 32);
            this.btnRoleList.TabIndex = 4;
            this.btnRoleList.Text = "角色列表";
            this.btnRoleList.UseVisualStyleBackColor = true;
            this.btnRoleList.Click += new System.EventHandler(this.btnRoleList_Click);
            // 
            // btnRightList
            // 
            this.btnRightList.Location = new System.Drawing.Point(208, 24);
            this.btnRightList.Name = "btnRightList";
            this.btnRightList.Size = new System.Drawing.Size(95, 32);
            this.btnRightList.TabIndex = 5;
            this.btnRightList.Text = "权限列表";
            this.btnRightList.UseVisualStyleBackColor = true;
            this.btnRightList.Click += new System.EventHandler(this.btnRightList_Click);
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.btnAccList);
            this.gbAcc.Controls.Add(this.btnRightList);
            this.gbAcc.Controls.Add(this.btnRoleList);
            this.gbAcc.Location = new System.Drawing.Point(15, 279);
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.Size = new System.Drawing.Size(309, 77);
            this.gbAcc.TabIndex = 7;
            this.gbAcc.TabStop = false;
            this.gbAcc.Text = "账号信息";
            // 
            // gbCar
            // 
            this.gbCar.Controls.Add(this.btnCarList);
            this.gbCar.Controls.Add(this.btnTimeList);
            this.gbCar.Controls.Add(this.btnTrainList);
            this.gbCar.Location = new System.Drawing.Point(364, 279);
            this.gbCar.Name = "gbCar";
            this.gbCar.Size = new System.Drawing.Size(309, 77);
            this.gbCar.TabIndex = 8;
            this.gbCar.TabStop = false;
            this.gbCar.Text = "车辆信息";
            // 
            // btnCarList
            // 
            this.btnCarList.Enabled = false;
            this.btnCarList.Location = new System.Drawing.Point(6, 24);
            this.btnCarList.Name = "btnCarList";
            this.btnCarList.Size = new System.Drawing.Size(95, 32);
            this.btnCarList.TabIndex = 3;
            this.btnCarList.Text = "车厢列表";
            this.btnCarList.UseVisualStyleBackColor = true;
            this.btnCarList.Click += new System.EventHandler(this.btnCarList_Click);
            // 
            // btnTimeList
            // 
            this.btnTimeList.Enabled = false;
            this.btnTimeList.Location = new System.Drawing.Point(208, 24);
            this.btnTimeList.Name = "btnTimeList";
            this.btnTimeList.Size = new System.Drawing.Size(95, 32);
            this.btnTimeList.TabIndex = 5;
            this.btnTimeList.Text = "车次列表";
            this.btnTimeList.UseVisualStyleBackColor = true;
            this.btnTimeList.Click += new System.EventHandler(this.btnTimeList_Click);
            // 
            // btnTrainList
            // 
            this.btnTrainList.Enabled = false;
            this.btnTrainList.Location = new System.Drawing.Point(107, 24);
            this.btnTrainList.Name = "btnTrainList";
            this.btnTrainList.Size = new System.Drawing.Size(95, 32);
            this.btnTrainList.TabIndex = 4;
            this.btnTrainList.Text = "车组列表";
            this.btnTrainList.UseVisualStyleBackColor = true;
            this.btnTrainList.Click += new System.EventHandler(this.btnTrainList_Click);
            // 
            // 权限系统ToolStripMenuItem
            // 
            this.权限系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建账号ToolStripMenuItem,
            this.删除账号ToolStripMenuItem,
            this.权限分配ToolStripMenuItem});
            this.权限系统ToolStripMenuItem.Name = "权限系统ToolStripMenuItem";
            this.权限系统ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.权限系统ToolStripMenuItem.Text = "权限管理";
            this.权限系统ToolStripMenuItem.Visible = false;
            // 
            // 新建账号ToolStripMenuItem
            // 
            this.新建账号ToolStripMenuItem.Name = "新建账号ToolStripMenuItem";
            this.新建账号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建账号ToolStripMenuItem.Text = "新建账号";
            this.新建账号ToolStripMenuItem.Click += new System.EventHandler(this.新建账号ToolStripMenuItem_Click);
            // 
            // 删除账号ToolStripMenuItem
            // 
            this.删除账号ToolStripMenuItem.Name = "删除账号ToolStripMenuItem";
            this.删除账号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除账号ToolStripMenuItem.Text = "删除账号";
            this.删除账号ToolStripMenuItem.Click += new System.EventHandler(this.删除账号ToolStripMenuItem_Click);
            // 
            // 权限分配ToolStripMenuItem
            // 
            this.权限分配ToolStripMenuItem.Name = "权限分配ToolStripMenuItem";
            this.权限分配ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.权限分配ToolStripMenuItem.Text = "权限分配";
            this.权限分配ToolStripMenuItem.Click += new System.EventHandler(this.权限分配ToolStripMenuItem_Click);
            // 
            // 车次信息管理ToolStripMenuItem
            // 
            this.车次信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车次管理ToolStripMenuItem,
            this.车组方式管理ToolStripMenuItem,
            this.车厢型号管理ToolStripMenuItem});
            this.车次信息管理ToolStripMenuItem.Name = "车次信息管理ToolStripMenuItem";
            this.车次信息管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.车次信息管理ToolStripMenuItem.Text = "车次信息管理";
            this.车次信息管理ToolStripMenuItem.Visible = false;
            // 
            // 车次管理ToolStripMenuItem
            // 
            this.车次管理ToolStripMenuItem.Name = "车次管理ToolStripMenuItem";
            this.车次管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.车次管理ToolStripMenuItem.Text = "车次管理";
            this.车次管理ToolStripMenuItem.Visible = false;
            this.车次管理ToolStripMenuItem.Click += new System.EventHandler(this.车次管理ToolStripMenuItem_Click);
            // 
            // 车组方式管理ToolStripMenuItem
            // 
            this.车组方式管理ToolStripMenuItem.Name = "车组方式管理ToolStripMenuItem";
            this.车组方式管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.车组方式管理ToolStripMenuItem.Text = "车组方式管理";
            this.车组方式管理ToolStripMenuItem.Visible = false;
            this.车组方式管理ToolStripMenuItem.Click += new System.EventHandler(this.车组方式管理ToolStripMenuItem_Click);
            // 
            // 车厢型号管理ToolStripMenuItem
            // 
            this.车厢型号管理ToolStripMenuItem.Name = "车厢型号管理ToolStripMenuItem";
            this.车厢型号管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.车厢型号管理ToolStripMenuItem.Text = "车厢型号管理";
            this.车厢型号管理ToolStripMenuItem.Visible = false;
            this.车厢型号管理ToolStripMenuItem.Click += new System.EventHandler(this.车厢型号管理ToolStripMenuItem_Click);
            // 
            // 票务管理ToolStripMenuItem
            // 
            this.票务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.购票ToolStripMenuItem,
            this.退票ToolStripMenuItem,
            this.售出票查询ToolStripMenuItem});
            this.票务管理ToolStripMenuItem.Name = "票务管理ToolStripMenuItem";
            this.票务管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.票务管理ToolStripMenuItem.Text = "票务管理";
            this.票务管理ToolStripMenuItem.Visible = false;
            // 
            // 购票ToolStripMenuItem
            // 
            this.购票ToolStripMenuItem.Name = "购票ToolStripMenuItem";
            this.购票ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.购票ToolStripMenuItem.Text = "购票";
            this.购票ToolStripMenuItem.Visible = false;
            this.购票ToolStripMenuItem.Click += new System.EventHandler(this.购票ToolStripMenuItem1_Click);
            // 
            // 退票ToolStripMenuItem
            // 
            this.退票ToolStripMenuItem.Name = "退票ToolStripMenuItem";
            this.退票ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退票ToolStripMenuItem.Text = "退票";
            this.退票ToolStripMenuItem.Visible = false;
            this.退票ToolStripMenuItem.Click += new System.EventHandler(this.退票ToolStripMenuItem_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限系统ToolStripMenuItem,
            this.车次信息管理ToolStripMenuItem,
            this.票务管理ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(688, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // 售出票查询ToolStripMenuItem
            // 
            this.售出票查询ToolStripMenuItem.Name = "售出票查询ToolStripMenuItem";
            this.售出票查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.售出票查询ToolStripMenuItem.Text = "售出票查询";
            this.售出票查询ToolStripMenuItem.Visible = false;
            this.售出票查询ToolStripMenuItem.Click += new System.EventHandler(this.售出票查询ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.gbCar);
            this.Controls.Add(this.gbAcc);
            this.Controls.Add(this.gbLvName);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "票务系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbLvName.ResumeLayout(false);
            this.gbAcc.ResumeLayout(false);
            this.gbCar.ResumeLayout(false);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvComplex;
        private System.Windows.Forms.GroupBox gbLvName;
        private System.Windows.Forms.Button btnAccList;
        private System.Windows.Forms.Button btnRoleList;
        private System.Windows.Forms.Button btnRightList;
        private System.Windows.Forms.GroupBox gbAcc;
        private System.Windows.Forms.GroupBox gbCar;
        private System.Windows.Forms.Button btnCarList;
        private System.Windows.Forms.Button btnTimeList;
        private System.Windows.Forms.Button btnTrainList;
        private System.Windows.Forms.ToolStripMenuItem 权限系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限分配ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车次信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车次管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车组方式管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车厢型号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 票务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购票ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退票ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 售出票查询ToolStripMenuItem;
    }
}

