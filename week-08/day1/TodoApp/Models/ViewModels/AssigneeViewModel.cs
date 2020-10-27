using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models.ViewModels
{
    public class AssigneeViewModel
    {
        public List<Assignee> Assignees { get; set; }
        public AssigneeViewModel(List<Assignee> assignees)
        {
            Assignees = assignees;
        }

    }
}
