using Simplify.Templates;

namespace HiComponent
{
	public static class HiTemplate
	{
		public static ITemplate Load(this ITemplate tpl)
		{
			// Do processing

			return Template.FromString(tpl.Get());
		}
	}
}