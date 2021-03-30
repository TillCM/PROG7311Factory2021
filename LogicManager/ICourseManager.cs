using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cassfactory.LogicManager
{

    public interface ICourseManager
    {

        public List<Course> getCourseData();

    }

}