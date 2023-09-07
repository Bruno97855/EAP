using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace EAP.Components
{
    public static class HtmlComponents
    {
        public static IHtmlContent DropDownListEAP<TModel, TValue>(
        this IHtmlHelper<TModel> htmlHelper,
        Expression<Func<TModel, TValue>> expression,
        List<SelectListItem> items,
        string optionLabel,
        object htmlAttributes)
        {
            // Aqui, você pode gerar o HTML do seu componente dropdown personalizado
            var dropdownHtml = $@"
            <div class='custom-dropdown'>
                <button class='custom-dropdown-toggle'>{optionLabel}</button>
                <ul class='custom-dropdown-menu'>
                    {GenerateDropdownItems(items)}
                </ul>
            </div>
        ";

            return new HtmlString(dropdownHtml);
        }

        private static string GenerateDropdownItems(List<SelectListItem> items)
        {
            // Gere o HTML para os itens do menu suspenso personalizado
            var itemHtml = "";
            foreach (var item in items)
            {
                itemHtml += $"<li><a href='{item.Value}'>{item.Text}</a></li>";
            }
            return itemHtml;
        }
    }
}
