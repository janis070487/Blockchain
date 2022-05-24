using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockchain_Demo
{
     class FirstBlock : Bloc
    {
        public string previousHashSum { get; }
        public FirstBlock()
        {
            previousHashSum = "000000000";    // jaturpina
        }
    }
}
