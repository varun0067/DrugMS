using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugServiceAPIProject.Models
{
    public class DrugDBHelper
    {
        public List<Drug> drugs;
      
        public DrugDBHelper()
        {
            drugs = new List<Drug>();
            Drug drug = new Drug()
            {
                DrugId = 1,
                DrugName = "Crocin",
                Manufacturer = "Razor Medicals",
                ManufactureDate = Convert.ToDateTime("2/2/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2022"),
                UnitsInPackage = 10,
                CostPerPackage = 100,
                Composition = "C,Br,Z"
            };
            drug.QuantityByLocation.Add(new DrugLocation() {  Location = "Bangalore", Quantity = 200 });
            drug.QuantityByLocation.Add(new DrugLocation() {  Location = "Mysore", Quantity = 300 });
            drug.QuantityByLocation.Add(new DrugLocation() {  Location = "Mangalore", Quantity = 0 });
            drug.QuantityByLocation.Add(new DrugLocation() {  Location = "Chennai", Quantity = 5000 });
            drug.QuantityByLocation.Add(new DrugLocation() {  Location = "Dharwad", Quantity = 800 });


            Drug drug1= new Drug()
            {
                DrugId = 2,
                DrugName = "Paracetamol",
                Manufacturer = "Wizards Medicals",
                ManufactureDate = Convert.ToDateTime("1/2/2020"),
                ExpiryDate = Convert.ToDateTime("2/2/2022"),
                UnitsInPackage = 20,
                CostPerPackage = 100,
                Composition="Z,N2,O"
            };
            drug1.QuantityByLocation.Add(new DrugLocation() {  Location = "Bangalore", Quantity = 2000 });
            drug1.QuantityByLocation.Add(new DrugLocation() {  Location = "Mysore", Quantity = 400 });
            drug1.QuantityByLocation.Add(new DrugLocation() {  Location = "Mangalore", Quantity = 1000 });
            drug1.QuantityByLocation.Add(new DrugLocation() {  Location = "Chennai", Quantity = 300 });
            drug1.QuantityByLocation.Add(new DrugLocation() {  Location = "Dharwad", Quantity = 100 });




            Drug drug2=new Drug()
            {
                DrugId = 3,
                DrugName = "Dolo",
                Manufacturer = "Para medicals",
                ManufactureDate = Convert.ToDateTime("12/1/2020"),
                ExpiryDate = Convert.ToDateTime("11/2/2023"),
                UnitsInPackage = 15,
                CostPerPackage = 300,
                Composition="Br,CO,P"
            };
            drug2.QuantityByLocation.Add(new DrugLocation() { Location = "Bangalore", Quantity = 2000 });
            drug2.QuantityByLocation.Add(new DrugLocation() { Location = "Mysore", Quantity = 400 });
            drug2.QuantityByLocation.Add(new DrugLocation() { Location = "Mangalore", Quantity = 1000 });
            drug2.QuantityByLocation.Add(new DrugLocation() { Location = "Chennai", Quantity = 300 });
            drug2.QuantityByLocation.Add(new DrugLocation() { Location = "Dharwad", Quantity = 100 });



            Drug drug3 = new Drug()
            {
                DrugId = 4,
                DrugName = "V-500",
                Manufacturer = "Action medicals",
                ManufactureDate = Convert.ToDateTime("1/1/2020"),
                ExpiryDate = Convert.ToDateTime("1/2/2023"),
                UnitsInPackage = 25,
                CostPerPackage = 220,
                Composition = "P,Fe,Br"
            };
            drug3.QuantityByLocation.Add(new DrugLocation() { Location = "Bangalore", Quantity = 2000 });
            drug3.QuantityByLocation.Add(new DrugLocation() { Location = "Mysore", Quantity = 400 });
            drug3.QuantityByLocation.Add(new DrugLocation() { Location = "Mangalore", Quantity = 1000 });
            drug3.QuantityByLocation.Add(new DrugLocation() { Location = "Chennai", Quantity = 300 });
            drug3.QuantityByLocation.Add(new DrugLocation() { Location = "Dharwad", Quantity = 100 });

            Drug drug4 = new Drug()
            {
                DrugId = 5,
                DrugName = "Albendazol",
                Manufacturer = "Action medicals",
                ManufactureDate = Convert.ToDateTime("1/1/2020"),
                ExpiryDate = Convert.ToDateTime("1/2/2023"),
                UnitsInPackage = 25,
                CostPerPackage = 220,
                Composition = "P,Fe,Br,C"
            };
            drug4.QuantityByLocation.Add(new DrugLocation() { Location = "Bangalore", Quantity = 2000 });
            drug4.QuantityByLocation.Add(new DrugLocation() { Location = "Mysore", Quantity = 400 });
            drug4.QuantityByLocation.Add(new DrugLocation() { Location = "Mangalore", Quantity = 1000 });
            drug4.QuantityByLocation.Add(new DrugLocation() { Location = "Chennai", Quantity = 300 });
            drug4.QuantityByLocation.Add(new DrugLocation() { Location = "Dharwad", Quantity = 100 });

            drugs.Add(drug);
            drugs.Add(drug1);
            drugs.Add(drug2);
            drugs.Add(drug3);
            drugs.Add(drug4);

        }

    }
}
