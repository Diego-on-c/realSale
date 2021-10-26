using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WSVenta.Models;
using WSVenta.Models.Response;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WSVenta.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            Response oResponse = new Response();
            try
            {
                using (VentaRealContext db = new VentaRealContext())
                {
                    var lst = db.Clients.ToList();
                    oResponse.Ok = 0;
                    oResponse.Data = lst;
                    
                }
            }
            catch(Exception ex)
            {
                oResponse.Messaje = ex.Message; 
            }
            return Ok(oResponse);

        }
        
    }
}
