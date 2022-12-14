using AppUTM.Core.Interfaces;
using AppUTM.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AppUTM.Core.Repositories;

namespace AppUTM.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PermissionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Permission>> GetAllPermissions()
        {
            return await _unitOfWork.Permissions.GetAll();
        }

        public async Task<Permission> GetPermissionById(int id)
        {
            return await _unitOfWork.Permissions.GetById(id);
        }

        public async Task<Permission> CreatePermission(Permission newPermission)
        {
            await _unitOfWork.Permissions.Add(newPermission);
            await _unitOfWork.CommitAsync();
            return newPermission;
        }

        public async Task UpdatePermission(Permission permissionToBeUpdated, Permission permission)
        {
            permissionToBeUpdated.Module = permission.Module;
            permissionToBeUpdated.UpdateAt = DateTime.Now;
            await _unitOfWork.CommitAsync();
        }

        public async Task DeletePermission(Permission permission)
        {
            _unitOfWork.RolePermission.RemoveRange(permission.RolePermissions);
            _unitOfWork.Permissions.Remove(permission);
            await _unitOfWork.CommitAsync();
        }
    }
}