using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.Models
{
    public class WeatherViewModel
    {

       
            public bool success { get; set; }
            public Data data { get; set; }
       

        public class Data
        {
           
            public string temp { get; set; }
            public string expected_temp { get; set; }
         
            
        }


    }
}
