﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.Models
{
    public class ImdbViewModel
    {
 
            public int rank { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string image { get; set; }
            public string big_image { get; set; }
            public string[] genre { get; set; }
            public string thumbnail { get; set; }
            public string rating { get; set; }
            public string id { get; set; }
            public int year { get; set; }
            public string imdbid { get; set; }
            public string imdb_link { get; set; }
        }

    }

