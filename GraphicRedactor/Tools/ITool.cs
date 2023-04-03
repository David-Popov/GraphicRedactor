using GraphicRedactor.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicRedactor.Tools
{
    public interface ITool
    {
        public Shape CreateNewShape(string type);
    }
}
