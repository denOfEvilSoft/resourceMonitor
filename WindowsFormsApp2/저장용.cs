using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class 저장용
    {
        public string runName { get; set; }
        public string cpu { get; set; }
        public string ram { get; set; }
        public string gpu { get; set; }
        public string gpuMem { get; set; }
        public string time { get; set; }

        public override string ToString()
        {
            return System.DateTime.Now.ToString("G");
        }
    }
}
