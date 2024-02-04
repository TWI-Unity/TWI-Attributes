namespace TWI.Attributes
{
    using System;
    using UnityEngine;

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class SubtypeFieldAttribute : PropertyAttribute
    {
        public readonly Type subtype;

        public SubtypeFieldAttribute(Type subtype) => this.subtype = subtype;
    }
}
