using AutoMapper;
using CrossCutting.Mappings;
using System;
using Xunit;

namespace Api.Service.Test
{
    public abstract class BaseTesteService
    {
        public IMapper Mapper { get; set; }

        public BaseTesteService()
        {
            Mapper = new AutoMapperFixture().GetMapper();
        }

        public class AutoMapperFixture : IDisposable
        {
            public IMapper GetMapper()
            {
                var config = new MapperConfiguration(c =>
                {
                    c.AddProfile(new ModelToEntityProfile());
                    c.AddProfile(new DtoToModelProfile());
                    c.AddProfile(new EntityToDtoProfile());
                });

                return config.CreateMapper();
            }
            public void Dispose() { }
        }
    }
}
