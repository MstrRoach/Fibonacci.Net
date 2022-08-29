using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci_Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {


        /// <summary>
        /// Obtiene la secuencia fibonacci para un indica dado
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        [HttpGet("{index:int}")]
        public IActionResult GetSequence([FromRoute] int index)
        {
            if (!IsValidIndex(index))
                return StatusCode(StatusCodes.Status400BadRequest, "Index should between 0 and 199");

            long last = 0;
            long current = 0;
            long next = 1;

            for (int iteration = 0; iteration <= index; iteration++)
            {
                last = current;
                current = next;
                next = last + current;
            }

            return StatusCode(StatusCodes.Status200OK, last);
        }

        /// <summary>
        /// Validacion para los numeros que sobrepasen
        /// el tipo long 0 int64
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsValidIndex(int index)
            => (index >= 0) && (index < 200);


    }
}
