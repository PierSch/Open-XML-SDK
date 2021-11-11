using System;

namespace DocumentFormat.OpenXml.Packaging
{
    public abstract class FlatOpcRelationshipErrorHandler
    {
        public abstract string Rewrite(string? uri);


        internal string Handle(string target)
        {
            if (!string.IsNullOrEmpty(target) && Uri.TryCreate(target, UriKind.Absolute, out _))
            {
                return target;
            }

            var updated = Rewrite(target);

            if (updated is null)
            {
                return target;
            }

            if (!Uri.TryCreate(updated, UriHelper.RelativeOrAbsolute, out _))
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidUriProvided);
            }

            return updated;
        }
    }
}