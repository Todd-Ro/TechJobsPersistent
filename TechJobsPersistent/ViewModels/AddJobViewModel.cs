using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        //[Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "EmployerId is required.")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }


        public AddJobViewModel() { }

        public AddJobViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();

            foreach (var category in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = category.Id.ToString(),
                        Text = category.Name
                    }
                    );
            }
        }
    }
}
