using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        //The ViewModel is like a wheelbarrow that takes things to the View

        //For the purposes of this application, an employer can only
        //have one location.

        /*Excerpt from Employer class code:
            *           public string Name { get; set; }
            *           public string Location { get; set; }
            */

        [Required(ErrorMessage="Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage="Location is required.")]
        public string Location { get; set; }

        //public List<SelectListItem> Employers { get; set; }

        public Job Job { get; set; }

        //The Employer class' fields are Id, Name, and Location
        //One of Employer's constructors takes arguments (string name, string location)

        public AddEmployerViewModel()
        {
        }

        public AddEmployerViewModel(string name, string location)
        {
            Name = name;
            Location = location;
        }

        /*public AddEmployerViewModel(Job theJob, List<Employer> possibleEmployers)
        {
            Employers = new List<SelectListItem>();

            foreach (Employer emp in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = emp.Id.ToString(),
                    Text = emp.Name
                });
            }

            Job = theJob;
        }*/
    }
}
