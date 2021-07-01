using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Interfaces
{
    public interface ICustomFieldMapperService
    {
        int MapRatings(IEnumerable<Rating> ratings);
    }
}
