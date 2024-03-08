using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymEncrypt_SecureString
{
    /// <summary>
    /// a string that is encrypted in the memory
    /// </summary>
    public class SecureString
    {
        private string m_value;

        public SecureString(string value)
        {
            Value = value;
        }

        public string Value 
        { 
            get
            {
                return m_value; 
            }
            set
            { 
                m_value = value;
            }
        }

    }
}
