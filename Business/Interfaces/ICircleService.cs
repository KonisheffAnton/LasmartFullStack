using Lasmart.Business.Models;

namespace Lasmart.Business.Interfaces
{
    public interface ICircleService : IDisposable
    {

        public Task DeleteCircleAsync(CircleBusinessModel CircleBusinessModel);

        public Task<IEnumerable<CircleBusinessModel>> GetAllCirclesAsync();

    }
}
