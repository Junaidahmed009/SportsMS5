﻿using System.Web;
using System.Web.Mvc;

namespace Sportsmanagementsystem5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
