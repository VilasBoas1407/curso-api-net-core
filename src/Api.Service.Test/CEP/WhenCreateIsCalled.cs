using Domain.Interfaces.Services.Location.CEP;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Service.Test.CEP
{
    public class WhenCreateIsCalled : CepTestes
    {
        private ICepService _service;
        private Mock<ICepService> _serviceMock;

        [Fact(DisplayName = "É Possível executar o Método Create.")]
        public async Task E_Possivel_Executar_Metodo_Create()
        {
            _serviceMock = new Mock<ICepService>();
            _serviceMock.Setup(m => m.Post(cepDtoCreate)).ReturnsAsync(cepDtoCreateResult);
            _service = _serviceMock.Object;

            var result = await _service.Post(cepDtoCreate);
            Assert.NotNull(result);
            Assert.Equal(CepOriginal, result.Cep);
            Assert.Equal(LogradouroOriginal, result.Logradouro);
            Assert.Equal(NumeroOriginal, result.Numero);

        }
    }
}
