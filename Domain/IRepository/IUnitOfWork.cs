using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.IRepository
{
    public interface IUnitOfWork
    {



        void Transition();
        void EndTransition();
        bool Commit();
    }
}
