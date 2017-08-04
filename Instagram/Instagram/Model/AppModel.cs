using Exrin.Abstraction;

namespace Instagram.Model
{
	public interface IAppModel: IBaseModel { }
	public class AppModel : Exrin.Framework.Model, IAppModel
	{

		// Business Logic goes in here
		// You also access your services or repositories through here

	}
}
