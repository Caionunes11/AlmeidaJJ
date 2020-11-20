using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almeida.WindowsForms
{
   public abstract class AbstractRepository<TEntity, TKey>
     where TEntity : class   
    {
        public string ConnectionStrings { get { return ConfigurationManager.ConnectionStrings["Almeida.WindowsForms.Properties.Settings.AlmeidaCnn"].ConnectionString; } }

        public abstract List<TEntity> GetAll();
        public abstract TEntity GetById(TKey id);
        public abstract void Save(TEntity entity);
        public abstract void Update(TEntity entity);
        public abstract void Delete(TEntity entity);
        public abstract void DeleteById(TKey id);


    }
}
