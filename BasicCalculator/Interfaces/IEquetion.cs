using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Interfaces
{
    public interface IEquetion
    {
        char Operation { get; }
        double Execute(double a, double b);

    }
}
