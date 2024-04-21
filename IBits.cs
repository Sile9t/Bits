using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsConsole
{
    public interface IBits
    {
        bool getBits(int i);
        void setBits(int i, bool val);
    }
}
