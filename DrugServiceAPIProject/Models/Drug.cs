using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.Models
{
    public class Drug
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Composition { get; set; }
        public List<DrugLocation> QuantityByLocation { get; set; }
        public int UnitsInPackage { get; set; }
        public double CostPerPackage { get; set; }


        public Drug()
        {
            QuantityByLocation = new List<DrugLocation>();
        }
        
    }
    
}
