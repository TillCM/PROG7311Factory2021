using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cassfactory.LogicManager
{

    public class BCADManager: ICourseManager
    {

        List<Course> BCAD1 = new List<Course>();

        public List<Course> getCourseData()
        {
            BCAD1.Add(new Course{ModuleName = "PROGF511", weight1 =10, weight2=20});

            return BCAD1;
        }





    }

}