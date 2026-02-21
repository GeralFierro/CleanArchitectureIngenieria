using CleanArchitecture.Application.Dto;
using CleanArchitecture.Application.Interface;
using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services.Almacen
{
    public class CategoriaServices : ICategoriaServices
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaServices(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public List<CategoryDto> getAllCategory()
        {
            IEnumerable<Categoria> categoria = _categoriaRepository.GetAll();

            return MapearCategoria(categoria);
        }

        public List<CategoryDto> MapearCategoria(IEnumerable<Categoria> categorias)
        {
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            foreach (var categoria in categorias)
            {
                CategoryDto categoryDto = new CategoryDto
                {
                    Name = categoria.Name
                };
                categoryDtos.Add(categoryDto);
            }
            return categoryDtos;
        }
    }
}