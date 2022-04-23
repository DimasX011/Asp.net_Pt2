using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.DAL.Models;
using TimeSheets.DAL.Repositories;

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
        public IActionResult Create([FromBody] Contract request)
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
        public List<Contract> GetAllContracts()
        {
            List<Contract> contracts = _repository.GetAllContaract();
            return contracts;
        }

        [HttpGet("get")]
        public Contract GetAllContracts([FromBody] int id)
        {
            Contract contract = _repository.SearchContract(id);
            return contract;
        }
    }
}
