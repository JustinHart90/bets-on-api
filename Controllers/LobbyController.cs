using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bets_on_api.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class LobbyController : ControllerBase
    {
        [HttpGet]
        public string GetBets() {
            return "OK.";
        }
    }
}
