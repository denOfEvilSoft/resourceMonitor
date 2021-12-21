using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NvAPIWrapper.GPU;

namespace WindowsFormsApp2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        저장용 임시;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            var a = NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs();
            l_gpuName.Text = a[0].FullName;
            var tempa = a[0].UsageInformation.GPU;
            solidGauge1.To = a[0].MemoryInformation.AvailableDedicatedVideoMemoryInkB;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var a = NvAPIWrapper.GPU.PhysicalGPU.GetPhysicalGPUs();
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            p_cpu.Value = (int)fcpu;
            p_ram.Value = (int)fram;

            var getPersent = a[0].UsageInformation.GPU;
            p_gpu.Value = Convert.ToInt32(getPersent.Percentage);

            l_cpu.Text = string.Format("{0:0.00}%", fcpu);
            l_ram.Text = string.Format("{0:0.00}%", fram);
            l_gpu.Text = string.Format("{0:0.00}%", getPersent.Percentage);
            solidGauge1.Value = a[0].MemoryInformation.AvailableDedicatedVideoMemoryInkB - a[0].MemoryInformation.CurrentAvailableDedicatedVideoMemoryInkB;

            임시 = new 저장용();
            임시.runName = System.AppDomain.CurrentDomain.FriendlyName;
            임시.cpu = l_cpu.Text;
            임시.ram = l_ram.Text;
            임시.gpu = l_gpu.Text;
            임시.gpuMem = solidGauge1.Value.ToString();
            임시.time = System.DateTime.Now.ToString("G");
            listBox1.Items.Add(임시);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            저장용 임시2;
            using(FileStream fs = new FileStream("성능모니터로그.txt", FileMode.OpenOrCreate))
            {
                using(StreamWriter sw = new StreamWriter(fs))
                {
                    for(int i = 0; i < listBox1.Items.Count; i++)
                    {
                        임시2 = listBox1.Items[i] as 저장용;
                        sw.WriteLine("run : " + 임시2.runName);
                        sw.WriteLine("cpu : " + 임시2.cpu);
                        sw.WriteLine("ram : " + 임시2.ram);
                        sw.WriteLine("gpu : " + 임시2.gpu);
                        sw.WriteLine("gpumem : " + 임시2.gpuMem);
                        sw.WriteLine("time : " + 임시2.time);
                        sw.WriteLine();
                    }
                    sw.Flush();
                }
            }
        }
    }
}
