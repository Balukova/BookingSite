using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Data;
using Mappers;
using Entities;
namespace BL
{
    public class ProductInShopService : IProductInShopService
    {
        private IUnitOfWork unitOfWork;
        private IMapper<ProductInShop, ProductInShopEntity> productInShopMapper;
        public ProductInShopService(IUnitOfWork unitOfWork, IMapper<ProductInShop, ProductInShopEntity> productInShopMapper)
        {
            this.productInShopMapper = productInShopMapper;
            this.unitOfWork = unitOfWork;
        }

        public void DecreaseQuantity(ProductInShop entity)
        {
            unitOfWork.ProductInShopRepository.DecreaseQuantity(productInShopMapper.ToEntity(entity));
        }

        public IList<ProductInShop> GetProductInShopsByProductName(string name)
        {
            return unitOfWork.ProductInShopRepository.GetProductInShopsByProductName(name).Select(pis=>productInShopMapper.ToDomain(pis)).ToList();
        }

        public void IncreaseQuantity(ProductInShop entity)
        {
            unitOfWork.ProductInShopRepository.IncreaseQuantity(productInShopMapper.ToEntity(entity));
        }
    }
}
