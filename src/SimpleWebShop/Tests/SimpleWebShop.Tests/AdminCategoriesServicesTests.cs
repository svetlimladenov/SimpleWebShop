using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using SimpleWebShop.Data;
using SimpleWebShop.Data.Common;
using SimpleWebShop.Data.Models;
using SimpleWebShop.Services.Data.Contracts;
using SimpleWebShop.Web.Areas.Administration.Services;
using SimpleWebShop.Web.Areas.Administration.ViewModels;
using Xunit;

namespace SimpleWebShop.Tests
{
    public class AdminCategoriesServicesTests
    {
        [Fact]
        public void CreateCategoryShouldCreateCategoriesSuccessful()
        {
            var repo = new Mock<IDbRepository<Category>>();
            var mockMapper = new Mock<IMapper>();
            var category = new Category();
            mockMapper.Setup(x => x.Map<Category>(It.IsAny<CreateCategoryInputModel>()))
                .Returns(category);

            var categoriesServices = new Mock<ICategoriesServices>();
            categoriesServices.Setup(c => c.GetCategoryIdByName("test"))
                .Returns("testId");
            

            var dto = new CreateCategoryInputModel()
            {
                Description = "test description with move than 10 characters",
                IconClass = "ad",
                Name = "Test"
            };
            IAdminCategoriesServices service = new AdminCategoriesServices(repo.Object,mockMapper.Object);
            service.CreateCategory(dto);

            var categoryDb = repo.Object.All().FirstOrDefault();
            Assert.Equal("Test", categoryDb.Name);
        }
    }
}
