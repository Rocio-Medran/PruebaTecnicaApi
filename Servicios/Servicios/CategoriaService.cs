using AutoMapper;
using Servicios.Interfaces;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;
using AppModels.DTOs;
using AppModels.Entities;

namespace Servicios.Servicios
{
	public class CategoriaService : ICategoriaService
	{
		private readonly IMapper _mapper;
		private readonly ICategoriaRepository _repository;

		public CategoriaService(IMapper mapper, ICategoriaRepository repository)
		{
			_mapper = mapper;
			_repository = repository;
		}

		public async Task<IEnumerable<CategoriaDTO>> GetCategoriasAsync()
		{
			var categorias = await _repository.GetAllAsync();
			return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
		}

		public async Task<CategoriaDTO?> GetCategoriaByIdAsync(int id)
		{
			var categoria = await _repository.GetByIdAsync(id);
			return categoria == null ? null : _mapper.Map<CategoriaDTO>(categoria);
		}

		public async Task<CategoriaDTO> AddCategoriaAsync(CreateCategoriaDTO categoriaDTO)
		{
			var categoria = _mapper.Map<Categoria>(categoriaDTO);
			await _repository.AddAsync(categoria);
			return _mapper.Map<CategoriaDTO>(categoria);
		}

		public async Task<bool> UpdateCategoriaAsync(CreateCategoriaDTO categoriaDTO, int id)
		{
			var categoria = await _repository.GetByIdAsync(id);
			if (categoria == null) return false;

			_mapper.Map(categoriaDTO, categoria);
			await _repository.UpdateAsync(categoria, id);
			return true;
		}

		public async Task<bool> DeleteCategoriaAsync(int id)
		{
			var categoria = await _repository.GetByIdAsync(id);
			if (categoria == null) return false;

			await _repository.DeleteAsync(id);
			return true;
		}
	}
}
