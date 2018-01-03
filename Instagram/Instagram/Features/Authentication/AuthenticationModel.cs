using System;
using System.Collections.Generic;
using System.Text;

namespace Instagram.Features.Authentication
{
    public class AuthenticationModel
    {
		IService _service;
		public AuthenticationModel(IService service)
		{
			_service = service;
		}

		public bool Login(string username, string password)
		{
			return _service.Login(username, password);
		}

		public bool IsAuthenticated()
		{
			return true;
		}
    }

	public interface IService
	{
		bool Login(string username, string password);
	}
}
