using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EFcore 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            context Context = new context();

            #region eager loading
            //egar loading(when i do query for department i will bring with it the colletion on(related with) it)


            //var query =( Context.departments.AsSplitQuery()
            //.Include(n=>n.projects)
            //.Include(n => n.employees)         
            //.ThenInclude(e=> e.attendances)).ToList();

            #endregion


            #region explict loading
            //var query = Context.departments.ToList();

            //foreach (var item in query)
            //{
            //    Context.Entry(item).Collection(n => n.employees).Load();
            //    Context.Entry(item).Reference(n => n.branch).Load();
            //    foreach (var empl in item.employees)
            //    {
            //        Console.WriteLine(empl.name);
            //    }
            //    Console.WriteLine(item.name);


            //}
            #endregion


            #region lazy loadinng
            //var query = Context.departments.ToList();
            //foreach (var item in query)
            //{
            //    foreach (var empl in item.employees)
            //    {
            //        Console.WriteLine(empl.name);
            //    }
            //    Console.WriteLine(item.name);


            //}
            #endregion

            #region client evaluation(with select only) .vs server evaluation
            //client evaluation (execute in memory in application)<<(ex)join and store in memor
            //server evaluation(in DB)<<(ex)pring name


            //var qury = (from d in Context.departments
            //            select string.Join(':', "DEPT", d.name)
            //             ).ToList(); 
            //foreach(var x in qury)
            //Console.WriteLine(x);
            #endregion


            #region EF function (to use some function that exist in DB)
            //var query5 = (from d in Context.departments
            //              where EF.Functions.Like(d.name, "%4%")
            //              select d
            //         ).ToList();

            //foreach (var x in query5)
            //    Console.WriteLine(x.name);

            #endregion

            #region global query filter( (hasqueryfilter)onmodelcreating)
            var query = (from d in Context.employees
                             //where !d.deleted
                         select d
                            ).ToList();

            foreach (var x in query)
                Console.WriteLine(x.name);
            #endregion

            #region shadow proberity
            #endregion

        }
    }
}