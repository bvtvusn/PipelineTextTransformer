using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PipelineTextTransformer.BusinessLayer
{
    class BVhelper
    {
        public static Type[] GetInheritedClasses(Type MyType)
        {
            //if you want the abstract classes drop the !TheType.IsAbstract but it is probably to instance so its a good idea to keep it.
            return Assembly.GetAssembly(MyType).GetTypes().Where(TheType => TheType.IsClass && !TheType.IsAbstract && TheType.IsSubclassOf(MyType)).ToArray();
            // Usage:
            // Type[] res = GetInheritedClasses(typeof(Transformer));
        }
    }
}
