using RepositoryModel;
using System;
using System.Collections.Generic;
using System.Text;
using ModelsLayer;


namespace BusinessLogic
{
    public interface IUnitOfWork
    {


        void SaveChanges();


    }
}
