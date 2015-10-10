using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvsStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }
        public string Contents { get; set; }
        [Required()]
        [Display(Name = "Email Adress")]
        [DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}
