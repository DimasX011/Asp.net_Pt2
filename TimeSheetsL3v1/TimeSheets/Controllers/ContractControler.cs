using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Controllers.Models;
using TimeSheets.DAL.Repositories;
using TimeSheets.DAL.Entities;
using TimeSheets.Services;


namespace TimeSheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractControler : ControllerBase
    {
        public ContractRepository _repository;
       
        public ContractControler(ContractRepository repository)
        {
            _repository = repository;
            
        }
        
        [HttpPost("create")]
        public IActionResult Create([FromBody] TimeSheets.Controllers.Models.Contract request)
        {
            _repository.AddContract(request);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromBody] int id)
        {
            _repository.DeleteContract(id);
            return Ok();
        }

        [HttpPut("upadate")]
        public IActionResult Update([FromBody] int id)
        {
            _repository.UpdateContract(id);
            return Ok();
        }

        [HttpGet("get")]
        public List<TimeSheets.Controllers.Models.Contract> GetAllContracts()
        {
            List<TimeSheets.Controllers.Models.Contract> contracts = _repository.GetAllContaract();
            return contracts;
        }

        [HttpGet("get")]
        public TimeSheets.Controllers.Models.Contract GetAllContracts([FromBody] int id)
        {
            TimeSheets.Controllers.Models.Contract contract = _repository.SearchContract(id);
            return contract;
        }

       
    }
}
