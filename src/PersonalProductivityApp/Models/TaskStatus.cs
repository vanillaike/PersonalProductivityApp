using System.ComponentModel;

namespace PersonalProductivityApp.Models
{
    public enum TaskStatus
    {
        [Description("Planning")]
        Planning = 0,
        [Description("Todo")]
        Todo = 1,
        [Description("In Progress")]
        InProgress = 2,
        [Description("Finished")]
        Finished =3
    }
}
