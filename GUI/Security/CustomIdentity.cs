﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Security
{
    public class CustomIdentity : IIdentity
    {
        public CustomIdentity(string name, string[] roles)
        {
            Name = name;
            Roles = roles;
        }

        public string Name { get; private set; }
        public string[] Roles { get; private set; }

        public string AuthenticationType { get { return "Custom authentication"; } }

        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
    }
}
