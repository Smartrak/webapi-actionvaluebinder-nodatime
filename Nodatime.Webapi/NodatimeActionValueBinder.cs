﻿using System.Web.Http.Controllers;
using NodaTime;
using Webapi.ActionValueBinder.Contrib;

namespace Nodatime.Webapi
{
	public class InstantBinder : IActionBinding
	{
		public bool CanBind(HttpParameterDescriptor parameter)
		{
			return parameter.ParameterType == typeof (Instant) || parameter.ParameterType == typeof (Instant?);
		}

		public HttpParameterBinding Bind(HttpParameterDescriptor parameter)
		{
			return parameter.BindWithModelBinding(new InstantModelBinder());
		}
	}
}
