using System;
using AndcultureCode.CSharp.Core.Enumerations;

namespace AndcultureCode.CSharp.Core.Models.Security
{
    public abstract class AccessRule : IEquatable<AccessRule>
    {
        #region Properties

        public string Resource { get; set; }
        public string Verb { get; set; }
        public string Subject { get; set; }

        public abstract Permission Permission { get; }

        #endregion Properties

        #region Constructor

        protected AccessRule(string resource,
            string verb,
            string subject)
        {
            Resource = resource;
            Verb = verb;
            Subject = subject;
        }

        #endregion Constructor

        #region IEquatable<AccessRule> Implementation

        bool IEquatable<AccessRule>.Equals(AccessRule other)
        {
            return other.Resource == Resource
                && other.Verb == Verb
                && other.Subject == Subject
                && other.Permission == Permission;
        }

        #endregion IEquatable<AccessRule> Implementation
    }
}
