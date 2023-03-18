using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_26
{
    internal class File
    {
        string path = @"C:\Users\arapov.ad1680\source\repos\2pk2_ArapovAleksej\pz_26\data";
        FileStream file1 = new FileStream($@"C:\Users\arapov.ad1680\source\repos\2pk2_ArapovAleksej\pz_26\data\new_file.txt", FileMode.Create);
    }
}
