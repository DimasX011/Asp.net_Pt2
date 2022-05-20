using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.Services;

namespace TimeSheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DBController : ControllerBase
    {
        public UserRepository _Urep;

        public DBController( UserRepository repo)
        {
            _Urep = repo;
        }

        [HttpGet("get")]
        public IEnumerable<TimeSheets.DAL.Entities.Contract> GetContract()
        {
            var x = _Urep.Get();
            Console.WriteLine(x);
            return x;
        }

        [HttpPost("create")]
        public IActionResult AddCont(TimeSheets.DAL.Entities.Contract contract)
        {
            var x = _Urep.Add(contract);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteContact(int id)
        {
            var x = _Urep.Delete(id);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update(TimeSheets.DAL.Entities.Contract contract)
        {
            var x = _Urep.Update(contract);
            return Ok();
        }
    }
}
