namespace Pos.Service.Blazor.Domain.Models
{
    public class ComponentParameters
    {
        public string ComponentName { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public string ParameterColor { get; set; }
        public string Id { get; set; }
        public ToReplace ToReplace { get; set; }
    }
}
