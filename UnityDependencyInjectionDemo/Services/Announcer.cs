using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnityDependencyInjectionDemo.Services
{
    public class Announcer : IAnnouncer
    {
        private readonly IService _service;

        public Announcer(IService service)
        {
            _service = service;
        }
        public string Announcement()
        {
            string dataToAnnounce = _service.GetData();

            return dataToAnnounce.ToUpper();
        }
    }
}