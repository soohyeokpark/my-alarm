namespace myAlarm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label_time_main = new System.Windows.Forms.Label();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel_main = new System.Windows.Forms.TableLayoutPanel();
            this.label_time_remain = new System.Windows.Forms.Label();
            this.tableLayoutPanel_control = new System.Windows.Forms.TableLayoutPanel();
            this.button_10min = new System.Windows.Forms.Button();
            this.button_30min = new System.Windows.Forms.Button();
            this.button_60min = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.tableLayoutPanel_main.SuspendLayout();
            this.tableLayoutPanel_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_time_main
            // 
            this.label_time_main.AutoSize = true;
            this.tableLayoutPanel_main.SetColumnSpan(this.label_time_main, 2);
            this.label_time_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_time_main.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_main.Location = new System.Drawing.Point(3, 0);
            this.label_time_main.Name = "label_time_main";
            this.label_time_main.Size = new System.Drawing.Size(478, 150);
            this.label_time_main.TabIndex = 0;
            this.label_time_main.Text = "time_main";
            this.label_time_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // tableLayoutPanel_main
            // 
            this.tableLayoutPanel_main.ColumnCount = 2;
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_main.Controls.Add(this.label_time_remain, 0, 1);
            this.tableLayoutPanel_main.Controls.Add(this.label_time_main, 0, 0);
            this.tableLayoutPanel_main.Controls.Add(this.tableLayoutPanel_control, 0, 2);
            this.tableLayoutPanel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_main.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel_main.Name = "tableLayoutPanel_main";
            this.tableLayoutPanel_main.RowCount = 3;
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel_main.Size = new System.Drawing.Size(484, 461);
            this.tableLayoutPanel_main.TabIndex = 1;
            // 
            // label_time_remain
            // 
            this.label_time_remain.AutoSize = true;
            this.tableLayoutPanel_main.SetColumnSpan(this.label_time_remain, 2);
            this.label_time_remain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_time_remain.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_remain.Location = new System.Drawing.Point(3, 150);
            this.label_time_remain.Name = "label_time_remain";
            this.label_time_remain.Size = new System.Drawing.Size(478, 150);
            this.label_time_remain.TabIndex = 1;
            this.label_time_remain.Text = "time_remain";
            this.label_time_remain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_time_remain.DoubleClick += new System.EventHandler(this.label_time_remain_DoubleClick);
            // 
            // tableLayoutPanel_control
            // 
            this.tableLayoutPanel_control.ColumnCount = 2;
            this.tableLayoutPanel_main.SetColumnSpan(this.tableLayoutPanel_control, 2);
            this.tableLayoutPanel_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_control.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_control.Controls.Add(this.button_10min, 0, 0);
            this.tableLayoutPanel_control.Controls.Add(this.button_30min, 1, 0);
            this.tableLayoutPanel_control.Controls.Add(this.button_60min, 0, 1);
            this.tableLayoutPanel_control.Controls.Add(this.button_clear, 1, 1);
            this.tableLayoutPanel_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel_control.Location = new System.Drawing.Point(0, 300);
            this.tableLayoutPanel_control.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel_control.Name = "tableLayoutPanel_control";
            this.tableLayoutPanel_control.RowCount = 2;
            this.tableLayoutPanel_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_control.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_control.Size = new System.Drawing.Size(484, 161);
            this.tableLayoutPanel_control.TabIndex = 2;
            // 
            // button_10min
            // 
            this.button_10min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_10min.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_10min.Location = new System.Drawing.Point(3, 3);
            this.button_10min.Name = "button_10min";
            this.button_10min.Size = new System.Drawing.Size(236, 74);
            this.button_10min.TabIndex = 3;
            this.button_10min.Text = "10분";
            this.button_10min.UseVisualStyleBackColor = true;
            this.button_10min.Click += new System.EventHandler(this.button_10min_Click);
            // 
            // button_30min
            // 
            this.button_30min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_30min.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_30min.Location = new System.Drawing.Point(245, 3);
            this.button_30min.Name = "button_30min";
            this.button_30min.Size = new System.Drawing.Size(236, 74);
            this.button_30min.TabIndex = 2;
            this.button_30min.Text = "30분";
            this.button_30min.UseVisualStyleBackColor = true;
            this.button_30min.Click += new System.EventHandler(this.button_30min_Click);
            // 
            // button_60min
            // 
            this.button_60min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_60min.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_60min.Location = new System.Drawing.Point(3, 83);
            this.button_60min.Name = "button_60min";
            this.button_60min.Size = new System.Drawing.Size(236, 75);
            this.button_60min.TabIndex = 1;
            this.button_60min.Text = "1시간";
            this.button_60min.UseVisualStyleBackColor = true;
            this.button_60min.Click += new System.EventHandler(this.button_60min_Click);
            // 
            // button_clear
            // 
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(245, 83);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(236, 75);
            this.button_clear.TabIndex = 0;
            this.button_clear.Text = "초기화";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tableLayoutPanel_main);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "My Alarm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.tableLayoutPanel_main.ResumeLayout(false);
            this.tableLayoutPanel_main.PerformLayout();
            this.tableLayoutPanel_control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_time_main;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_main;
        private System.Windows.Forms.Label label_time_remain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_control;
        private System.Windows.Forms.Button button_10min;
        private System.Windows.Forms.Button button_30min;
        private System.Windows.Forms.Button button_60min;
        private System.Windows.Forms.Button button_clear;
    }
}

