using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator.Interfaces
{
    public interface IOperation
    {
        IEquetion checkContainOperation(char operation);
    }
}
