using System.Threading.Tasks;
using QtsSolutions.Models.TokenAuth;
using QtsSolutions.Web.Controllers;
using Shouldly;
using Xunit;

namespace QtsSolutions.Web.Tests.Controllers
{
    public class HomeController_Tests: QtsSolutionsWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}