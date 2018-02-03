namespace TicketSaling.CarriageManagement
{
    partial class ManageTrainForm
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
            this.tbTrainName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCarNum = new System.Windows.Forms.TextBox();
            this.lbCarTyp = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnDelTrain = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTrainName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车组名称";
            // 
            // tbTrainName
            // 
            this.tbTrainName.Location = new System.Drawing.Point(31, 25);
            this.tbTrainName.Name = "tbTrainName";
            this.tbTrainName.Size = new System.Drawing.Size(100, 21);
            this.tbTrainName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCarNum);
            this.groupBox2.Location = new System.Drawing.Point(206, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "该型车厢节数";
            // 
            // tbCarNum
            // 
            this.tbCarNum.Location = new System.Drawing.Point(31, 25);
            this.tbCarNum.Name = "tbCarNum";
            this.tbCarNum.Size = new System.Drawing.Size(100, 21);
            this.tbCarNum.TabIndex = 0;
            // 
            // lbCarTyp
            // 
            this.lbCarTyp.FormattingEnabled = true;
            this.lbCarTyp.ItemHeight = 12;
            this.lbCarTyp.Location = new System.Drawing.Point(6, 16);
            this.lbCarTyp.Name = "lbCarTyp";
            this.lbCarTyp.ScrollAlwaysVisible = true;
            this.lbCarTyp.Size = new System.Drawing.Size(153, 112);
            this.lbCarTyp.Sorted = true;
            this.lbCarTyp.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCarTyp);
            this.groupBox3.Location = new System.Drawing.Point(12, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 137);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车厢型号";
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Location = new System.Drawing.Point(206, 88);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(165, 37);
            this.btnAddTrain.TabIndex = 4;
            this.btnAddTrain.Text = "编入车组";
            this.toolTip1.SetToolTip(this.btnAddTrain, "将输入节数的该型号车厢加入车组");
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(206, 131);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(165, 37);
            this.btnFinish.TabIndex = 5;
            this.btnFinish.Text = "完成编组";
            this.toolTip1.SetToolTip(this.btnFinish, "完成车组编组，并关闭窗口");
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnDelTrain
            // 
            this.btnDelTrain.Location = new System.Drawing.Point(206, 174);
            this.btnDelTrain.Name = "btnDelTrain";
            this.btnDelTrain.Size = new System.Drawing.Size(165, 37);
            this.btnDelTrain.TabIndex = 6;
            this.btnDelTrain.Text = "删除车组";
            this.toolTip1.SetToolTip(this.btnDelTrain, "只需输入车组名称，将该车组方式删除");
            this.btnDelTrain.UseVisualStyleBackColor = true;
            this.btnDelTrain.Click += new System.EventHandler(this.btnDelTrain_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolTip1.ForeColor = System.Drawing.Color.Gray;
            this.toolTip1.ToolTipTitle = "提示";
            // 
            // ManageTrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 225);
            this.Controls.Add(this.btnDelTrain);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddTrain);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageTrainForm";
            this.Text = "车组方式信息管理";
            this.Load += new System.EventHandler(this.ManageTrainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTrainName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCarNum;
        private System.Windows.Forms.ListBox lbCarTyp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnDelTrain;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}