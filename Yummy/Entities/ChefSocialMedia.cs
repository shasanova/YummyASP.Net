using System;
namespace Yummy.Entities
{
	public class ChefSocialMedia
	{
        public int Id { get; set; }
        public string FbUrl { get; set; }
        public string IgUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InUrl { get; set; }
        public int ChefId { get; set; }
        public Chef Chef { get; set; }

    } 
}

