using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities.Base
{
    public class EntityBase
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(120)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreate { get; set; } = DateTime.Now;
    }
}
