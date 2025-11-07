namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>() {
            new Employee() {
                Id = "21",
                Name = "Mette Bangsbo",
                Email = "meba@ibas.dk",
                Department = new Department() {
                    Id = 1,
                    Name = "Salg"
                }
            },
            new Employee() {
                Id = "22",
                Name = "Hans Merkel",
                Email = "hame@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "23",
                Name = "Karsten Mikkelsen",
                Email = "kami@ibas.dk",
                Department = new Department() {
                    Id = 2,
                    Name = "Support"
                }
            },
            new Employee() {
                Id = "30",
                Name = "Elias Petersen",
                Email = "elias@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "It"
                }
            },
            new Employee() {
                Id = "31",
                Name = "Bjarne Madsen",
                Email = "bjar@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "It"
                }
            },
            new Employee() {
                Id = "32",
                Name = "Mikkel Mikkelsen",
                Email = "mikkel@ibas.dk",
                Department = new Department() {
                    Id = 3,
                    Name = "It"
                }
            },
            new Employee() {
                Id = "40",
                Name = "Pia Nykjær",
                Email = "pia@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantinen"
                }
            },
            new Employee() {
                Id = "41",
                Name = "Susanne Rasmussen",
                Email = "sus@ibas.dk",
                Department = new Department() {
                    Id = 4,
                    Name = "Kantinen"
                }
            }

        };
            return employees;
        }
    }
}