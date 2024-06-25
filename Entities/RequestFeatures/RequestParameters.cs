using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeatures
{
	public abstract class RequestParameters
	{
		const int maxPagesize = 50;
		// Auto-implemented property
        public int PageNumber { get; set; }
		private int _pageSize;
		//Full-property
		public int PageSize
		{
			get { return _pageSize; }
			set { _pageSize = value > maxPagesize ? maxPagesize : value; }
		}

	}
}
