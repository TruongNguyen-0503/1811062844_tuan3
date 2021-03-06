using _1811062844_Nguyencaoanhtruong_Tuan3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1811062844_Nguyencaoanhtruong_Tuan3.ViewModels
{
    public class CourseViewModel
    {
        [Required]//ràng buộc dữ liệu 
        public string Place { get; set; }
        [Required]
        public string Date{ get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable< Category > Categories { get; set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(String.Format("{0} {1}", Date, Time));
        }
    }
}