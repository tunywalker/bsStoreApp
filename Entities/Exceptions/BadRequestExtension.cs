using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
	public abstract partial class BadRequestExtension:Exception
	{
        protected BadRequestExtension(string message):base(message)
        {
            
        }
    }
}
