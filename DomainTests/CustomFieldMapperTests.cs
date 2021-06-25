using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTests
{
    [TestFixture]
    class CustomFieldMapperTests
    {
        private Random random;
        private ICustomFieldMapperService target;

        public CustomFieldMapperTests()
        {
            random = new Random();
            target = new CustomFieldMapperService();
        }

        [TestCase]
        public void MapRatings_ValidRatings_GivesAverageRating()
        {
            //Arrange
            var ratings = new Rating[]
            {
                new Rating{ Value = 10 },
                new Rating{ Value = 20 },
                new Rating{ Value = 30 },
                new Rating{ Value = 40 },
            };
            
            //Act
            var result = target.MapRatings(ratings);

            //Assert
            Assert.AreEqual((10 + 20 + 30 + 40) / 4, result);
        }
    }
}
