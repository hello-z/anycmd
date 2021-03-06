﻿
namespace Anycmd.Xacml.Consts
{
    public partial class ContextSchema
    {
        /// <summary>The name of the element/attribute in the XSD schema.</summary>
        public class StatusCodes
        {
            /// <summary>The name of the element/attribute in the XSD schema.</summary>
            public const string Ok = "urn:oasis:names:tc:xacml:1.0:status:ok";
            /// <summary>The name of the element/attribute in the XSD schema.</summary>
            public const string MissingAttribute = "urn:oasis:names:tc:xacml:1.0:status:missing-attribute";
            /// <summary>The name of the element/attribute in the XSD schema.</summary>
            public const string SyntaxError = "urn:oasis:names:tc:xacml:1.0:status:syntax-error";
            /// <summary>The name of the element/attribute in the XSD schema.</summary>
            public const string ProcessingError = "urn:oasis:names:tc:xacml:1.0:status:processing-error";
        }
    }
}