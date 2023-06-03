using AutoMapper;
using Lasmart.Business.Models;
using Lasmart.Dto.Models;

namespace Lasmart.Dto.Mapping
{
    public class CircleMapper : Profile
    {
        public CircleMapper()
        {
            CreateMap<CircleDto, CircleBusinessModel>().ReverseMap();
        }
    }
}
