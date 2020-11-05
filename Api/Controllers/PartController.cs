using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Interfaces;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Api.DTOs;
using Api.Specifications;

namespace Api.Controllers
{
    public class PartController : BaseApiController
    {
        private readonly IGenericRepository<Part> _partRepo;
        private readonly IGenericRepository<PartType> _partTypeRepo;
        private readonly IMapper _mapper;

        public PartController(IGenericRepository<Part> partRepo, IGenericRepository<PartType> partTypeRepo, IMapper mapper)
        {
            _partRepo = partRepo;
            _partTypeRepo = partTypeRepo;
            _mapper = mapper;
        }

        //Parts
        [HttpPost]
        public async Task<ActionResult<Part>> AddPartType(Part part)
        {
            part.Id = 0;
            return Ok(await _partRepo.AddAsync(part));
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<PartDTO>> GetPart(int id)
        {
            var spec = new PartsWithTypesSpecification(id);

            var part = await _partRepo.GetEntityWithSpec(spec);

            if (part == null) return NotFound();//new ApiResponse(404));

            return _mapper.Map<Part, PartDTO>(part);
        }

        [HttpPut]
        public async Task<ActionResult<Part>> UpdatePart(Part part)
        {
            return Ok(await _partRepo.UpdateAsync(part));
        }

        [HttpDelete]
        public async Task<ActionResult<Part>> RemovePart(Part part)
        {
            return Ok(await _partRepo.RemoveAsync(part));
        }


        //PartTypes
        [HttpPost("types")]
        public async Task<ActionResult<PartType>> AddPartType(PartType type)
        {
            type.Id = 0;
            return Ok(await _partTypeRepo.AddAsync(type));
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<PartType>>> GetPartTypes()
        {
            return Ok(await _partTypeRepo.ListAllAsync());
        }

        [HttpGet("types/{id}")]
        public async Task<ActionResult<PartType>> GetPartTypeById(int id)
        {
            return Ok(await _partTypeRepo.GetByIdAsync(id));
        }

        [HttpPut("types")]
        public async Task<ActionResult<PartType>> UpdatePartType(PartType type)
        {
            return Ok(await _partTypeRepo.UpdateAsync(type));
        }

        [HttpDelete("types")]
        public async Task<ActionResult<PartType>> RemovePartType(PartType type)
        {
            return Ok(await _partTypeRepo.RemoveAsync(type));
        }

    }
}
