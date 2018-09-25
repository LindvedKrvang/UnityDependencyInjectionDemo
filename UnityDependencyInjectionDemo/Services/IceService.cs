using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDependencyInjectionDemo.Services
{
    public class IceService : IService
    {
        public string GetData()
        {
            return "Come get your ice here. We have the finest import from Alaska!";
        }
    }
}