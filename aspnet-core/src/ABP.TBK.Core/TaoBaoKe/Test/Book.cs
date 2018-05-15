using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABP.TBK.TaoBaoKe.Test
{
    public class Book : Entity<long> 
    {

        [Required]
        [MaxLength(32)]
        public virtual string Name { get; set; }

        [Required]
        [MaxLength(32)]
        public virtual string Surname { get; set; }

        [MaxLength(255)]
        public virtual string EmailAddress { get; set; }
    }
}
