﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using BlogHost.BLL.DTO;

namespace BlogHost.BLL.ServiceInterfaces
{
    public interface IBlogService
    {
        bool HasAccess(int? blogId, ClaimsPrincipal currentUser);
        void Delete(int? id, ClaimsPrincipal currentUser);
        BlogDTO GetBlog(int? id, ClaimsPrincipal currentUser, bool checkAccess = true);
        void Edit(BlogDTO blog);
        int? GetBlogId(string title);
        void Create(BlogDTO blog, ClaimsPrincipal currentUser);
        IEnumerable<BlogDTO> Search(string title, string userName, int page, int pageSize, out int blogsCount);
        IEnumerable<BlogDTO> GetPageBlogs(int page, int pageSize, ClaimsPrincipal currentUser, out int blogsCount);
    }
}
