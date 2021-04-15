using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.DrugRepositories
{
    public interface IDrugRepo
    {
        //public bool GetAvailability(int id, string location, int qty);
        public Drug GetDrugById(int id);
        public Drug GetDrugByName(string name);
        public DispatchableDrugStockDTO GetDispatchableDrugStock(int id, string location);
        public List<DrugDetailsDTO> GetAllDrugs();
    }
}
