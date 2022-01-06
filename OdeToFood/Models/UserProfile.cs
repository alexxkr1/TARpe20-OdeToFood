using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OdeToFood.Models
{
    public class UserProfile: IdentityUser 
    {
		[PersonalData]
		public string FavoriteRestaurant { get; set; }
	}
}
