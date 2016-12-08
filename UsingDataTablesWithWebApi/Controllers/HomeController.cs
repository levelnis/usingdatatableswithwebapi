namespace Levelnis.Learning.UsingDataTablesWithWebApi.Controllers
{
    using System.Web.Mvc;
    using Models;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.Title = "Home Page";
        var model = Create();
        return View(model);
    }

    private static HomeViewModel Create()
    {
        var customerClientColumns = new[] { "companyName", "address", "postcode", "telephone" };
        var customerColumnHeadings = new[] { "Company Name", "Address", "Postcode", "Telephone" };
        var userClientColumns = new[] { "companyName", "firstName", "lastName", "email", "jobTitle" };
        var userColumnHeadings = new[] { "Company Name", "First Name", "Last Name", "Email", "JobTitle" };
        var model = new HomeViewModel
        {
            CustomerWidget = new TableWidgetViewModel().Initialise(customerClientColumns, "Customers", "CustomerTable", customerColumnHeadings),
            UserWidget = new TableWidgetViewModel().Initialise(userClientColumns, "Users", "UserTable", userColumnHeadings)
        };
        return model;
    }
}
}
