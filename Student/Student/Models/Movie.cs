using System.ComponentModel.DataAnnotations;
namespace Student.Models
{
    public class Movie
    {
        public String Fullname { get; set; }
        public String Address { get; set; }
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set;}

    }
}
