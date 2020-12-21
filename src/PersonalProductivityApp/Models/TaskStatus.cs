using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PersonalProductivityApp.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskStatus
    {
        [EnumMember(Value = "Planning")]
        [Description("Planning")]
        Planning = 0,
        [EnumMember(Value = "Todo")]
        [Description("Todo")]
        Todo = 1,
        [EnumMember(Value = "InProgress")]
        [Description("In Progress")]
        InProgress = 2,
        [EnumMember(Value = "Finished")]
        [Description("Finished")]
        Finished =3
    }
}
