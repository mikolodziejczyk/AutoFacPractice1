using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.UserSources
{
    /// <summary>
    /// A sample implmentation of IUserSource
    /// </summary>
    public class AdUserSource : IUserSource
    {
        public string[] GetUsers()
        {
            return new string[] { "Tom (A)", "Harry (B)", "John (C)", "Jim (A)" };
        }
    }
}
