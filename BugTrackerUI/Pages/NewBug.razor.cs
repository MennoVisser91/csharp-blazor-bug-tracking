using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Pages
{
    public partial class NewBug
    {
        public Bug AddBug { get; set; } = new Bug();

        [Inject]
        public IBugService BugService { get; set; }

        [Inject]
        public NavigationManager NavService { get; set; }

        protected void HandleValidSubmit()
        {
            BugService.AddBug(AddBug);
            NavService.NavigateTo("");
        }
    }
}
