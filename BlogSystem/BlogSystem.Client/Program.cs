using BlogSystem.Data;
using BlogSystem.Data.Models;
//using blogsystem.logic;
//using blogsystem.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BlogSystem.Client
{
    static class Extension
    {
        public static void ToProcess<T>(this IEnumerable<T> query, string headline)
        {
            Console.WriteLine($"\n:: {headline} ::\n");

            foreach (var item in query)
                Console.WriteLine("\t" + item);

            Console.WriteLine("\n\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // HUNGARIAN
            /* Vastagkliens módszerrel lepéldányosítunk mindent
             * 
             * Helyette: a kliensünk egy frontend alkalmazás szerepét veszi fel
             * és az API réteggel fog kommunikálni
             *
             * Ehhez a kliens csak a Models réteget ismeri majd, mást nem.
             * Ezt ideálisabb lenne egy külön projectként hozzáadni, de nekünk már maradt a Data rétegben, így az van hozzáadva.
             */

            // ENGLISH
            /*
             * As a so-called thick client we have access to all the layers here and create objects here.
             * 
             * Instead: our client will be a frontend application and will communicate with the API layer.
             * 
             * For that the client should only know about the Models, nothing else.
             * It would be more ideal if Models were created here as a separate project, not being part of the Data layer, but for now it is ok like that.
             */


            /*
             * 
             * Steps:
             * 
             * delete project references from client except for Data layer/project (or if there is dedicated Models project)
             *
             * sln add new project
             *      BlogSystem.Endpoint
             *      ASP.NET Core Empty Project!!!
             *      ASP.NET Core 5.0
             *      HTTPS not needed
             *      
             * set as startup the Endpoint project
             * run, check if browser opens (launchsettings.json --> localhost:0123)
             * set chrome as default browser for IIS
             * 
             * add references to Endpoint layer (Data + Repo + Logic)
             * 
             * Startup.cs --> UseEndpoints update
             * Startup.cs --> ConfigureServices update
             * 
             * Create Controllers folder in Endpoint
             * Add controllers
             *      API --> API with read/write
             *      update main route
             *      add ctor with interface reference
             *      update http method routes
             *      
             * launchSettings.json --> launchUrl --> set default url
             * 
             * add IoC --> startup.cs --> add transients
             * 
             * JSON serialization problem --> JsonIgnore
             * 
             * nonCrud --> statController --> main route update []/[action]
             * 
             * Test from browser (GET)
             * Test from Postman (POST, PUT, DELETE)
             *      GetAll
             *      GetById
             *      POST -> body -> raw -> json
             * 
             * Client --> add nuget WebApi.Client
             * 
             * RestService --> similar to JS Fetch API
             * 
             * Sln -> properties -> multiple startup project (client + endpoint)
             *      Thread.sleep in client
             *      
             * Test through RestService calls
             * 
             */


            // TODO test RestService from here







            #region ThickClientApproach
            //BlogContext blogCtx = new BlogContext();
            //BlogRepository blogRepo = new BlogRepository(blogCtx);

            //CommentRepository commentRepo = new CommentRepository(blogCtx);
            //CommentLogic commentLogic = new CommentLogic(commentRepo); 

            //BlogLogic blogLogic = new BlogLogic(blogRepo, commentRepo);



            //ListAll(blogLogic);

            //ListAll(commentLogic);

            //GetCommentNumberPerCategory(blogLogic);
            #endregion

        }
        #region ThickClientApproach
        //private static void ListAll(BlogLogic logic)
        //{
        //    Console.WriteLine("\n:: ALL BLOGS ::\n");

        //    logic.GetAllBlogs()
        //        .ToList()
        //        .ForEach(x => Console.WriteLine("\t" + x.MainData));
        //}

        //private static void ListAll(CommentLogic logic)
        //{
        //    Console.WriteLine("\n:: ALL COMMENTS ::\n");

        //    logic.GetAllComments()
        //        .ToList()
        //        .ForEach(x => Console.WriteLine("\t" + x));
        //}

        //private static void GetCommentNumberPerCategory(BlogLogic logic)
        //{
        //    logic.GetCommentNumberPerCategory()
        //        .ToProcess("COMMENT COUNT PER CATEGORY");
        //}
        #endregion
    }
}
