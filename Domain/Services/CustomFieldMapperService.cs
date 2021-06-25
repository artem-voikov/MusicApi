﻿using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Services
{
    public class CustomFieldMapperService : ICustomFieldMapperService
    {
        public int MapRatings(IEnumerable<Rating> ratings)
            => ratings.Sum(x => x.Value) / ratings.Count();
    }
}
