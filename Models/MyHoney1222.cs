using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public partial class MyHoney1222
    {
        [Key]
        public int Id { get; set; }
        public string a { set; get; }
        public int b { get; set; }
    }
}