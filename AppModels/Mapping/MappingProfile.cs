using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppModels;
using AppModels.Entities;
using AppModels.DTOs;

namespace AppModels.Mapping
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Producto, ProductoDTO>().ReverseMap();
			CreateMap<Producto, CreateProductoDTO>().ReverseMap();
			CreateMap<Producto, UpProductoDTO>().ReverseMap();

			CreateMap<Categoria, CategoriaDTO>().ReverseMap();
			CreateMap<Categoria, CreateCategoriaDTO>().ReverseMap();
		}
	}
}
