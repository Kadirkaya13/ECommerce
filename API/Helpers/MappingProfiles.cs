using API.Core.DbModel;
using API.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(x=>x.Brand,y=>y.MapFrom(z=>z.Brand.Name))
                .ForMember(x => x.ProductType, y => y.MapFrom(z => z.ProductType.Name))
                .ForMember(x => x.PictureUrl, y => y.MapFrom<ProductUrlResolver>());
        }
    }
}
