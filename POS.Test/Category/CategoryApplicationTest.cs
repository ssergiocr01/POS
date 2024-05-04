using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS.Application.Dtos.Requests;
using POS.Application.Interfaces;
using POS.Utilities.Static;

namespace POS.Test.Category
{
    [TestClass]
    public class CategoryApplicationTest
    {
        private static WebApplicationFactory<Program>? _factory = null;
        private static IServiceScopeFactory? _scopeFactory = null;

        [ClassInitialize]
        public static void Initialize(TestContext _testContext)
        {
            _factory = new CustomWebApplicationFactory();
            _scopeFactory = _factory.Services.GetRequiredService<IServiceScopeFactory>();
        }

        [TestMethod]
        public async Task RegisterCategory_WhenSendingNullValuesOrEmptyValues_ValidationErrors()
        {
            using var scope = _scopeFactory?.CreateScope();
            var context = scope?.ServiceProvider.GetService<ICategoryApplication>();

            //Arrange
            var name = "";
            var description = "";
            var state = 1;
            var expected = ReplyMessage.MESSAGE_VALIDATE;

            //Act
            var result = await context!.RegisterCategory(new CategoryRequestDto()
            {
                Name = name,
                Description = description,
                State = state
            });
            var current = result.Message;

            //Assert
            Assert.AreEqual(expected, current);
        }

        [TestMethod]
        public async Task RegisterCategory_WhenSendingCorrectValues_RegisteredSuccessfully()
        {
            using var scope = _scopeFactory?.CreateScope();
            var context = scope?.ServiceProvider.GetService<ICategoryApplication>();

            //Arrange
            var name = "Nuevo";
            var description = "Nueva Descripción";
            var state = 1;
            var expected = ReplyMessage.MESSAGE_SAVE;

            //Act
            var result = await context!.RegisterCategory(new CategoryRequestDto()
            {
                Name = name,
                Description = description,
                State = state
            });
            var current = result.Message;

            //Assert
            Assert.AreEqual(expected, current);
        }
    }
}
