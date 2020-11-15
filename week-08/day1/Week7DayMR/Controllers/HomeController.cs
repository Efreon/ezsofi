using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Week7DayMR;

namespace EntityFrameworkBasics.Controllers
{
    public class HomeController : Controller
    {
        #region Protected Members

        /// <summary>
        /// The scoped Application context
        /// </summary>
        protected ApplicationDbContext Context;

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="context">The injected context</param>
        public HomeController(ApplicationDbContext context)
        {
            Context = context;
        }

        #endregion

        public IActionResult Index()
        {
            // Make sure we have the database
            Context.Database.EnsureCreated();

            // If we have no settings already...
            if (!Context.Settings.Any())
            {
                // Add a new setting
                Context.Settings.Add(new SettingsDataModel
                {
                    Name = "BackgroundColor",
                    Value = "Red"
                });

                // Check to show the new setting is currently only local and not in the database
                var settingsLocally = Context.Settings.Local.Count();
                var settingsDatabase = Context.Settings.Count();
                var firstLocal = Context.Settings.Local.FirstOrDefault();
                var firstDatabase = Context.Settings.FirstOrDefault();

                // Commit setting to database
                Context.SaveChanges();
                 
                // Recheck to show its now in local and the actual database
                settingsLocally = Context.Settings.Local.Count();
                settingsDatabase = Context.Settings.Count();
                firstLocal = Context.Settings.Local.FirstOrDefault();
                firstDatabase = Context.Settings.FirstOrDefault();
            }

            return View();
        }
    }
}
