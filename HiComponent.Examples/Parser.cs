using System.Xml.Linq;
using Simplify.Templates;

namespace HiComponent.Examples
{
	public static class Parser
	{
		public static ITemplate Load(string path)
		{
			var tpl = new Template(path);

			//var doc = XDocument.Parse(tpl.Get());

			return Template.FromString(tpl.Get());
		}
	}
}