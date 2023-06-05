using System;
namespace Yummy.Entities
{
	public class Profession
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Chef> Chef { get; set; }
    }
}

