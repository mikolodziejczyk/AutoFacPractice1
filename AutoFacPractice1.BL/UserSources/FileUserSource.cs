using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.UserSources
{
    /// <summary>
    /// Another sample implmentation of IUserSource
    /// </summary>
    public class FileUserSource
    {
        public string[] GetUsers()
        {
            return new string[] { "Marry (C)", "Katie (A)", "Maggie (A)" };
        }
    }
}
