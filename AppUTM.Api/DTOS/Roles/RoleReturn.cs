using System.Collections.Generic;
using AppUTM.Core.Models;

namespace AppUTM.Api.DTOS.Roles
{
    public class RoleReturn
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IList<ModuleRole> ModuleRoles { get; set; }
    }
}