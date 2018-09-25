using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDependencyInjectionDemo.Services
{
    public class HotdogService : IService
    {
        public string GetData()
        {
            return "Fresh hotdogs! Straight from the oven. 100% real dogs!";
        }
    }
}