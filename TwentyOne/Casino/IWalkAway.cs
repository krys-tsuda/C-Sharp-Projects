using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Interfaces
{
    // naming convention is to start with "I"
    interface IWalkAway
    {
        void WalkAway(Player player);
    }
}
