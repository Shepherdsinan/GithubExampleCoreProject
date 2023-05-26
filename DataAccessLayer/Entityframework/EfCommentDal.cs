﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Entityframework;

public class EfCommentDal : GenericRepository<Comment>, ICommentDal
{
    public List<Comment> GetListCommentWithDestination()
    {
        using (var c = new Context())
        {
            return c.Comments.Include(x => x.Destination).ToList();
        }
    }
}