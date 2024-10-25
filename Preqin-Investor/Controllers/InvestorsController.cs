using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Preqin_Investor.Service;
using Preqin_Investor.Service.Models;

namespace Preqin_Investor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorsController : ControllerBase
    {
        private readonly IJsonFileReader _jsonFileReader;
        const string FILE_PATH = "Data/formatted-data.json";
        public InvestorsController(IJsonFileReader jsonFileReader)
        {
            _jsonFileReader = jsonFileReader;
        }


        // GET: api/investor
        [HttpGet]
        public ActionResult<IEnumerable<Investor>> GetInvestors()
        {
            var investors = _jsonFileReader.ReadJsonFile<Investor>(FILE_PATH);
            return investors;
        }
    }
}
