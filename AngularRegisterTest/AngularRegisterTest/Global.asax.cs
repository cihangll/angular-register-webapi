using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AngularRegisterTest {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {

			//For Web API
			GlobalConfiguration.Configure(WebApiConfig.Register);

			//Other configurations here...
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

		}
	}
}
