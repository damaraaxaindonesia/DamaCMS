

using Microsoft.AspNetCore.Authorization;

namespace DamaCoreCMS.Framework.Core.Auth.Handlers
{
    public class NccAuthRequirement : IAuthorizationRequirement
    {
        public string Requirement { get; set; }
        public string Values { get; set; }
        private string _moduleName;

        private string[] _requirementList;
        private string[] _valueList;

        public string[] RequirementList { get => _requirementList; set => _requirementList = value; }
        public string[] ValueList { get => _valueList; set => _valueList = value; }
        public string ModuleName { get => _moduleName; set => _moduleName = value; }

        public NccAuthRequirement(string requirement, string values = "")
        {
            Requirement = requirement;
            Values = values;
        }
    }
}
