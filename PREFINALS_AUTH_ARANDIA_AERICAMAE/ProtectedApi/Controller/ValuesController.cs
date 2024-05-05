using Microsoft.AspNetCore.Mvc;
using System;

namespace ProtectedApi
{
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {
        private readonly string _owner = "Aerica Mae Arandia";
        private readonly Random _random = new Random();
        private readonly string[] _thingsAboutOwner = new[]
        {
            "I love Taylor Swift",
            "I love cooking",
            "I have a dog and his name is Olaf",
            "I love watching sci-fi and action movies",
            "I love butterflies",
            "My favourite color is purple, but i love wearing black shirts",
            "I love online shopping! It is my stress reliever :)",
            "I want to be a surgeon",
            "I'm 21 y/o",
            "I love watching Grey's Anatomy",
        };

        [HttpGet("about/me")]
        public IActionResult AboutMe()
        {
            var thing = _thingsAboutOwner[_random.Next(_thingsAboutOwner.Length)];
            return Ok(thing);
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return Ok(_owner);
        }

        [HttpPost("about")]
        public IActionResult About([FromBody] NameModel model)
        {
            return Ok($"Hi {model.Name} from {_owner}");
        }
    }

    public class NameModel
    {
        public string? Name { get; set; }
    }
}