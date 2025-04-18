﻿using System;
using System.Linq;

using EFCodeFirst.Model;


namespace EFCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

         

            using var db = new BloggingContext();

            // Note: This sample requires the database to be created before running.
            //Console.WriteLine($"Database path: {db.DbPath}.");

            // Create
            Console.WriteLine("Inserting a new blog");
            db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            db.SaveChanges();

            // Read

            Console.WriteLine("Querying for a blog");
            var blog = db.Blogs
                .OrderBy(b => b.BlogId)
                .First();

            foreach(var b in db.Blogs)
                Console.WriteLine(b.Url,b.BlogId);

            // Update
            Console.WriteLine("Updating the blog and adding a post");
            blog.Url = "https://devblogs.microsoft.com/dotnet";
            blog.Posts = new List<Post>();
            blog.Posts.Add(new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
            db.SaveChanges();

            // Delete
            Console.WriteLine("Delete the blog");
            db.Remove(blog);
            db.SaveChanges();

            Console.ReadLine();
        }
    }
}
