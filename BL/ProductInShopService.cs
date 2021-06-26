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

        public void DecreaseQuantity(ProductInShop model)
        {

            model.Quantity -= 1;
            unitOfWork.ProductInShopRepository.Update(productInShopMapper.ToEntity(model));
        }

        public IList<ProductInShop> GetProductInShopsByProductName(string name)
        {
            return unitOfWork.ProductInShopRepository.GetAvailableProductInShopsByProductName(name).Select(pis=>productInShopMapper.ToModel(pis)).ToList();
        }

        public void IncreaseQuantity(ProductInShop model)
        {
            model.Quantity += 1;
            unitOfWork.ProductInShopRepository.Update(productInShopMapper.ToEntity(model));
        }
    }
}
