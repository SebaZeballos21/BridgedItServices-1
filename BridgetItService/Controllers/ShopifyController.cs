﻿using BridgetItService.Contracts;
using BridgetItService.Models;
using Microsoft.AspNetCore.Mvc;
using ShopifySharp;

namespace BridgetItService.Controllers
{
    [Route("api/shopify")]
    [ApiController]
    public class ShopifyController : ControllerBase
    {
        private readonly IShopifyService _shopifyService;
        public ShopifyController(IShopifyService shopifyService)
        {
            _shopifyService = shopifyService;
        }
        [HttpPost("/products")]
        public async Task<IActionResult> PostProducts(ShopifyProductModleIn products)
        {
            return Ok(await _shopifyService.PublishProducts(products.Products));
        }
    }
}
