//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalCaseStudy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class CourseDetail
    {
        [Required(ErrorMessage ="Plese enter Course ID")]
        [Range(1,9999,ErrorMessage ="Please enter positive value")]
        public int courseid { get; set; }
        [Required(ErrorMessage = "Plese choose Course")]
        public string course { get; set; }
        [Required(ErrorMessage = "Plese enter Duration")]
        [Range(1, 9999, ErrorMessage = "Please enter positive value")]
        public Nullable<int> duration { get; set; }
        [Required(ErrorMessage = "Plese enter Students")]
        [Range(1, 9999, ErrorMessage = "Please enter positive value")]
        public Nullable<int> noofstd { get; set; }
        [Required(ErrorMessage = "Plese enter Cost")]
        [Range(1, 999999, ErrorMessage = "Please enter positive value")]
        public Nullable<int> cost { get; set; }
    }
}