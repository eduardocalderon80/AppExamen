﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppExamen.Models.Response
{
    public class MyResponse
    {
        public int Success { get; set; }
        public string Message { get; set; }
        public Object Data { get; set; }
    }
}
