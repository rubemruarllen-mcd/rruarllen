using Pos.Service.Blazor.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Pos.Service.Blazor.Domain
{
    public class ComponentsContext : DbContext
    {
        public Components Components => FillComponents();


        public Components FillComponents()
        {
            var toReplace = new ToReplace() { NameIdToReplace = "uuid", IdObjectToReplace = "38", IdNewObject = "38" };
            var toReplace2 = new ToReplace() { NameIdToReplace = "uuid", IdObjectToReplace = "39", IdNewObject = "39" };
            var newComp = new ComponentParameters()
            {
                ComponentName = "BtnQuantity",
                ParameterName = "Name",
                ParameterValue = "BigMac",
                Id = "38",
                ToReplace = toReplace
            };

            var newCompMenu = new ComponentParameters()
            {
                ComponentName = "BtnMenu",
                ParameterName = "Name",
                ParameterValue = "CBO",
                Id = "39",
                ParameterColor = "#87CEFA",
                ToReplace = toReplace2
            };

            return new Components()
            {
                QuantityRazor = new QuantityRazor() 
                { 
                    ComponentParameters = new List<ComponentParameters>() { newComp } 
                },
                MenuRazor = new MenuRazor()
                {
                    ComponentParameters = new List<ComponentParameters>() { newCompMenu }
                }
            };

        }
    }
}
