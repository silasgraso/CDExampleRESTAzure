namespace CDExampleRESTAzure.Model
{
    public class Game
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? NumberOfPlayers { get; set; }

        public Game()
        {
            
        }

        public override string ToString()
        {
            return $"{Name}, {NumberOfPlayers}";
        }

        public void ValidateName()
        {
            if (Name == null)
            {
                throw new ArgumentNullException();
            }
            if (Name.Length < 2) 
            {
                throw new ArgumentException();                                
            }
        }

        public void ValidateNumberOfPlayers()
        {
            if (NumberOfPlayers == null)
            {
                throw new ArgumentNullException();
            }
            if (NumberOfPlayers < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void Validate()
        {
            ValidateName();
            ValidateNumberOfPlayers();
        }
        

    }
}
