using NUnit.Framework;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Tests
{         
    [TestFixture]
    public class ReviewControllerTests
    {
        [Test]
        public void Index_Action_Model_Is_Three_Review()
        {
            var db = new FakeDbContext();

            db.Reviews = new[]{
                new Review(),
                new Review(),
                new Review(),
                new Review(),
            }.AsQueryable();

            var controller = new ReviewController(db);
            var result = controller.Index() as ViewResults;
            var model = result.Model as IEnumerable<Review>;

            Assert.AreEqual(3, model.Count());
        }


    }
}
