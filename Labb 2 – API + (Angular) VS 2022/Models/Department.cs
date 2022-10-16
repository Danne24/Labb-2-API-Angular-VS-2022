using System.ComponentModel.DataAnnotations;

namespace Labb_2___API____Angular__VS_2022.Models
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
    }
}
