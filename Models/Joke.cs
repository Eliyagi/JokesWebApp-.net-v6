namespace JokesWebApp.Models
{
    public class Joke
    {
        public int id { get; set; }

        public string JokeQuestion { get; set; }

        public string JokeAnswer { get; set;}

        //method constructor
        public Joke()
        {
            
        }
    }
}
