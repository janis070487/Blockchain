using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
    public class Info
    {

        public long milliseconds { get; set; }
        public string nonce { get; set; }
        public string seconds { get; set; }
        public string minutes { get; set; }
        public string averageTimePerUnit { get; set; }
        public string totalTime { get; set; }
        public void SetInfo()
        {
            seconds = Convert.ToString(milliseconds / 1000);
        }


    }
}
