using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale
{
    internal interface IAccount
    {
        string userName {  get; set; }
        string ID { get; set; }
        string password { get; set; }
    }
}
