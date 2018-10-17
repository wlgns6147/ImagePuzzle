namespace Puzzle
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pause_label = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.pausebtn = new System.Windows.Forms.Button();
            this.start4x4btn = new System.Windows.Forms.Button();
            this.start3x3btn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.이미지선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.img_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(43, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 273);
            this.panel1.TabIndex = 0;
            // 
            // pause_label
            // 
            this.pause_label.AutoSize = true;
            this.pause_label.Font = new System.Drawing.Font("문체부 제목 돋음체", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pause_label.Location = new System.Drawing.Point(293, 205);
            this.pause_label.Name = "pause_label";
            this.pause_label.Size = new System.Drawing.Size(128, 28);
            this.pause_label.TabIndex = 9;
            this.pause_label.Text = "일시정지";
            this.pause_label.Visible = false;
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(230, 390);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(90, 30);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "종료";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(403, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 250);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "퍼즐";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "원본";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("Cooper Blk BT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.Location = new System.Drawing.Point(412, 329);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(241, 58);
            this.time_label.TabIndex = 9;
            this.time_label.Text = "00:00:00";
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 1000;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // pausebtn
            // 
            this.pausebtn.Location = new System.Drawing.Point(134, 390);
            this.pausebtn.Name = "pausebtn";
            this.pausebtn.Size = new System.Drawing.Size(90, 30);
            this.pausebtn.TabIndex = 10;
            this.pausebtn.Text = "일시정지";
            this.pausebtn.UseVisualStyleBackColor = true;
            this.pausebtn.Click += new System.EventHandler(this.pausebtn_Click);
            // 
            // start4x4btn
            // 
            this.start4x4btn.Location = new System.Drawing.Point(528, 390);
            this.start4x4btn.Name = "start4x4btn";
            this.start4x4btn.Size = new System.Drawing.Size(100, 30);
            this.start4x4btn.TabIndex = 11;
            this.start4x4btn.Text = "4 x 4 퍼즐";
            this.start4x4btn.UseVisualStyleBackColor = true;
            this.start4x4btn.Click += new System.EventHandler(this.start44btn_Click);
            // 
            // start3x3btn
            // 
            this.start3x3btn.Location = new System.Drawing.Point(411, 390);
            this.start3x3btn.Name = "start3x3btn";
            this.start3x3btn.Size = new System.Drawing.Size(100, 30);
            this.start3x3btn.TabIndex = 12;
            this.start3x3btn.Text = "3 x 3 퍼즐";
            this.start3x3btn.UseVisualStyleBackColor = true;
            this.start3x3btn.Click += new System.EventHandler(this.start33btn_Click);
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(38, 390);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(90, 30);
            this.startbtn.TabIndex = 13;
            this.startbtn.Text = "시작";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지선택ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // 이미지선택ToolStripMenuItem
            // 
            this.이미지선택ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.img_1,
            this.img_2,
            this.img_3,
            this.img_4,
            this.img_5});
            this.이미지선택ToolStripMenuItem.Name = "이미지선택ToolStripMenuItem";
            this.이미지선택ToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.이미지선택ToolStripMenuItem.Text = "이미지 변경하기";
            // 
            // img_1
            // 
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(92, 26);
            this.img_1.Text = "1";
            this.img_1.Click += new System.EventHandler(this.img_1_Click);
            // 
            // img_2
            // 
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(92, 26);
            this.img_2.Text = "2";
            this.img_2.Click += new System.EventHandler(this.img_2_Click);
            // 
            // img_3
            // 
            this.img_3.Name = "img_3";
            this.img_3.Size = new System.Drawing.Size(92, 26);
            this.img_3.Text = "3";
            this.img_3.Click += new System.EventHandler(this.img_3_Click);
            // 
            // img_4
            // 
            this.img_4.Name = "img_4";
            this.img_4.Size = new System.Drawing.Size(92, 26);
            this.img_4.Text = "4";
            this.img_4.Click += new System.EventHandler(this.img_4_Click);
            // 
            // img_5
            // 
            this.img_5.Name = "img_5";
            this.img_5.Size = new System.Drawing.Size(92, 26);
            this.img_5.Text = "5";
            this.img_5.Click += new System.EventHandler(this.img_5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 452);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.start3x3btn);
            this.Controls.Add(this.start4x4btn);
            this.Controls.Add(this.pause_label);
            this.Controls.Add(this.pausebtn);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "퍼즐 맞추기";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer tmrTimeElapse;
        private System.Windows.Forms.Button pausebtn;
        private System.Windows.Forms.Label pause_label;
        private System.Windows.Forms.Button start4x4btn;
        private System.Windows.Forms.Button start3x3btn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 이미지선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem img_1;
        private System.Windows.Forms.ToolStripMenuItem img_2;
        private System.Windows.Forms.ToolStripMenuItem img_3;
        private System.Windows.Forms.ToolStripMenuItem img_4;
        private System.Windows.Forms.ToolStripMenuItem img_5;
    }
}

