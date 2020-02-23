﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions
{
    public static class EditControlsForHtmlExtensions
    {
        public static IHtmlContent EditControlsFor<TClassType, TPropertyType>(
            this IHtmlHelper<TClassType> htmlHelper, Expression<Func<TClassType, TPropertyType>> expression)
        {
            var s = htmlString(htmlHelper, expression);
            return new HtmlContentBuilder(s);
        }
        internal static List<Object> htmlString<TClassType, TPropertyType>(
            IHtmlHelper<TClassType> htmlHelper, Expression<Func<TClassType,
                TPropertyType>> expression)
        {
            return new List<Object>
            {
                new HtmlString("<div class=\"form-group\">"),
                htmlHelper.LabelFor(expression, new {@class = "text-dark"}),
                htmlHelper.EditorFor(expression,
                    new {htmlAttributes = new {@class = "form-control"}}),
                htmlHelper.ValidationMessageFor(expression,"",new {@class = "text-danger"}),
                new  HtmlString("</div>")
            };
        }
    }
}
