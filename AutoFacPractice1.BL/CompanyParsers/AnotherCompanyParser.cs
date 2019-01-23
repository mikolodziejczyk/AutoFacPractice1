using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.CompanyParsers
{
    public class AnotherCompanyParser : CompanyParser
    {
        static int counter = 1;
        
        public AnotherCompanyParser()
        {
            id = counter++;
        }

        int id;

        public override string Parse(string userName)
        {
            string r = "";
            if (userName.Length > 3) r = userName.Substring(userName.Length - 2, 1);
            return String.Format("{0} - parser instance {1}", r, id);
        }
    }
}
