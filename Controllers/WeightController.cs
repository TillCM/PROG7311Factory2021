using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using cassfactory.Factory;
using cassfactory.LogicManager;


namespace cassfactory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeightController : ControllerBase
    {


        [HttpGet]
        public List<Course> Get(string courseParameter="BCAD")
        {
        
            CourseFactory courseFactory = new CourseFactory();
            ICourseManager courseManager = courseFactory.GetIcourse(courseParameter);
            List<Course> bcadReturnedData = courseManager.getCourseData();
            return bcadReturnedData;
        }
    }
}
