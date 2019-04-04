using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_List
{
    public interface IHasANickName
    {
        string GiveANickName(string first, string last);
    }
}
