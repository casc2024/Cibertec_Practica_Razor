using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }
        private static string GetHtmlForPrice(double price)
        {
            return price == 0.0 ? "<span>Free!!!</span>" : $"<span>{price.ToString("C")}</span>";
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(GetDateHtml(date));
        }

        private static string GetDateHtml(DateTime? date)
        {            
            return date.HasValue ? $"<span>{date.Value.ToString("dd-mm-yyyy")}</span>" : "None";
        }

        public static IHtmlString DisplayDateOrNull(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(date == null ? DisplayStringHtml("None") : DisplayStringHtml(date.Value.ToString("dd/MM/yyyy")));
        }

        private static string DisplayStringHtml(string variable)
        {
            return $"<span>{variable}</span>";
        }

        public static MvcHtmlString ImagenDatos(this HtmlHelper html, byte[] buffer, int ancho, int alto, string tipo, string id)
        {
            string rspta = String.Format("<img src='' width='{0}' height='{1}' id='{2}'/>", ancho, alto, id);
            if (buffer != null && buffer.Length > 0)
            {
                rspta = String.Format("<img src='data:image/{0};base64,{1}' width='{2}' height='{3}' id='{4}'/>",
                tipo, Convert.ToBase64String(buffer), ancho, alto, id);
            }
            return new MvcHtmlString(rspta);
        }

        public static MvcHtmlString ImagenUrl(this HtmlHelper html, string url, int ancho, int alto, string id)
        {
            string rpta = "";
            string archivo = HttpContext.Current.Server.MapPath(url);
            if (File.Exists(archivo))
            {
                string tipo = Path.GetExtension(archivo);
                byte[] buffer = File.ReadAllBytes(archivo);
                rpta = String.Format("<img src='data:image/{0};base64,{1}' width='{2}' height='{3}' id='{4}'/>",
                tipo, Convert.ToBase64String(buffer), ancho, alto, id);
            }
            return (new MvcHtmlString(rpta));
        }
    }
}
