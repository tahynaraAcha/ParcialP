using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webamigo.Models
{
    public enum TypeList
    {
        Amalia,
        Amanda,
        Angel,
        Andres,
        Angelina

    }
    public class friend
    {
        [Required]
        public string Name { get; set; }
        [Key]
        public TypeList List { get; set; }
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }




    }
}