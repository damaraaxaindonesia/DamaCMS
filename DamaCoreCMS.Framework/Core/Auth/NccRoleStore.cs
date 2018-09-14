

using System;
using System.Security.Claims;
using DamaCoreCMS.Framework.Core.Data;
using DamaCoreCMS.Framework.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DamaCoreCMS.Framework.Core.Auth
{
    public class NccRoleStore : RoleStore<NccRole, NccDbContext, long, NccUserRole, IdentityRoleClaim<long>>
    {
        public NccRoleStore(NccDbContext context) : base(context)
        {
        }

        protected override IdentityRoleClaim<long> CreateRoleClaim(NccRole role, Claim claim)
        {
            return new IdentityRoleClaim<long> { RoleId = role.Id, ClaimType = claim.Type, ClaimValue = claim.Value };
        }

        internal object FindByNameAsync(object reader)
        {
            throw new NotImplementedException();
        }
    }
}
