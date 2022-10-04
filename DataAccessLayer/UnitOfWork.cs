using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repository;

namespace DataAccessLayer
{
    public class UnitOfWork
    {
        ProductFindingAutomationContext _context;

        public UnitOfWork()
        {
            _context = ProductFindingAutomationContext.ContextOlustur();
        }

        private ProductRepository _productRepository;

        public ProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_context);
                }

                return _productRepository;
            }
        }

        private DbContextTransaction _tran;

        public bool ApplyChanges()
        {
            bool isSucces = false;
            _tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            try
            {
                _context.SaveChanges();
                _tran.Commit();
                isSucces = true;
            }
            catch (Exception)
            {
                _tran.Rollback();
                isSucces = false;
            }
            finally
            {
                _tran.Dispose();
            }

            return isSucces;
        }
    }
}
