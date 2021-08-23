using System.Collections.Generic;

namespace MenuComponents
{
    public class MenuRazor
    {
        public List<ComponentParameter> ComponentParameters { get; set; }
    }

    public class ComponentParameter
    {
        public string ComponentName { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }
        public object ParameterColor { get; set; }
        public string Id { get; set; }
        public ToReplace ToReplace { get; set; }
    }
    public class ToReplace
    {
        public string NameIdToReplace { get; set; }
        public string IdObjectToReplace { get; set; }
        public string IdNewObject { get; set; }
    }
}
