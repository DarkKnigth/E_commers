using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommers.Entity
{
    public interface Aggration
    {
       int MaxVulae(string Query="");
        int MinVulae(string Query = "");
        int SumVulae(string Query = "");
        int AVGVulae(string Query = "");

        int CountVulae(string Query = "");

    }
}
