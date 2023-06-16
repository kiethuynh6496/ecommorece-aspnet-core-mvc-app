using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eommerce_aspnet_mvc.Models
{
    public class Producer
    {
        public Producer()
        {
            this.Movies = new HashSet<Movie>();
        }
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
