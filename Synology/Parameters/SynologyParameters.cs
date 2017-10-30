﻿using System.Reflection;
using Synology.Attributes;
using Synology.Utilities;
using System;
using System.Runtime.CompilerServices;
using Synology.Interfaces;

namespace Synology.Parameters
{
    public abstract class SynologyParameters<T> where T : IParameter
    {
        public string Method { get; }
        public int Version { get; set; }
        public T[] Additional { get; set; }

        protected SynologyParameters(ISynologyRequest request, [CallerMemberName] string methodName = null)
        {
            var method = request.GetType().GetMethod(methodName);

            if (method != null)
            {
                var attr = method.GetCustomAttribute(typeof(RequestMethodAttribute)) as RequestMethodAttribute;

                if (attr != null)
                    Method = attr.Name;
                else
                    throw new Exception("RequestMethodAttribute not found on caller method.");
            }
            else
            {
                throw new Exception("Caller Method not found.");
            }

            Version = 1;
        }
    }
}
