using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace cassfactory.LogicManager
{

    public class  BCOMManager : ICourseManager
    {

        List<Course> BCOM1 = new List<Course>();

        public List<Course> getCourseData()
        {
            BCOM1.Add(new Course{ModuleName = "BMNG5111", weight1 =10, weight2=20}
            );

            return BCOM1;
        }

    }

}




