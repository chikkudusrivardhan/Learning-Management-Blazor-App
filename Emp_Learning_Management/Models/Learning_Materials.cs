using System.ComponentModel.DataAnnotations;

namespace Emp_Learning_Management.Models
{
    public class Learning_Materials
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        


    }
}
