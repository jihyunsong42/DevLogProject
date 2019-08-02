using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace devloggerWebAPI.Models
{
    public class DevLog
    {
        [Key]
        public string Id { get; set; }

        //[Column("Text")]
        public string Text { get; set; }
        
        //[Column("Date")]
        public DateTime Date { get; set; }
    }
}
