using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Domain.IRepository;
using Domain.BaseModule;

namespace Infrastructure.Repository
{
    public class BaseRepository<TAggregateRoot> : IBaseRepository<TAggregateRoot> where TAggregateRoot : AggregateRoot
    {
        //现在需要一个可以把内存数据保存到数据库中的东西
        //也就是被称之为数据持久化的一个过程
        //先直接用EF实现，以后要换ORM就要重写基类的基本方法，若再添加一个数据库上下文接口,不好确定接口需要哪些功能，增加了复杂性，所以不用接口

        readonly private EFContext _EFContext;
        public BaseRepository(EFContext EFContext)
        {
            _EFContext = EFContext;
        }
        

        //先用原生EF实现，后考虑DLL的扩展方法

        #region//通用仓储CRUD实现
        public int Add(TAggregateRoot aggregateRoot)
        {
            _EFContext.Set<TAggregateRoot>().Add(aggregateRoot);
            return 1;
        }

        public int AddRange(IQueryable<TAggregateRoot> aggregateRoots)
        {
            return _EFContext.Set<TAggregateRoot>().AddRange(aggregateRoots).Count();
        }

        public IQueryable<TAggregateRoot> Find(Expression<Func<TAggregateRoot,bool>> expression)
        {
           return _EFContext.Set<TAggregateRoot>().Where(expression);
        }

        public int Remove(TAggregateRoot aggregateRoot)
        {
            _EFContext.Set<TAggregateRoot>().Remove(aggregateRoot);
            return 1;
        }

        public int RemoveRange(IQueryable<TAggregateRoot> aggregateRoots)
        {

            return _EFContext.Set<TAggregateRoot>().RemoveRange(aggregateRoots).Count();
        }

        public int Update(TAggregateRoot aggregateRoot)
        {
            _EFContext.Entry<TAggregateRoot>(aggregateRoot).State = EntityState.Modified;
            return 1;
        }

        public int UpdateRange(IQueryable<TAggregateRoot> aggregateRoots)
        {
            foreach(var x in aggregateRoots)
            {
                _EFContext.Entry(aggregateRoots).State = EntityState.Modified;
            }
            return aggregateRoots.Count();
        }
        #endregion







    }
}
