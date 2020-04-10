using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesStudent.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string name { get; set; }


        [Display(Name = "Birthday")]
        public DateTime birthDay { get; set; }


        [Display(Name = "Group number")]
        public int groupNumber { get; set; }

        public string code { get; set; }

    }
}
