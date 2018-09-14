

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DamaCoreCMS.Framework.Core.Mvc.Models
{
    [Serializable]
    public abstract class ValidateableModel
    {
        public virtual bool IsValid()
        {
            return this.ValidationResults().Count == 0;
        }

        public virtual IList<ValidationResult> ValidationResults()
        {
            IList<ValidationResult> validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(this, new ValidationContext(this, null, null), validationResults, true);
            return validationResults;
        }
    }
}
