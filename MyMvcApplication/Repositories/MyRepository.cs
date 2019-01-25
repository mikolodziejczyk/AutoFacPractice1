using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMvcApplication.Repositories
{
    public class MyRepository
    {
        static int counter = 1;

        int id;

        public MyRepository()
        {
            id = counter++;
        }

        public int GetValue()
        {
            return id;
        }
    }
}