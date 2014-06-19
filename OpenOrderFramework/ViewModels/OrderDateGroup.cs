using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OpenOrderFramework.ViewModels
{
    public class OrderDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }

        public int OrderCount { get; set; }
    }
}