using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Tests.ReviewTests
{
    class RestaurantRater
    {
        public RestaurantRater(Restaurant restaurant)
        {

        }

        public RateResult ComputeOverRate(int p)
        {
            var result = new RateResult();
            result.Rating = 4;
            return result;
        }
    }
}
