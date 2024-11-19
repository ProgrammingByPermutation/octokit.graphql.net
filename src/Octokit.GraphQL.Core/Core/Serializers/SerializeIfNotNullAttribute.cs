using System;

namespace Octokit.GraphQL.Core.Serializers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SerializeIfNotNull : Attribute
    {
    }
}
