﻿using System.Web;
using System.Web.Mvc;
using ContosoMVC.Filters;

namespace ContosoMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new ContosoExceptionFilter());
        }
    }
}
