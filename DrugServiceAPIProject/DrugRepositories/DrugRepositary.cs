using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.DrugRepositories
{
    public class DrugRepositary:IDrugRepo
    {
        //DrugDBHelper drugDBHelper = new DrugDBHelper();
        private DrugDBHelper _dbHelper;

        public DrugRepositary(DrugDBHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        //public bool GetAvailability(int id, string location, int qty)
        //{
        //    var drugItem=_dbHelper.drugs.FirstOrDefault(d => d.DrugId == id && d.QuantityByLocation.Find(a=>a.Location==location).Location==);
        //    var drugLocationItem = drugItem.QuantityByLocation.FirstOrDefault(a => a.Location == location);
        //    if (drugLocationItem.Quantity >= qty)
        //        return true;
        //    else
        //        return false;
        //}
        public Drug GetDrugById(int id)
        {
            return _dbHelper.drugs.FirstOrDefault(a => a.DrugId == id);
        }
        public Drug GetDrugByName(string name)
        {
            return _dbHelper.drugs.FirstOrDefault(a => a.DrugName == name);
        }
        public DispatchableDrugStockDTO GetDispatchableDrugStock(int id, string location)
        {
            var drug = _dbHelper.drugs.FirstOrDefault(d=>d.DrugId==id);
            
            if (drug != null)
            {
                DrugLocation available = drug.QuantityByLocation.Find(dl => dl.Location == location);
                if (available != null)
                {
                    DispatchableDrugStockDTO dispatchableDrug = new DispatchableDrugStockDTO()
                    {
                        Id = drug.DrugId,
                        Name = drug.DrugName,
                        ExpiryDate = drug.ExpiryDate,
                        AvailableStock = available.Quantity,
                        CostPerUnit = drug.CostPerPackage / drug.UnitsInPackage
                    };
                    return dispatchableDrug;
                }
                return null;
            }
            return null;
        }
        public List<DrugDetailsDTO> GetAllDrugs()
        {
            List<Drug> drugs = _dbHelper.drugs;
            List<DrugDetailsDTO> AllDrugsDetails = new List<DrugDetailsDTO>();

            foreach(Drug d in drugs)
            {
                DrugDetailsDTO drugDetails = new DrugDetailsDTO()
                {
                    DrugId = d.DrugId,
                    DrugName = d.DrugName,
                    ExpiryDate = d.ExpiryDate,
                    Manufacturer = d.Manufacturer,
                    ManufactureDate = d.ManufactureDate,
                    Composition = d.Composition,
                    CostPerPackage = d.CostPerPackage,
                    UnitsInPackage = d.UnitsInPackage
                };
                AllDrugsDetails.Add(drugDetails);
            }
            return AllDrugsDetails;
        }
    }
}
