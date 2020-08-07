using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("Categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public string Get()
        {
            return "Get";
        }

        [HttpGet]
        [Route("{Id:int}")]
        public string GetById(int Id)
        {
            return "Get by Id " + Id.ToString();
        }

        [HttpPost]
        [Route("")]
        public Category Post([FromBody] Category model)
        {
            return model;
        }

        [HttpPut]
        [Route("{id:int}")]
        public Category Put(int id, [FromBody]Category model)
        {
            if (model.Id == id)
            {
                return model;
            }

            return null;
        }

        [HttpDelete]
        [Route("{id:int}")]
        public string Delete()
        {
            return "Delete";
        }
    }
}
