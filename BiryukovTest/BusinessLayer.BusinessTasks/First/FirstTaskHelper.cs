﻿using System;

namespace BusinessLayer.BusinessTasks.First
{
    internal static class FirstTaskHelper
    {
        public static bool RequirementIsMet(this string item, string template)
        {
            if (item.Contains(template)) return true;
            return false;
        }

        public static bool RequirementIsMet(this Guid item, string template)
        {
            return item.ToString("N").RequirementIsMet(template);
        }
    }
}
