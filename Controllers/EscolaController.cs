using System;
using Microsoft.AspNetCore.Mvc;

namespace aula_18_11.Controllers
{
        [ApiController]
        [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new {
                nome = "Etec Adolpho Berezin", 
                anoFundacao = 1995,
                cidade = "Mongaguá"
            };

        }
    
    }
}