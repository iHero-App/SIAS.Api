﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuviaGS.DbModel.ModelView
{
    public class UserExperienceeView
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Specializtion { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Descrption { get; set; }
    }
}
