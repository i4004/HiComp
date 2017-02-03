using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using Simplify.Templates;

namespace HiComponent
{
	public static class HiTemplate
	{
		private const string ImportCommandName = "import";

		public static ITemplate Load(this ITemplate tpl)
		{
			// Do processing

			var imports = new List<string>();
			var items = new StringBuilder();

			foreach (var item in tpl.Get().Split(new[] { Environment.NewLine }, StringSplitOptions.None))
			{
				if (item.StartsWith(ImportCommandName))
					imports.Add(item.Substring(item.IndexOf(ImportCommandName, StringComparison.Ordinal)));
				else
					items.AppendLine(item);
			}

			var doc = XDocument.Parse(items.ToString());

			return Template.FromString(tpl.Get());
		}
	}
}