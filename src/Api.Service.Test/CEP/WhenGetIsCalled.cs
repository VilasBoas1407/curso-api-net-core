using Domain.DTO.Location.CEP;
using Domain.Interfaces.Services.Location.CEP;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Service.Test.CEP
{
    public class WhenGetIsCalled : CepTestes
    {
        private ICepService _service;
        private Mock<ICepService> _serviceMock;

        [Fact(DisplayName = "É Possivel Executar o Método GET.")]
        public async Task E_Possivel_Executar_Metodo_Get()
        {
            _serviceMock = new Mock<ICepService>();
            _serviceMock.Setup(m => m.Get(IdCep)).ReturnsAsync(cepDto);
            _service = _serviceMock.Object;

            var result = await _service.Get(IdCep);
            Assert.NotNull(result);
            Assert.True(result.Id == IdCep);
            Assert.Equal(CepOriginal, result.Cep);
            Assert.Equal(LogradouroOriginal, result.Logradouro);

            _serviceMock = new Mock<ICepService>();
            _serviceMock.Setup(m => m.Get(CepOriginal)).ReturnsAsync(cepDto);
            _service = _serviceMock.Object;

            result = await _service.Get(CepOriginal);
            Assert.NotNull(result);
            Assert.True(result.Id == IdCep);
            Assert.Equal(CepOriginal, result.Cep);
            Assert.Equal(LogradouroOriginal, result.Logradouro);

            _serviceMock = new Mock<ICepService>();
            _serviceMock.Setup(m => m.Get(It.IsAny<Guid>())).Returns(Task.FromResult((CepDTO)null));
            _service = _serviceMock.Object;

            var _record = await _service.Get(Guid.NewGuid());
            Assert.Null(_record);
        }
    }
}
