using AutoMapper;
using Lasmart.Business.Models;
using Lasmart.Dto.Models;

namespace Lasmart.Dto.Mapping
{
    public class CommentMapper : Profile
    {
        public CommentMapper()
        {
            CreateMap<CommentDto, CommentBusinessModel>()
                                .ForMember(dest => dest.CircleBusinessModelId, opt => opt.MapFrom(src => src.CircleDtoId))
                .ReverseMap();
        }
    }
}
