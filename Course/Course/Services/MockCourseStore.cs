using Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course.Services
{
    public class MockCourseModelStore : IDataStore<CourseModel>
    {
        List<CourseModel> courses;


        public MockCourseModelStore()
        {
            courses = new List<CourseModel>()
            {
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "First course", ViewsCount=100, Summary="This is an course description.",ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/baboon.png" ,Level=CourseLevel.Beginner,Duration=new TimeSpan(2,35,0) ,RateCount=35} ,
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Second course",ViewsCount=100, Summary="This is an course description.",ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/barbara.png" ,Level=CourseLevel.Advanced,Duration=new TimeSpan(2,10,0) ,RateCount=90},
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Third course", ViewsCount=100, Summary="This is an course description.",ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/boat.png" ,Level=CourseLevel.Medium,Duration=new TimeSpan(3,0,0) ,RateCount=60},
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Fourth course",ViewsCount=100, Summary="This is an course description.",ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/boy.bmp",Level=CourseLevel.Medium,Duration=new TimeSpan(2,0,0) ,RateCount=75 },
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Fifth course", ViewsCount=100, Summary="This is an course description." ,ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/frymire.png",Level=CourseLevel.Beginner,Duration=new TimeSpan(1,30,0) ,RateCount=80},
                new CourseModel{ Id = Guid.NewGuid().ToString(), Name = "Sixth course", ViewsCount=100, Summary="This is an course description.",ImageUrl="https://homepages.cae.wisc.edu/~ece533/images/cat.png" ,Level=CourseLevel.Advanced,Duration=new TimeSpan(2,15,0),RateCount=65 }
            };

        }


        public async Task<bool> AddItemAsync(CourseModel course)
        {
            course.Id =   Guid.NewGuid().ToString();
            courses.Add(course);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(CourseModel course)
        {
            var oldCourseModel = courses.Where((CourseModel arg) => arg.Id == course.Id).FirstOrDefault();
            courses.Remove(oldCourseModel);
            courses.Add(course);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldCourseModel = courses.Where((CourseModel arg) => arg.Id == id).FirstOrDefault();
            courses.Remove(oldCourseModel);

            return await Task.FromResult(true);
        }

        public async Task<CourseModel> GetItemAsync(string id)
        {
            return await Task.FromResult(courses.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<CourseModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(courses);
        }
    }
}