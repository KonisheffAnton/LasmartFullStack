using AutoMapper;
using Lasmart.Business.Interfaces;
using Lasmart.Business.Models;
using Lasmart.DataAccessLayer.Entities;
using Lasmart.DataAccessLayer.Interfaces;

namespace Lasmart.Business.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentService(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CommentBusinessModel>> GetAllCommentsAsync()
        {
            var CommentEntityList = await _unitOfWork.CommentRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CommentBusinessModel>>(CommentEntityList);
        }

        public async Task DeleteCommentAsync(CommentBusinessModel CommentBusinessModel)
        {
            var CommentEntity = _mapper.Map<CommentEntity>(CommentBusinessModel);
            _unitOfWork.CommentRepository.Delete(CommentEntity);

            await _unitOfWork.SaveChangesAsync();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}