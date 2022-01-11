using Store;
using Store.Models;
using Store.Models.Abstractions;

public class Program
{
    static void Main(string[] args)
    {
        PrepCart();


    }
    public void PrintReceipt(Cart cart)
    {

    }
    public static void PrepCart()
    {
        Cart cart = new Cart();
        cart.AddItems();
        cart.TotalDiscount();
        EntityTypeCounter counter = cart.cart.Aggregate(
            new EntityTypeCounter(),
            (acc, item) => { item.Accept(acc); return acc; });
    }
}