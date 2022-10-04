using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLayer
{
    public class ProductBLL : IBusiness<Product>
    {
        UnitOfWork _uow;

        public ProductBLL()
        {
            _uow = new UnitOfWork();
        }

        /// <summary>
        /// Used to add PRODUCT.
        /// </summary>
        /// <param name="item">It takes parameters in PRODUCT type.</param>
        /// <returns></returns>
        public bool Add(Product item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProductName) && (item.Price != null) &&
                (!string.IsNullOrWhiteSpace(item.SiteName)) && (item.ListDate != null))
            {
                _uow.ProductRepository.Add(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        /// <summary>
        /// Used to delete a PRODUCT.
        /// </summary>
        /// <param name="item">It takes parameters in PRODUCT type.</param>
        /// <returns></returns>
        public bool Remove(Product item)
        {
            if (item != null)
            {
                _uow.ProductRepository.Remove(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        /// <summary>
        /// Used to update the PRODUCT.
        /// </summary>
        /// <param name="item">It takes parameters in PRODUCT type.</param>
        /// <returns></returns>
        public bool Update(Product item)
        {
            if (!string.IsNullOrWhiteSpace(item.ProductName) && (item.Price != null) &&
                (!string.IsNullOrWhiteSpace(item.SiteName)) && (item.ListDate != null))
            {
                _uow.ProductRepository.Update(item);
                return _uow.ApplyChanges();
            }
            return false;
        }

        /// <summary>
        /// Returns the PRODUCT type that matches the id number.
        /// </summary>
        /// <param name="id">int id</param>
        /// <returns></returns>
        public Product Get(int id)
        {
            return _uow.ProductRepository.Get(id);
        }

        /// <summary>
        /// Returns all non-passive PRODUCT types as a list.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAll()
        {
            return _uow.ProductRepository.GetAll().ToList();
        }
    }
}
