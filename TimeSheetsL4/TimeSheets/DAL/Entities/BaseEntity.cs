using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.DAL.Entities
{
    public class BaseEntity<TUniqueId> where TUniqueId : struct
    {
        [Column("id")]
        public TUniqueId Id { get; set; }

        [Column("isdeleted")]
        public bool IsDeleted { get; set; }
    }

    [Table("contract", Schema = "vma")]
    public sealed class Contract : BaseEntity<int>
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

    }
}
