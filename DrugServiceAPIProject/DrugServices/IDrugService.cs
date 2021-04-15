using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.DrugServices
{
    public interface IDrugService
    {
        public Drug GetDrugById(int id);
        public Drug GetDrugByName(string name);
        public DispatchableDrugStockDTO GetDispatchableDrugStock(int id, string location);
        public List<DrugDetailsDTO> GetAllDrugs();
        //public bool GetAvailability(int id, string location, int qty);
    }
}
