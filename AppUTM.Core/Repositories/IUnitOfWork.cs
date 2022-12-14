using AppUTM.Core.Models;
using System;
using System.Threading.Tasks;

namespace AppUTM.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IPermissionRepository Permissions { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }
        IModuleRepository Module { get; }
        public IRepository<Empresa> EmpresaRepository { get; }
        public IRepository<CuponGenerico> CuponGenericoRepository { get; }
        public IRepository<CuponImagen> CuponImagenRepository { get; }
        public IRepository<HistorialCupones> HistorialCuponesRepository { get; }
        IRolePermissionRepository RolePermission { get; }
        IUserRolesRepository UserRoles { get; }

        IModuleRoleRepository ModuleRoles { get; }

        Task<int> CommitAsync();
    }
}