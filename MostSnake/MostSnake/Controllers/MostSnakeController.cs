using MostSnake.Models;
using System.Web.Http;

namespace MostSnake.Controllers
{
    public class MostSnakeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetMostSnakeResultInit()
        {
            Player playerOne = new Player("Gorgony");
            playerOne.PlayerAction = "NONE";

            Player playerTwo = new Player("SvanRijswijk");
            playerTwo.PlayerAction = "NONE";

            MostSnakeResponse mostSnakeResponse = new MostSnakeResponse("INIT", playerOne, playerTwo);

            return Ok(mostSnakeResponse);
        }

        [HttpGet]
        public IHttpActionResult GetMostSnakeResultUpdate()
        {
            Player playerOne = new Player("Gorgony");
            playerOne.PlayerAction = "RIGHT";

            Player playerTwo = new Player("SvanRijswijk");
            playerTwo.PlayerAction = "LEFT";

            MostSnakeResponse mostSnakeResponse = new MostSnakeResponse("UPDATE", playerOne, playerTwo);

            return Ok(mostSnakeResponse);
        }
    }
}
