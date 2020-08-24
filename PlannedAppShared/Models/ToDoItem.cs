using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerAppShared.Models
{
    public class ToDoItem
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string IsDone { get; set; }

        public DateTime EstimatedDate { get; set; }

        public DateTime AchievedDate { get; set; }

        public string PlanId { get; set; }
    }
}
