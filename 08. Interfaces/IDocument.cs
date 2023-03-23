using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Interfaces
{
    internal interface IDocument
    {
        string TechPassport { get; set; }

        void PrintDocs();
    }
}
