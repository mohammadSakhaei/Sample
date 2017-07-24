using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleLogin.Models
{
    public partial class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Id is Required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(maximumLength:20,ErrorMessage = "Name max chars are 20!")]
        public string Name { get; set; }
        public int? Age { get; set; }

        [DefaultValue(false)]
        public bool? IsDeleted { get; set; }

        public Profile()
        {
            IsDeleted = false;
        }


    }
}
