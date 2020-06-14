using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebApp.DBLayer.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get; set; }

        [ForeignKey("Director")]
        public int? DirectorId { get; set; }
        public Director Director { get; set; }

        [ForeignKey("FileStore")]
        public int? PosterId { get; set; }
        public FileStore Poster { get; set; }

        public string UserCreatorId{get;set;}

        [NotMapped]
        public bool IsOwner { get; set; }
    }
}
