using CleanArchitecture.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Interface
{
    public interface ICategoriaServices
    {
        List<CategoryDto> getAllCategory();
    }
}
