using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OJT_Management.Models
{
    public class Staff
    {
        public int Id { get; set; }
        [Display (Name="First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]

        public string? LastName { get; set; }
        public string? Title { get; set; }
        public string? Email { get; set; }
    }
}
