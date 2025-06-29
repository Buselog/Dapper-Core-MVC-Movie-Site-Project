namespace FilmFusionDapperCoreMVCProject.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title{ get; set; }
        public int ReleaseYear { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
    }
}
