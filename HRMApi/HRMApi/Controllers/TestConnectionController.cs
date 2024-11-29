using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;

namespace HRMApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestConnectionController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TestConnectionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnecttion");

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT 1", connection))
                    {
                        var result = command.ExecuteScalar();
                        return Ok("Connection successful. Test query result: " + result);
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Connection failed: " + ex.Message);
            }
        }
    }
}