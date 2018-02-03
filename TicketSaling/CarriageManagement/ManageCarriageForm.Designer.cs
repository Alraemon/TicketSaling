namespace TicketSaling.CarriageManagement
{
    partial class ManageCarriageForm
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
            this.tbCarTyp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCarVol = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbVolPerSec = new System.Windows.Forms.TextBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDelCar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCarTyp);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "车厢型号";
            // 
            // tbCarTyp
            // 
            this.tbCarTyp.Location = new System.Drawing.Point(22, 29);
            this.tbCarTyp.Name = "tbCarTyp";
            this.tbCarTyp.Size = new System.Drawing.Size(100, 21);
            this.tbCarTyp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCarVol);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车厢容量";
            // 
            // tbCarVol
            // 
            this.tbCarVol.Location = new System.Drawing.Point(22, 29);
            this.tbCarVol.Name = "tbCarVol";
            this.tbCarVol.Size = new System.Drawing.Size(100, 21);
            this.tbCarVol.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbVolPerSec);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 73);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "每排席位数";
            // 
            // tbVolPerSec
            // 
            this.tbVolPerSec.Location = new System.Drawing.Point(22, 29);
            this.tbVolPerSec.Name = "tbVolPerSec";
            this.tbVolPerSec.Size = new System.Drawing.Size(100, 21);
            this.tbVolPerSec.TabIndex = 0;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(178, 91);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(144, 39);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "添加车厢";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDelCar
            // 
            this.btnDelCar.Location = new System.Drawing.Point(178, 136);
            this.btnDelCar.Name = "btnDelCar";
            this.btnDelCar.Size = new System.Drawing.Size(144, 39);
            this.btnDelCar.TabIndex = 4;
            this.btnDelCar.Text = "删除车厢";
            this.toolTip1.SetToolTip(this.btnDelCar, "删除车厢时只需输入车厢型号");
            this.btnDelCar.UseVisualStyleBackColor = true;
            this.btnDelCar.Click += new System.EventHandler(this.btnDelCar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.toolTip1.ForeColor = System.Drawing.Color.Gray;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "删除车厢";
            // 
            // ManageCarriageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 183);
            this.Controls.Add(this.btnDelCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageCarriageForm";
            this.Text = "车厢管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCarTyp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCarVol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbVolPerSec;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDelCar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}