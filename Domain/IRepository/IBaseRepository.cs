using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Domain.BaseModule;

namespace Domain.IRepository
{

    /// <summary>
    /// 通用仓储接口，定义基本的CRUD操作
    /// </summary>
    public interface IBaseRepository<TAggregateRoot> where TAggregateRoot:AggregateRoot
    {
        //增
        int Add(TAggregateRoot aggregateRoot);
        int AddRange(IQueryable<TAggregateRoot> aggregateRoots);

        //更
        int Update(TAggregateRoot aggregateRoot);
        int UpdateRange(IQueryable<TAggregateRoot> aggregateRoots);

        //删
        int Remove(TAggregateRoot aggregateRoot);
        int RemoveRange(IQueryable<TAggregateRoot> aggregateRoots);

        //查
        IQueryable<TAggregateRoot> Find(Expression<Func<TAggregateRoot,bool>> expression);
    }
}
