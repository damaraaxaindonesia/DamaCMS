

using Microsoft.AspNetCore.Identity;
using DamaCoreCMS.Framework.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DamaCoreCMS.Framework.Core.Auth
{
    public class NccUserManager : UserManager<NccUser>
    {
        public NccUserManager(IUserStore<NccUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<NccUser> passwordHasher, IEnumerable<IUserValidator<NccUser>> userValidators, IEnumerable<IPasswordValidator<NccUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<NccUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }
    }
}
