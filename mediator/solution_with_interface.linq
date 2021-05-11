<Query Kind="Program" />

void Main()
{

}

public class Product
{
	public int Id { get; set; }
}

public interface ICartInteraction {
	void AddToCart(int id);
}

public class ShopContext : ICartInteraction {
	Cart cart; 
	Catalog catalog; 
	ProductPage page;
	
	public ShopContext(Cart cart, Catalog catalog, ProductPage page)
	{
		this.cart = cart;
		this.catalog = catalog;
		this.page = page;
		
		this.page.DisplayProducts(catalog.getProducts());
	}

	public void AddToCart(int id)
	{
		cart.AddProduct(catalog.getProducts().First(x => x.Id == id));
	}
}

public class Cart
{
	List<Product> products;

	public void AddProduct(Product product)
	{
		products.Add(product);
	}
}

public class Catalog
{
	List<Product> products;
	
	public List<Product> getProducts(){
		return products;
	}
}

public class ProductPage
{
	ICartInteraction cart;
	public ProductPage(ICartInteraction cart) => this.cart = cart;

	public void AddToCart(int id) => cart.AddToCart(id);

	public void DisplayProducts(List<Product> products)
	{
		// set ui elements
	}
}