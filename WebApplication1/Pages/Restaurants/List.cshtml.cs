using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Messeage { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public IRestaurantData restaurantData { get; }

        private readonly IConfiguration config;

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            Messeage = config["Message"];
            Restaurants = restaurantData.GetAll();
        }
    }
}