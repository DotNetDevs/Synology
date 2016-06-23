using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synology.Utilities
{
	internal class QueryStringManager
	{
		private readonly string _basePath;
		private readonly List<QueryStringParameter> _params;

		public QueryStringManager(string basePath)
		{
			_basePath = basePath;
			_params = new List<QueryStringParameter>();
		}

		public void AddParameter(QueryStringParameter parameter)
		{
			if (parameter == null) return;

			if (!parameter.Empty)
			{
				_params.Add(parameter);
			}
		}

		public void AddParameters(IEnumerable<QueryStringParameter> parameters)
		{
			if (parameters == null) return;

			_params.AddRange(parameters.Where(t => t != null && !t.Empty));
		}

		public override string ToString()
		{
			var parameters = string.Join("&", _params.Where(t => t != null && !t.Empty).Select(t => t.ToString()));

			return string.IsNullOrWhiteSpace(parameters) ? _basePath : $"{_basePath}?{parameters}";
		}
	}
}
