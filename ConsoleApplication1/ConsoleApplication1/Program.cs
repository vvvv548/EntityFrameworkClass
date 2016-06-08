using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 將Credits改為列舉
            using(var db =new ContosoUniversityEntities1())
            {
                db.Database.Log =Console.WriteLine;
                var getConruse = db.Course.Find(8);
                getConruse.Credits = CourseCredits.超熱門;
                db.SaveChanges();
            }

            #endregion

            #region 目前已加入預存程序對應  新增資料會抓取預存程序
            //using (var db = new ContosoUniversityEntities1())
            //{
            //    db.Database.Log = (mag) =>
            //    {
            //        Console.WriteLine(mag);
            //    };
            //    var getDep = db.Department.Find(2);
            //    db.Entry(getDep).State = EntityState.Added;
            //    db.SaveChanges();
            //}
            #endregion

            #region 離線更新
            //var newCourse = new Course()
            //{
            //    CourseID = 99,
            //    Credits = 50,
            //    CreateTime = DateTime.Now,
            //    DepartmentID = 2,
            //    Title="九陰真經"
            //};

            //using (var db = new ContosoUniversityEntities1())
            //{
            //    newCourse = db.Course.Find(5);
            //    newCourse.Credits += 10000;                
            //    Console.WriteLine(newCourse.Credits);
            //    //DbEntityEntry entry = db.Entry(course);
            //    //entry.State = EntityState.Modified;  
            //}

            //using(var db=new ContosoUniversityEntities1())
            //{
            //    db.Entry(newCourse).State = EntityState.Modified;
            //    db.SaveChanges();
            //}
            #endregion

            #region 列出所有Course資料並測試新增與更新
            //using (var db = new ContosoUniversityEntities1())
            //{
            //foreach (var item in db.Course)
            //{
            //    Console.WriteLine(item.Title);
            //}
            //var new_Course = new Course()
            //{
            //    Title="食神來囉",
            //    Credits=3,
            //    DepartmentID=1,
            //    CreateTime=DateTime.Now
            //};
            //db.Course.Add(new_Course);

            //var update_Course = db.Course.Find(10);
            //update_Course.Title = "食神來囉(二)";
            //update_Course.ModifyTime = DateTime.Now;
            //db.SaveChanges();
            //}
            #endregion
        }
    }
}
