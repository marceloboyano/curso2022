using Moq;
using System;
using Xunit;

namespace validaciones.UnitTests
{
    public class FizzBuzz_Deberia
    {
        [Fact]
        public void LLamar_Output_Solo_Una_Vez_Cuando_No_Valida()
        {
            var testDelegate = new Mock<EnviarMensaje>();
            testDelegate.Setup(x => x(It.IsAny<string>()));

            var sut = new Mock<FizzBuzz>(MockBehavior.Strict, new object[] { 100,1,testDelegate.Object });

            sut.Object.Execute();

            testDelegate.Verify(x => x(It.IsAny<string>()), Times.Once);
        }
    }
}