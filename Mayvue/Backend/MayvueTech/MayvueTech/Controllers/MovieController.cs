using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MayvueTech.Models;
using MayvueTech.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;



namespace MayvueTech.Controllers
{

    [ApiController]
    [Route("[controller]")]
    [EnableCors("Policy1")]
    public class MovieController : Controller
    {
        DB dao = new DB();
        [HttpGet(Name = "GetMovies")]
        public List<Movie> Get()
        {
            return dao.getListOfAllMovies();
            
        }
    }
}

