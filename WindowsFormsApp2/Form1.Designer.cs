namespace WindowsFormsApp2
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
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.p_cpu = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.l_cpu = new MetroFramework.Controls.MetroLabel();
            this.l_ram = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.p_ram = new MetroFramework.Controls.MetroProgressBar();
            this.l_gpuName = new MetroFramework.Controls.MetroLabel();
            this.p_gpu = new MetroFramework.Controls.MetroProgressBar();
            this.l_gpu = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // p_cpu
            // 
            this.p_cpu.Location = new System.Drawing.Point(23, 97);
            this.p_cpu.Name = "p_cpu";
            this.p_cpu.Size = new System.Drawing.Size(366, 19);
            this.p_cpu.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CPU 사용";
            // 
            // l_cpu
            // 
            this.l_cpu.AutoSize = true;
            this.l_cpu.Location = new System.Drawing.Point(395, 97);
            this.l_cpu.Name = "l_cpu";
            this.l_cpu.Size = new System.Drawing.Size(31, 19);
            this.l_cpu.TabIndex = 2;
            this.l_cpu.Text = "0 %";
            // 
            // l_ram
            // 
            this.l_ram.AutoSize = true;
            this.l_ram.Location = new System.Drawing.Point(395, 152);
            this.l_ram.Name = "l_ram";
            this.l_ram.Size = new System.Drawing.Size(31, 19);
            this.l_ram.TabIndex = 5;
            this.l_ram.Text = "0 %";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(20, 130);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "RAM 사용";
            // 
            // p_ram
            // 
            this.p_ram.Location = new System.Drawing.Point(23, 152);
            this.p_ram.Name = "p_ram";
            this.p_ram.Size = new System.Drawing.Size(366, 19);
            this.p_ram.TabIndex = 3;
            // 
            // l_gpuName
            // 
            this.l_gpuName.AutoSize = true;
            this.l_gpuName.Location = new System.Drawing.Point(23, 222);
            this.l_gpuName.Name = "l_gpuName";
            this.l_gpuName.Size = new System.Drawing.Size(60, 19);
            this.l_gpuName.TabIndex = 6;
            this.l_gpuName.Text = "gpu이름";
            // 
            // p_gpu
            // 
            this.p_gpu.Location = new System.Drawing.Point(23, 273);
            this.p_gpu.Name = "p_gpu";
            this.p_gpu.Size = new System.Drawing.Size(366, 19);
            this.p_gpu.TabIndex = 7;
            // 
            // l_gpu
            // 
            this.l_gpu.AutoSize = true;
            this.l_gpu.Location = new System.Drawing.Point(395, 273);
            this.l_gpu.Name = "l_gpu";
            this.l_gpu.Size = new System.Drawing.Size(31, 19);
            this.l_gpu.TabIndex = 8;
            this.l_gpu.Text = "0 %";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 251);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "gpu 로드율";
            // 
            // solidGauge1
            // 
            this.solidGauge1.Location = new System.Drawing.Point(23, 308);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(157, 119);
            this.solidGauge1.TabIndex = 10;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 308);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "VRAM 사용";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(211, 332);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 88);
            this.listBox1.TabIndex = 12;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(211, 310);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(37, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "로그";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "로그 내보내기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.solidGauge1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.l_gpu);
            this.Controls.Add(this.p_gpu);
            this.Controls.Add(this.l_gpuName);
            this.Controls.Add(this.l_ram);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.p_ram);
            this.Controls.Add(this.l_cpu);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.p_cpu);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "성능 모니터";
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar p_cpu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel l_cpu;
        private MetroFramework.Controls.MetroLabel l_ram;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroProgressBar p_ram;
        private MetroFramework.Controls.MetroLabel l_gpuName;
        private MetroFramework.Controls.MetroProgressBar p_gpu;
        private MetroFramework.Controls.MetroLabel l_gpu;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button button1;
    }
}

