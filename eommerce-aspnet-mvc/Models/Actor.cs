using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eommerce_aspnet_mvc.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        public virtual List<Actor_Movie> Actors_Movies { get; }
    }
}
