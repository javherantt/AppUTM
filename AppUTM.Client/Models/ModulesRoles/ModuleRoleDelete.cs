﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppUTM.Api.DTOS.ModulesRoles
{
    public class ModuleRoleDelete
    {

        public int ModuleId { get; set; }




        public int RoleId { get; set; }

        public bool Lectura { get; set; }

        public bool Escritura { get; set; }
    }
}