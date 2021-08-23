using System.Collections.Generic;

namespace Pos.Service.Blazor.Domain.Models
{
    public class MenuRazor
    {
        public List<ComponentParameters> ComponentParameters { get; set; }


        public void AddNewComponent(List<ComponentParameters> componentParameters)
        {
            ComponentParameters.AddRange(componentParameters);
        }
    }
}
