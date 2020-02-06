using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Models
{
    public class ResultJson
    {
        public ResultJson(int c)
        {
            this.c = c;
        }

        public int c { get; set; }
    }
}
