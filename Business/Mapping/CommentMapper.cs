using AutoMapper;
using Lasmart.Business.Models;
using Lasmart.DataAccessLayer.Entities;

namespace Lasmart.Business.Mapping
{
    public class CommentMapper : Profile
    {
        public CommentMapper()
        {
            CreateMap<CommentEntity, CommentBusinessModel>()
                                .ForMember(dest => dest.CircleBusinessModelId, opt => opt.MapFrom(src => src.CircleEntityId))
                .ReverseMap();
        }
    }
}
