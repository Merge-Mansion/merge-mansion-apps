using System;

namespace Metaplay.Core.Model
{
    [AttributeUsage((AttributeTargets)384)]
    public class ExcludeFromGdprExportAttribute : Attribute
    {
        public ExcludeFromGdprExportAttribute()
        {
        }
    }
}