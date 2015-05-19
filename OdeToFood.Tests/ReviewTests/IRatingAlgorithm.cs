using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Tests.ReviewTests
{
    interface IRatingAlgorithm
    {

        RateResult Compute(IList<Review> reviews);
    }
}
