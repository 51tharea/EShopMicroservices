﻿using Microsoft.AspNetCore.Mvc;
using System;
using Web.Models.Store;

namespace Server.Controllers
{
    [Route("api/v1/products")]
    public class ProductsController : Controller
    {
        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult FindProduct(Guid id)
        {
            var model = new ShowProductViewModel
            {
                Id = Guid.NewGuid(),
                Title = "qqqq",
                Description = "rr r"
            };
            return Ok(model);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public IActionResult DeleteProduct(Guid id)
        {
            return Ok();
        }
    }
}