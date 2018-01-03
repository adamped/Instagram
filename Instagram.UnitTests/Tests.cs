using Instagram.Features.Authentication;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Instagram.UnitTests
{
    public class Tests
    {
		[Fact]
		public void Test()
		{
			Mock<IService> serviceMock = new Mock<IService>();
			serviceMock.Setup(x => x.Login("username", "password"))
					   .Returns(true);

			var model = new AuthenticationModel(serviceMock.Object);

			Assert.True(model.IsAuthenticated(), "User was not authenticated");
		}

    }
}
