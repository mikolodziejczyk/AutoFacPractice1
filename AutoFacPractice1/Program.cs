using AutoFacPractice1.BL;
using AutoFacPractice1.BL.UserSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            IUserSource userSource = new AdUserSource();
            MainProcessor mainProcessor = new MainProcessor(userSource);
            mainProcessor.Process();
        }
    }
}
