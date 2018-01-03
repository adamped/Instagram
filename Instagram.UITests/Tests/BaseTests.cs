using NUnit.Framework;
using Xamarin.UITest;

namespace Instagram.UITests.Tests
{
	public class BaseTests
	{
		protected IApp App { get; private set; }
		protected Platform platform { get; private set; }

		public BaseTests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			App = AppInitializer.StartApp(platform);
		}

	}
}
