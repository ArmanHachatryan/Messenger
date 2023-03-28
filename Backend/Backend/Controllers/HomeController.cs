﻿using Backend.Models;
using Backend.Models.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IPostgreDbContext _context;

        public HomeController(IPostgreDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetData()
        {

            AppData model = new AppData()
            {
                Id = Guid.NewGuid(),
                Text = "Test",
                Status = 1,
                PhoneNumber = "+77777777",
                DateTime = DateTime.Now,
                Sender = "Alex"

            };
            _context.Data.Add(model);
            _context.Save();
            return Ok("Good");
        }

    }
}
