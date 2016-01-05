using Microsoft.AspNet.Http;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class User
    {
            [Required]
            [MinLength(4)]
            public string Name { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
            [Required]
            [FileExtensions(Extensions = "jpg,jpeg")]
            public IFormFile File { get; set; }

        }
    }
