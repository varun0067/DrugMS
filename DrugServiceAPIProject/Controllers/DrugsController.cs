using DrugServiceAPIProject.DrugServices;
using DrugServiceAPIProject.DTO;
using DrugServiceAPIProject.Models;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrugServiceAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DrugsController : ControllerBase
    {
        private IDrugService _drugService;
        private readonly ILog _log4net = LogManager.GetLogger(typeof(DrugsController));
        public DrugsController(IDrugService drugService)
        {
            _drugService = drugService;
        }

        
        [HttpGet("SearchDrugById/{id}")]
        public ActionResult<Drug> GetDrugById(int id)
        {
            _log4net.Info("DrugMicroService  : " + nameof(GetDrugById));
            if (id <= 0)
                return BadRequest("Please give valid id");
            try
            {
                var Drug = _drugService.GetDrugById(id);
                if (Drug == null)
                    return BadRequest("data not found");
                else
                    return Ok(Drug);
            }
            catch(Exception e)
            {
                _log4net.Error("Exception Occured : " + e.Message + " from " + nameof(GetDrugById));
                return BadRequest("Exception Occured");
            }
        }
        //method to get drugs details by drug name
        [HttpGet("searchDrugsByName/{name}")]
        public ActionResult<Drug> GetDrugByName(string name)
        {
            _log4net.Info("DrugMicroService : " + nameof(GetDrugByName));
            if (name == null)
                return BadRequest("please give valid name");
            try
            {
                var result = _drugService.GetDrugByName(name);
                if (result == null)
                    return BadRequest("data not found");
                else
                    return result;
            }
            catch(Exception e)
            {
                _log4net.Error("Exception Occured : " + e.Message + " from " + nameof(GetDrugByName));
                return BadRequest("Exception Occured");
            }
        }

        //method to get details of a drug from particular locations
        [HttpPost("getDispatchableDrugStock/{id}/{location}")]
        public ActionResult<DispatchableDrugStockDTO> GetDispatchableDrugStock(int id,string location)
        {
            _log4net.Info("DrugMicroService : " + nameof(GetDispatchableDrugStock));
            if (id == 0 || location == null)
                return BadRequest("please give valid details");
            try
            {
                var result = _drugService.GetDispatchableDrugStock(id, location);
                if (result == null)
                    return BadRequest("data not found");
                else
                    return Ok(result);
            }
            catch(Exception e)
            {
                _log4net.Error("Exception Occured : " + e.Message + " from " + nameof(GetDispatchableDrugStock));
                return BadRequest("Exception Occured");
            }
        }

        [HttpGet("getAllDrugs")]
        public ActionResult<Drug> GetALLDrugs()
        {
            _log4net.Info("DrugMicroService  : " + nameof(GetALLDrugs));
            List<DrugDetailsDTO> result = _drugService.GetAllDrugs();
            try
            {
                if (result != null)
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception e)
            {
                _log4net.Error("Exception Occured : " + e.Message + " from " + nameof(GetDrugByName));
                return BadRequest("Exception Occured");
            }
        }
    }
}
