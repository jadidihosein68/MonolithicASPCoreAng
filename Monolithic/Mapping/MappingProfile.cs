using AutoMapper;
using System.Linq;
using Monolithic.Model.DTO;
using Monolithic.Model;

namespace Monolithic.Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MonolitExampleModel, MonolitExampleModelDTO>();

        }
    }
}
