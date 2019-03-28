using System.ComponentModel.DataAnnotations;

namespace validation
{
    public class PersonDto
    {
        [Required]
        public string Name { get; set; }
        [Range(18, 99)]
        public int Age { get; set; }
    }
}