using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Almeida.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x =>
            {
                x.AddProfile(new DomainToViewModel());
                x.AddProfile(new ViewModelToDomain());
            });
        }
    }
}
