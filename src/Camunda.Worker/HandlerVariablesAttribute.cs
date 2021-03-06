using System;
using System.Collections.Generic;

namespace Camunda.Worker
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HandlerVariablesAttribute : Attribute
    {
        public HandlerVariablesAttribute(params string[] variables)
        {
            Variables = variables;
        }

        public IReadOnlyList<string> Variables { get; }

        public bool LocalVariables { get; set; }
    }
}
