using DrugServiceAPIProject.DrugRepositories;
using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.DrugServices
{
    public class DrugService:IDrugService
    {
        private IDrugRepo _drugRepositary;

        public DrugService(IDrugRepo repo)
        {
            _drugRepositary = repo;
        }
        public Drug GetDrugById(int id)
        {
            return _drugRepositary.GetDrugById(id);
        }
        public Drug GetDrugByName(string name)
        {
            return _drugRepositary.GetDrugByName(name);
        }
        public DispatchableDrugStockDTO GetDispatchableDrugStock(int id, string location)
        {
            return _drugRepositary.GetDispatchableDrugStock(id, location);
        }

        public List<DrugDetailsDTO> GetAllDrugs()
        {
            return _drugRepositary.GetAllDrugs();
        }
        //public bool GetAvailability(int id, string location, int qty)
        //{
        //    return _drugRepositary.GetAvailability(id, location, qty);
        //}
    }
}
