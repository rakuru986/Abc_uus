﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Abc.Pages.Extensions
{
    public static class DisplayControlsForHtmlExtensions
    {
        public static IHtmlContent DisplayControlsFor<TModel, TResult>(this  IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TResult>> expression)
        { 
            var s = HtmlString(htmlHelper, expression);
            return new HtmlContentBuilder(s);
        }

        internal static List<object> HtmlString<TModel, TResult>(
            IHtmlHelper<TModel> htmlHelper,
            Expression<Func<TModel, TResult>> expression)
        {
            return new List<Object>
            {
                new HtmlString("<dt class=\"col-sm-2\">"),
                htmlHelper.DisplayNameFor(expression),
                new HtmlString("</dt>"),
                new HtmlString("<dd class=\"col-sm-10\">"),
                htmlHelper.DisplayFor(expression),
                new  HtmlString("</dd>")

            };
        }
    }
}
