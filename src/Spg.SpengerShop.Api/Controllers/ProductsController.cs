﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spg.SpengerShop.Domain.Interfaces;
using Spg.SpengerShop.Domain.Model;

namespace Spg.SpengerShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IReadOnlyProductService _readOnlyProductService;

        public ProductsController(IReadOnlyProductService readOnlyProductService)
        {
            _readOnlyProductService = readOnlyProductService;
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            try
            {
                IEnumerable<Product> result = _readOnlyProductService.GetAll();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost()]
        public IActionResult Save() 
        {
            return Ok();
        }
    }
}