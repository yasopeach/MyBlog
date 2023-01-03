using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System.Collections.Generic;

namespace MyBlog.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    Username = "Canberk"
                },
                new UserComment
                {
                    Id = 2,
                    Username = "Mesut"
                },
                new UserComment
                {
                    Id = 3,
                    Username = "Ahmet"
                }
            };
            return View(commentvalues);
        }
    }
}
