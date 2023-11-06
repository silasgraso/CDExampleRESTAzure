namespace CDExampleRESTAzure.Model
{
    public class GamesRepository
    {
        private readonly List<Game> _games = new List<Game>();
        private int _nextId = 1;
        public GamesRepository()
        {
            _games.Add(new Game { Id = _nextId++, Name = "Chess", NumberOfPlayers = 2 });
            _games.Add(new Game { Id = _nextId++, Name = "Monopoly", NumberOfPlayers = 4 });
            _games.Add(new Game { Id = _nextId++, Name = "Risk", NumberOfPlayers = 6 });
        }
        public IEnumerable<Game> GetAll()
        {
            return _games;
        }
        public Game GetById(int id)
        {
            return _games.FirstOrDefault(g => g.Id == id);        
        }
        public Game Add(Game game)
        {
            game.Id = _nextId++;
            _games.Add(game);
            return game;
        }
        public void Update(Game game)
        {
            var existingGame = GetById(game.Id);
            if (existingGame == null)
            {
                throw new ArgumentException($"Game with id {game.Id} not found");
            }
            existingGame.Name = game.Name;
            existingGame.NumberOfPlayers = game.NumberOfPlayers;
        }
        public void Delete(int id)
        {
            var existingGame = GetById(id);
            if (existingGame == null)
            {
                throw new ArgumentException($"Game with id {id} not found");
            }
            _games.Remove(existingGame);
        }
        
    }
}
