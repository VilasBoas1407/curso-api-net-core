using Domain.Interfaces.Services.Location.Municipio;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Service.Test.Municipio
{
    public class WhenCreateIsCalled : MunicipioTestes
    {
        private IMunicipioService _service;
        private Mock<IMunicipioService> _serviceMock;

        [Fact(DisplayName = "É Possível executar o Método Create.")]
        public async Task E_Possivel_Executar_Metodo_Create()
        {
            _serviceMock = new Mock<IMunicipioService>();
            _serviceMock.Setup(m => m.Post(municipioDtoCreate)).ReturnsAsync(municipioDtoCreateResult);
            _service = _serviceMock.Object;

            var result = await _service.Post(municipioDtoCreate);
            Assert.NotNull(result);
            Assert.Equal(NomeMunicipio, result.Nome);
            Assert.Equal(CodigoIBGEMunicipio, result.CodIBGE);
            Assert.Equal(IdUf, result.UfId);
        }
    }
}

