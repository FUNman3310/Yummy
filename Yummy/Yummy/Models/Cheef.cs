using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yummy.Models
{
    public class Cheef
    {
        public int Id { get; set; }

        public string Image { get; set; }
        [StringLength(maximumLength:35)]
        public string FullName { get; set; }
        [StringLength(maximumLength: 200)]
        public string Description { get; set; }
        [StringLength(maximumLength: 50)]
        public string Job { get; set; }

        public string twitter { get; set; }
        public string facebook { get; set; }
        public string instagram { get; set; }
        public string linkedin { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


    }
}
