﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime Datetime { get; set; }

       // public List<OrderProduct> orderProducts { get; set; }


    }
}
