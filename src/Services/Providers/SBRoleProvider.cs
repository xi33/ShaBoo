using System;
using Ninject;
using ShaBoo.Domain.Services;
using ShaBoo.Entities;

namespace ShaBoo.Services.Providers
{
    public class SBRoleProvider:System.Web.Security.RoleProvider
    {

        private BLLService _service;
        public SBRoleProvider()
        {
            this._service=new BLLService();
        }

        public override bool IsUserInRole(string username, string roleName)
        {

            User user = _service.UserService.GetUser(username);
            Role role = _service.RoleService.GetRole(roleName);
            if (user == null || role == null)
                return false;
            return user.Role.Name == role.Name;
        }

        public override string[] GetRolesForUser(string username)
        {
            User user=_service.UserService.GetUser(username);
            return user==null ? new string[]{string.Empty} : new string[]{user.Role.Name};
        }

        #region Not implemented
        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
