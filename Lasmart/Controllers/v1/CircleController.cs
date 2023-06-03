using AutoMapper;
using Lasmart.Business.Interfaces;
using Lasmart.Business.Models;
using Lasmart.Dto.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lasmart.WebApi.Controllers.v1
{
    [Route("api/v1/")]
    public class CircleController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly ICircleService _CircleService;

        public CircleController(IMapper mapper, ICircleService CircleService)
        {
            _mapper = mapper;
            _CircleService = CircleService;
        }


        [HttpGet]
        [Route("GetAllCircles")]
        public async Task<IEnumerable<CircleDto>> GetAllCircles()
        {
            var CircleDtoList = await _CircleService.GetAllCirclesAsync();
            var dumb = _mapper.Map<IEnumerable<CircleDto>>(CircleDtoList);
            return dumb;
        }

        [HttpDelete]
        [Route("DeleteCircle")]
        public async Task<IActionResult> DeleteCircle([FromBody]CircleDto CircleRequest)
        {
            var CircleBusinessModel = _mapper.Map<CircleBusinessModel>(CircleRequest);
            await _CircleService.DeleteCircleAsync(CircleBusinessModel);

            return Ok();
        }
    }
}
