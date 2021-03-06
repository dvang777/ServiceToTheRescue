﻿using Microsoft.AspNet.Identity.EntityFramework;
using ServiceToThe_Rescue.CustomFilters;
using ServiceToTheRescue.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiceToThe_Rescue.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        ApplicationDbContext context;
        public RoleController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        //[AuthLog(Roles = "Admin")]
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }
        [HttpPost]
        //[AuthLog(Roles = "Admin")]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}