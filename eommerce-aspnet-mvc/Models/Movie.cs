using eommerce_aspnet_mvc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eommerce_aspnet_mvc.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        [ForeignKey("CinameId")]
        public int CinemaId { get; set; }
        public virtual Cinema Cinemas { get; set; }
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }
        public virtual Producer Producers { get; set; }
        public virtual List<Actor_Movie> Actors_Movies { get; }
    }
}
