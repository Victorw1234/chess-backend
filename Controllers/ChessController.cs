using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChessController : ControllerBase
    {
        public string Index(string id)
        {

            return id;
        }
    }
}
