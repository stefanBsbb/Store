using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Abstractions
{
    public interface IExpired
    {
        bool Expired();
    }
}
