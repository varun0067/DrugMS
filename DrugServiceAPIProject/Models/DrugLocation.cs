using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.Models
{
    public class DrugLocation
    {
        public string Location { get; set; }
        public int Quantity { get; set; }

    }
}
