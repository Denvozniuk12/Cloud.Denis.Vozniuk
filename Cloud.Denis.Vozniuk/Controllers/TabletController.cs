using Cloud.Denis.Vozniuk.Core.Models;
using Cloud.Denis.Vozniuk.Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Cloud.Denis.Vozniuk.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TabletController : Controller
    {
        private readonly ITabletService _tabletServices;
        public TabletController(ITabletService tabletService)
        {
            _tabletServices = tabletService;
        }

        [HttpGet]
        public IActionResult GetTablets()
        {
            return Ok(_tabletServices.GetTablets());
        }

        [HttpGet("{id}", Name = "GetTablet")]
        public IActionResult GetTablet(string id)
        {
            return Ok(_tabletServices.GetTablet(id));
        }

        [HttpPost]
        public IActionResult AddTablet(Tablet tablet)
        {
            _tabletServices.AddTablet(tablet);
            return CreatedAtRoute("GetTablet", new { id = tablet.Id }, tablet);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTablet(string id)
        {
            _tabletServices.DeleteTablet(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateTablet(Tablet tablet)
        {
            return Ok(_tabletServices.UpdateTablet(tablet));
        }
    }
}
