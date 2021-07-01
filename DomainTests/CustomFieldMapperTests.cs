using Domain.Entities;
using Domain.Interfaces;
using Domain.Services;
using NUnit.Framework;
using System;

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

        [Test]
        public void MapRatings_ZeroRatings_Zero()
        {
            var ratings = new Rating[0];

            var result = target.MapRatings(ratings);

            Assert.AreEqual(0, result);
        } 
        
        [Test]
        public void MapRatings_NoRatings_Zero()
        {
            var result = target.MapRatings(null);

            Assert.AreEqual(0, result);
        }
        
        [Test]
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
