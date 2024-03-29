﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_wpf_demo.Common.Model
{
    class BaseDto
    {
        private int id;
        private DateTime createDate;
        private DateTime updateDate;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        public DateTime UpdateDate
        {
            get { return updateDate; }
            set { updateDate = value; }
        }
    }
}
