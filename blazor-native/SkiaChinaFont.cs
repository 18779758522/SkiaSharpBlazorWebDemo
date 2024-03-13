using SkiaSharp;
using System.IO;
using System.Reflection;

namespace SkiaSharpSample
{
    public class SkiaChinaFont
    {
        public static SKTypeface ChinaFont { get; set; }

		static SkiaChinaFont()
        {
			//加载资源方案，设置字体文件属性为嵌入的资源
			var fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SkiaSharpSample.simsun.ttc");
			ChinaFont = SKTypeface.FromStream(fontStream);
			fontStream.Dispose();
		}
	}
}
