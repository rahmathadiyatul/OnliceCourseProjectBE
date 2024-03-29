﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoupLocal._1_Core.Entities;
using SoupLocal._2_Service.Service;
using SoupLocal._2_Service.Service.Interface;

namespace SoupLocal.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Course course)
        {
            var result = await courseService.Create(course);
            return Ok(result);
        }
        [HttpGet]
        public async Task<List<Course>> Get()
        {
            List<Course> result = await courseService.Get();
            return result;
        }

        [HttpGet("getbycategory/{category}")]
        public async Task<List<Course>> GetByCategory(string category)
        {
            List<Course> result = await courseService.GetByCategory(category);
            return result;
        }

        [HttpGet("getbyid/{id}:int")]
        public async Task<List<Course>> GetById(int id)
        {
            List<Course> result = await courseService.GetById(id);
            return result;
        }
        /*        [HttpPut]
                public async Task<IActionResult> Update([FromBody] Course course)
                {
                    var result = await courseService.Update(course);
                    return Ok(result);
                }*/
        /*        [HttpDelete]
                public async Task<IActionResult> Delete([FromBody] int id)
                {
                    var result = await courseService.Delete(id);
                    return Ok(result);
                }*/
    }
}
