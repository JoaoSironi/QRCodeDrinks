using Microsoft.AspNetCore.Mvc;

namespace drinksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinksController
    {
        private readonly ILogger<DrinksController> _logger;

        public DrinksController(ILogger<DrinksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IList<Models.Drink> DrinksList()
        {
            return new List<Models.Drink>();
        }

        [HttpGet("{id}")]
        public IList<Models.Drink> FindDrink(string id)
        {
            return new List<Models.Drink>();
        }

        [HttpPost]
        public IList<Models.Drink> CreateDrink()
        {
            return new List<Models.Drink>();
        }

        [HttpPut("{id}")]
        public IList<Models.Drink> UpdateDrink(string id)
        {
            return new List<Models.Drink>();
        }


        [HttpDelete("{id}")]
        public IList<Models.Drink> DeleteDrink(string id)
        {
            return new List<Models.Drink>();
        }
    }
}
