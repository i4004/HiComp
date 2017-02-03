using NUnit.Framework;
using Simplify.Templates;

namespace HiComponent.Examples.Tests
{
	[TestFixture]
	public class HiComponentTests
	{
		[Test]
		public void TestParser()
		{
			var tpl = new Template("Master.tpl").Load();

			Assert.NotNull(tpl.Get());
		}
	}
}