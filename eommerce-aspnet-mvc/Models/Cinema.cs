using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        public Cinema()
        {
            this.Movies = new HashSet<Movie>();
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
