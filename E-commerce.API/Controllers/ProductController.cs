using E_commerce.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_commerce.API.Controllers
{
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get(string query)
        {

            return Ok();
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProductModel createProduct)
        {
            if(createProduct.Description.Length > 100)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new {id = createProduct.Id}, createProduct);
        }

        [HttpPut("{id}")]
        public IActionResult Put( int id, [FromBody] UpdateProductModel updateProduct)
        {
            if (updateProduct.Description.Length > 100)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment (int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        [HttpPut("{id}/AwaitingPayment")]
        public IActionResult AwaitingPayment(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/Paid")]
        public IActionResult Paid(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/Sent")]
        public IActionResult Sent(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/Delivered")]
        public IActionResult Delivered(int id)
        {
            return NoContent();
        }
    }
}
