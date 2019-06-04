using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApplication1.Models
{
    public class MyHoney
    {
        [Key]
        public int Id { get; set; }
        public string employee { get; set; }
        public int manid { get; set; }

        [ForeignKey("manid")]
        public MyHoney manofall { get; set; }
    }
}