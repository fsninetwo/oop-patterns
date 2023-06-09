﻿using Microsoft.AspNetCore.Mvc;
using OOP_Patterns.Services.IServices;

namespace OOP_Patterns.API.Controllers
{
    public class SingletonController : BaseController
    {
        private readonly ISingletonService _singletonService;

        public SingletonController(ISingletonService singletonService) 
        { 
            _singletonService = singletonService; 
        }

        [HttpGet]
        public async Task<IActionResult> GetMessage(string message)
        {
            return Ok(await _singletonService.GetSingletonMessageAsync(message));
        }
    }
}
