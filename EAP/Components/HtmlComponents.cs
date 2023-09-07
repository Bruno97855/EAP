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
            // Obtém o nome da propriedade a partir da expressão
            var propertyName = GetPropertyName(expression);

            // Gera um ID com base no nome da propriedade
            var id = htmlHelper.Encode(propertyName);

            // Aqui, você pode gerar o HTML do seu componente dropdown personalizado
            var dropdownHtml = $@"
                <div class='custom-dropdown'>
                    <button id='{id}' class='custom-dropdown-toggle' value=''>{optionLabel} 
                    </button>
                    <ul class='custom-dropdown-menu'>
                        {GenerateDropdownItems(items)}
                    </ul>
                </div>
            ";
            
            return new HtmlString(dropdownHtml);
        }

        // Método para obter o nome da propriedade a partir da expressão
        private static string GetPropertyName<TModel, TValue>(Expression<Func<TModel, TValue>> expression)
        {
            MemberExpression memberExpression = null;
            if (expression.Body.NodeType == ExpressionType.Convert)
            {
                memberExpression = ((UnaryExpression)expression.Body).Operand as MemberExpression;
            }
            else if (expression.Body.NodeType == ExpressionType.MemberAccess)
            {
                memberExpression = expression.Body as MemberExpression;
            }

            return memberExpression != null ? memberExpression.Member.Name : string.Empty;
        }


        private static string GenerateDropdownItems(List<SelectListItem> items)
        {
            // Gere o HTML para os itens do menu suspenso personalizado
            var itemHtml = "";
            foreach (var item in items)
            {
                itemHtml += $"<li data-value='{item.Value}'><a href='#'>{item.Text}</a></li>";
            }
            return itemHtml;
        }
    }
}
