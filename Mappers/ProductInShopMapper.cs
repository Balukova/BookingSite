using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models;
namespace Mappers
{
    public class ProductInShopMapper : IMapper<ProductInShop, ProductInShopEntity>
    {
        private IMapper<Shop, ShopEntity> shopMapper;
        private IMapper<Product, ProductEntity> productMapper;

        public ProductInShopMapper(IMapper<Shop, ShopEntity> shopMapper, IMapper<Product, ProductEntity> productMapper)
        {
            this.shopMapper = shopMapper;
            this.productMapper = productMapper;
        }
        public ProductInShop ToModel(ProductInShopEntity entity)
        {
            if (entity == null) return null;
            return new ProductInShop { Id = entity.Id, Quantity = entity.Quantity, Product = productMapper.ToModel(entity.Product), Shop = shopMapper.ToModel(entity.Shop), Price = entity.Price, ShopId = entity.ShopId, ProductId = entity.ProductId };
        }

        public ProductInShopEntity ToEntity(ProductInShop model)
        {
            if (model == null) return null;
            return new ProductInShopEntity { Id = model.Id, Quantity = model.Quantity, Product = productMapper.ToEntity(model.Product), Shop = shopMapper.ToEntity(model.Shop), Price = model.Price, ProductId = model.ProductId, ShopId = model.ShopId };
        }
    }
}
