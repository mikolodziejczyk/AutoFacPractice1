using AutoFacPractice1.BL.CompanyParsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL.UserProcessors
{
    /// <summary>
    /// Assume that there's an instance of UserProcessor required for processing each user.
    /// </summary>
    public class UserProcessor
    {
        private readonly CompanyParser companyParser;

        public UserProcessor(CompanyParser companyParser)
        {
            this.companyParser = companyParser ?? throw new ArgumentNullException(nameof(companyParser));
        }

        public virtual void Process(string userName)
        {
            string company = companyParser.Parse(userName);
            Console.WriteLine("UserProcessor: User {0} from {1}", userName, company);
        }
    }
}
