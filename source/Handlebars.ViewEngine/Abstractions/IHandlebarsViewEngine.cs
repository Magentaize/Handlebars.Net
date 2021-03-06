﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Magxe.Handlebars.ViewEngine.Abstractions
{
    public interface IHandlebarsViewEngine : IViewEngine
    {
        Task<string> RenderViewWithDataAsync(string viewPath, object viewData);
    }
}