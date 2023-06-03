using AutoMapper;
using Lasmart.Business.Models;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Business.Mapping
{
    public class CircleMapper : Profile
    {
        public CircleMapper()
        {
            CreateMap<CircleEntity, CircleBusinessModel>()
                .ReverseMap();
        }
    }
}
