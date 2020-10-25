using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OData.API.Models;

namespace OData.API.Controllers
{
    public class CategoriesController : ODataController
    {

        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
        {
            _context = context;
        }

       
        [HttpGet,EnableQuery]
        public IActionResult Get()
        {
            return Ok(_context.Categories);
        }



    }
}
