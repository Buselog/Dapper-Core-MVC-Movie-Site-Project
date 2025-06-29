namespace FilmFusionDapperCoreMVCProject.Models
{
    public class MovieActor
    {
        public int MovieActorId { get; set; }
        public string CharacterName { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
   

    }
}
