﻿using System;

namespace Julmar.AzDOUtilities
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AzDOWorkItemAttribute : Attribute
    {
        public string WorkItemType { get; }

        public AzDOWorkItemAttribute(string workItemType)
        {
            WorkItemType = workItemType;
        }
    }
}
