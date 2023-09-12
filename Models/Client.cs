using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ctrlspec.Models
{
    public class Client
    {


        [Key]
         public int C_Id { get; set; }

         [ForeignKey("ApplicationList")]
        public int AppId { get; set; }
        public string? C_Name { get; set; }
        public string? C_Email { get; set; }
        
    }
}