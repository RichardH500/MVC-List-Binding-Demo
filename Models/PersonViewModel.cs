using System;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
	public class PersonViewModel
	{
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        public List<Hobby> Hobbies { get; set; } = new List<Hobby>();
    }

    public class Hobby
    {
        public string Name { get; set; }

        public HobbyType Type { get; set; }
    }

    public enum HobbyType
    {
        Indoor,
        Outdoor
    }
}

