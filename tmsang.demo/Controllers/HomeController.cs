using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tmsang.demo
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly MyFatherService _myFatherService;
        private readonly MyMotherService _myMotherService;

        public HomeController(MyFatherService myFatherService, MyMotherService myMotherService)
        {
            _myFatherService = myFatherService;
            _myMotherService = myMotherService;
        }

        [HttpGet]
        public string Get()
        {
            return $"Father Creation Count : {MyFatherService.CreationCount}. Mother Creation Count : {MyFatherService.CreationCount}. Child Creation Count : {MyChildService.CreationCount}";
        }
    }

    public class MyChildService
    {
        public static int CreationCount { get; private set; }

        public MyChildService()
        {
            CreationCount++;
        }
    }

    public class MyFatherService
    {
        public static int CreationCount { get; private set; }

        private readonly MyChildService _myChildService;

        public int Count {
            get {
                return CreationCount;
            }
        }

        public MyFatherService(MyChildService myChildService)
        {
            _myChildService = myChildService;
            CreationCount++;
        }
    }

    public class MyMotherService
    {
        public static int CreationCount { get; private set; }

        private readonly MyChildService _myChildService;

        public MyMotherService(MyChildService myChildService)
        {
            _myChildService = myChildService;
            CreationCount++;
        }
    }
}
