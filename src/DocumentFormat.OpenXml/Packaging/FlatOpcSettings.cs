using System;
using System.Xml.Linq;

namespace DocumentFormat.OpenXml.Packaging
{
    public class FlatOpcSettings
    {
        public FlatOpcSettings()
        {
        }

        public Func<XDocument, FlatOpcRelationshipErrorHandler>? RelationshipErrorHandlerFactory { get; set; }
    }
}