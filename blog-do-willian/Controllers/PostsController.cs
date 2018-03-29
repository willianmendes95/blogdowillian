﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using blog_do_willian.Models;

namespace blog_do_willian.Controllers
{
    public class PostsController : Controller

    {
        private BlogContext _context = new BlogContext();
        // GET: Posts
        public ActionResult Index()
        {
            var posts =_context.Posts.ToList();
            return View(posts);
        }

        public ActionResult Details(int id)
        {
            var post = _context.Posts.SingleOrDefault(p => p.Id == id);
            if(post == null)
            {
                return HttpNotFound(); 
            }


                return View();
        }

        public ActionResult Edit(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult DeleteComplete(int id)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Post post)
        {
            return View();
        }


    }
}