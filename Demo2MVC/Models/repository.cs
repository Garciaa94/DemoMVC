using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2MVC.Models
{
    public class repository
    {
        public Demo GetDemo()
        {
            return new Demo
            {
                Message  = "Hello Word",
                MessageHTML = "<h1> Hello Word <h1>",
            };
        }
    }
}