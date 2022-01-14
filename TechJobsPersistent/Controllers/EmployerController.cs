using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext empContext;

        public EmployerController(JobDbContext dbContext)
        {
            empContext = dbContext;
        }
        //empContext has access to the variables in JobDbContext
        //You can get the records with toList()
        //You can find a specific record by using .find() on the list results

        //JobDbContext has the following field:
        //        public DbSet<Employer> Employers { get; set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employers = empContext.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add(int id)
        {
            AddEmployerViewModel empViewModel;
            //if (id == 0)
            {
                empViewModel = new AddEmployerViewModel();
                //Employer employer = new Employer();
                return View(empViewModel);
            }
            /*else
            {
                Job theJob = empContext.Jobs.Find(id);
                List<Employer> possibleEmployers = empContext.Employers.ToList();
                empViewModel = new AddEmployerViewModel(theJob, possibleEmployers);
            }*/
            
            //return View(empViewModel);
        }

        //The form in Views/Employer/Add has 
        // asp-action="ProcessAddEmployerForm" method="post"
        public IActionResult ProcessAddEmployerForm(Employer employer)
        {
            if (ModelState.IsValid)
            {
                empContext.Employers.Add(employer);
                empContext.SaveChanges();
                return Redirect("/Employer/");
            }

            return View("Add", employer);
        }

        /*                jobs = context.Jobs
                   .Include(j => j.Employer)
                   .ToList();
        */


        public IActionResult About(int id)
        {
            Employer ret = empContext.Employers.Find(id);

            return View(ret);
        }
    }
}
