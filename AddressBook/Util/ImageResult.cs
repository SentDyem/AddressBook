﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AddressBook.Util
{
    public class ImageResult : ActionResult
    {
        private string path;

        public ImageResult(string path)
        {
            this.path = path;
        }
            
        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Write("<div style = 'width:90%; text-align:center;'>" +
                "<img style = 'max-width:600px;' src='" + path + "' /></div>");
        }
    }
}