using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Mono.Reflection
{
    public class ThisParameter : ParameterInfo
    {
        private Type m_type;

        public ThisParameter(Type t)
        {
            m_type = t;
        }

        public override Type ParameterType
        {
            get { return m_type; }
        }
    }
}
