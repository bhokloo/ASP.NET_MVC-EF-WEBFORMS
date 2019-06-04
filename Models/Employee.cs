namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Employee
    {
        [Key]
        public int eId { get; set; }
        public string ename { get; set; }
        public string eaddress { get; set; }
        public int ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public Manager Manager { get; set; }
    }
}
