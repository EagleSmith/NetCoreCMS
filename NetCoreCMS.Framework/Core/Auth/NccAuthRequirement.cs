﻿/*************************************************************
 *          Project: NetCoreCMS                              *
 *              Web: http://dotnetcorecms.org                *
 *           Author: OnnoRokom Software Ltd.                 *
 *          Website: www.onnorokomsoftware.com               *
 *            Email: info@onnorokomsoftware.com              *
 *        Copyright: OnnoRokom Software Ltd.                 *
 *          License: BSD-3-Clause                            *
 *************************************************************/

using Microsoft.AspNetCore.Authorization;

namespace NetCoreCMS.Framework.Core.Auth
{
    public class NccAuthRequirement : IAuthorizationRequirement
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string ModuleId { get; set; }
        public NccAuthRequirement(string name, string value = "")
        {
            Name = name;
            Value = value;
        }
    }
}