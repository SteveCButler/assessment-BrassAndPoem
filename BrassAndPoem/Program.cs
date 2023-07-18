
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using BrassAndPoem;

List<Product> products = new List<Product>
{
    new Product
    {
        Name = "Trumpet",
        Price = 200.00M,
        ProductTypeId = 1
    }, new Product
    {
        Name = "Trombone",
        Price = 350.00M,
        ProductTypeId = 1
    }, new Product
    {
        Name = "Tuba",
        Price = 600.00M,
        ProductTypeId = 1
    }, new Product
    {
        Name = "Emily Dickenson Complete Works",
        Price = 45.00M,
        ProductTypeId = 1
    }, new Product
    {
        Name = "Rhyme of the Ancient Mariner",
        Price = 20.00M,
        ProductTypeId = 1
    },

};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>
{
    new ProductType
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType
    {
        Title = "Poem",
        Id = 2
    }

};

//put your greeting here
Console.WriteLine("Welcome to Brass & Poems");

//implement your loop here
string choice = null;

while (choice != "5")
{
    Console.WriteLine("please choose an option");
    choice = Console.ReadLine();
    if (choice == "5")
    {
        return;
    }

}
void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }
