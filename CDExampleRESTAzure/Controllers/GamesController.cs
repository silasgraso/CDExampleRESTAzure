using Microsoft.AspNetCore.Mvc;
using CDExampleRESTAzure.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CDExampleRESTAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly GamesRepository _gamesRepository = new GamesRepository();

        public GamesController(GamesRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;            
        }

        // GET: api/<GamesController>
        [HttpGet]
        public ActionResult<IEnumerable<GamesRepository>> Get()
        {
            return Ok(_gamesRepository.GetAll());
        }

        // GET api/<GamesController>/5
        [HttpGet("{id}")]
        public ActionResult<Game> Get(int id)
        {
            return Ok(_gamesRepository.GetById(id));
        }

        // POST api/<GamesController>
        [HttpPost]
        public ActionResult<Game> Post([FromBody] Game newGame)
        {
            return Ok(_gamesRepository.Add(newGame));
        }



        // DELETE api/<GamesController>/5
        [HttpDelete("{id}")]
        public ActionResult<Game> Delete(int id)
        {
            _gamesRepository.Delete(id);
            return Ok();
        }
    }
}
