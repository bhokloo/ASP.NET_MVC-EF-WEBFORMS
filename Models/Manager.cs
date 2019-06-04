namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Manager
    {
        [Key]
        public int Id { get; set; }
        public string mname { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
