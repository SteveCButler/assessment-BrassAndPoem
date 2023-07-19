
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
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
        ProductTypeId = 2
    }, new Product
    {
        Name = "Rhyme of the Ancient Mariner",
        Price = 20.00M,
        ProductTypeId = 2
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
    DisplayMenu();

}
void DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine(@"
    ---------MENU---------
    1. Display All Products
    2. Delete A Product
    3. Add New Product
    4. Update Product Properties
    5. Exit
    ");
    Console.Write(@"Choice: ");
    choice = Console.ReadLine();
    Console.WriteLine();

    int choiceId = int.Parse(choice);
    switch (choiceId)
    {
        case 1:
            DisplayAllProducts();
            break;
        case 2:
            DeleteProduct();
            break;
        case 3:
            AddProduct();
            break;
        case 4:
            UpdateProduct();
            break;
        case 5:
            return;

    }
}

void DisplayAllProducts()
{
    for (int i = 0; i < products.Count; i++)
    {
        var value = productTypes.First(p => p.Id == products[i].ProductTypeId);
               
        Console.WriteLine($"{i + 1}. {products[i].Name}, from our {value.Title} collection, costs ${products[i].Price}");

    }
}

void DeleteProduct()
{
    DisplayAllProducts();
    Console.WriteLine();
    Console.WriteLine("Select the product you wish to delete: ");

    int productToDelete = Convert.ToInt32( Console.ReadLine() );

    products.RemoveAt( productToDelete - 1 );

}

void AddProduct()
{
    Console.WriteLine();
    Console.Write("Enter the name of the product: ");
    var productName = Console.ReadLine();
    Console.Write("Enter the price: ");
    var productPrice = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Select product type: ");

    foreach(ProductType type in productTypes)
    {
        var index = productTypes.IndexOf(type);
        Console.WriteLine($"{index + 1}. {type.Title}");
    }
    var prodType = Convert.ToInt32(Console.ReadLine());

    products.Add(
        new Product()
        {
            Name = productName,
            Price = productPrice,
            ProductTypeId = prodType

        });

}

void UpdateProduct()
{
    DisplayAllProducts();
    Console.WriteLine();

    Console.WriteLine("Please select the item to update: ");
    var itemIndex = Convert.ToInt32( Console.ReadLine() );

    var item = products[itemIndex - 1];

    Console.WriteLine("Enter new name: ");
    var newName = Console.ReadLine();
    Console.WriteLine("Enter new price: ");
    var newPrice = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Update Product Type");
    foreach (ProductType type in productTypes)
    {
        var index = productTypes.IndexOf(type);
        Console.WriteLine($"{index + 1}. {type.Title}");
    }
    var newProdType = Convert.ToInt32(Console.ReadLine());


    //Update properties
    item.Name = newName;
    item.Price = newPrice;
    item.ProductTypeId = newProdType;


}

//don't move or change this!
public partial class Program { }

