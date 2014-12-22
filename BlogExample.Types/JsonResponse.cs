﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogExample.Types
{
    public class JsonResponse
    {
        public int? Id { get; set; }

        public string CssClass { get; set; }

        public string Message { get; set; }

        public object Record { get; set; }


        public bool IsSuccess { get; set; }
    }
}
