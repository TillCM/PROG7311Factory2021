using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cassfactory.LogicManager;
using cassfactory.Factory;

namespace cassfactory.Factory
{
  public class CourseFactory
  {
    ICourseManager returnInstance;

    public ICourseManager GetIcourse(string qualification)
    {

        if (qualification.Equals("BCAD"))
        {
            returnInstance = new BCADManager();
        }
        else
        {
            returnInstance = new BCOMManager();
        }

        return returnInstance;
    }


  }

}