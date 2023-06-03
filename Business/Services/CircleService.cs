using AutoMapper;
using Lasmart.Business.Interfaces;
using Lasmart.Business.Models;
using Lasmart.DataAccessLayer.Entities;
using Lasmart.DataAccessLayer.Interfaces;

namespace Lasmart.Business.Services
{
    public class CircleService : ICircleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CircleService(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CircleBusinessModel>> GetAllCirclesAsync()
        {
            var CircleBusinessModelList = _mapper.Map<IEnumerable<CircleBusinessModel>>(await _unitOfWork.CircleRepository.GetAllAsync());

            return CircleBusinessModelList;
        }

        public async Task DeleteCircleAsync(CircleBusinessModel CircleBusinessModel)
        {
            var CircleEntity = _mapper.Map<CircleEntity>(CircleBusinessModel);
            _unitOfWork.CircleRepository.Delete(CircleEntity);

            await _unitOfWork.SaveChangesAsync();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

    }
}