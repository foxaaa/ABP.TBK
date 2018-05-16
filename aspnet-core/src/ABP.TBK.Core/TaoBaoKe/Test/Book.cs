using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities;

namespace ABP.TBK.TaoBaoKe.Test
{
    public class Book : Entity<long>
    {
        [Required] [MaxLength(32)] public virtual string Name { get; set; }

        [Required] [MaxLength(32)] public virtual string Surname { get; set; }

        [MaxLength(255)] public virtual string EmailAddress { get; set; }
    }
}