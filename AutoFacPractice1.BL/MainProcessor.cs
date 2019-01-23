using AutoFacPractice1.BL.UserProcessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1.BL
{
    public class MainProcessor
    {
        private readonly IUserSource userSource;

        public MainProcessor(IUserSource userSource)
        {
            this.userSource = userSource ?? throw new ArgumentNullException(nameof(userSource));
        }

        public void Process()
        {
            string[] userNames = userSource.GetUsers();

            foreach(string userName in userNames)
            {
                UserProcessor userProcessor = new UserProcessor(new CompanyParsers.CompanyParser());
                userProcessor.Process(userName);
            }
        }
    }
}
