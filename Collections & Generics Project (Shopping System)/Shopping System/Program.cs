namespace Shopping_System
{
    internal class Program
    {
        public static List<string> Products = new List<string>();
        public static Dictionary<string, double> productPrices = new Dictionary<string, double>() {
            {"Camera", 1500 },
            {"Laptop", 10000 },
            {"Mouse", 40 },
            {"IPhone", 5000 }
        };
        public static Stack<(int code, string product)> actions = new Stack<(int code, string product)>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Our Shopping System!\n");
            while (true) {
                Console.WriteLine("Avialable Actions:\n");
                Console.WriteLine("1. View Cart");
                Console.WriteLine("2. Add Item To The Cart");
                Console.WriteLine("3. Remove Item From The Cart");
                Console.WriteLine("4. Checkout");
                Console.WriteLine("5. Undo Last Action");
                Console.WriteLine("6. Exit\n");

                Console.WriteLine("Enter your number choice:");
                var userChoice = Console.ReadLine();

                switch (userChoice) {
                    case "1":
                        viewCart();
                        break;
                    case "2":
                        addItemToTheCart();
                        break;
                    case "3":
                        removeItemFromTheCart();
                        break;
                    case "4":
                        checkOut();
                        break;
                    case "5":
                        undoLastAction();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Number!");
                        break;
                }
            }
        }

        static void viewCart() {
            if (Products.Count > 0) {
                Console.WriteLine("\nProducts In Your Cart:");
                foreach (var product in Products) {
                    Console.WriteLine($"{product}");
                }

                double cartProductsTotalPrice = calculateTotalPrice();
                Console.WriteLine($"Total Price: {cartProductsTotalPrice}\n");

            } else {
                Console.WriteLine("\nNo Items In The Cart!\n");
            }
        }
        static double calculateTotalPrice() {
            double totalPrice = 0.0;
            foreach(var product in Products) {
                bool foundItem = productPrices.TryGetValue(product, out double price);
                if (foundItem) {
                    totalPrice += price;
                }
            }

            return totalPrice;
        }
        static void viewProducts() {
            if(productPrices.Count > 0) {
                Console.WriteLine("\nAvaliable Products:");
                foreach (var product in productPrices) {
                    Console.WriteLine($"{product.Key} : {product.Value}");
                }
            } else {
                Console.WriteLine("\nNo Available Products!");
            }

            Console.Write("\n");
        }
        static void addItemToTheCart() {
            viewProducts();
            Console.WriteLine("Enter The Product Title To Add:");

            var productTitle = Console.ReadLine();
            foreach(var product in productPrices) {
                if(product.Key == productTitle) {
                    addExistProductToCart(productTitle);
                    actions.Push((1, productTitle));

                    return;
                }
            }

            Console.WriteLine("Couldn't Find The Product!\n");
        }
        static void removeItemFromTheCart() {
            viewCart();

            Console.WriteLine("Enter The Product Name To Remove:\n");
            var productToRemoveFromTheCart = Console.ReadLine();

            if (productToRemoveFromTheCart is not null) {
                if (Products.Contains(productToRemoveFromTheCart)) {
                    removeExistProductFromCart(productToRemoveFromTheCart);
                    actions.Push((2, productToRemoveFromTheCart));
                } else {
                    Console.Write("Couldn't Find Product In Your Cart!\n");
                }
            } else {
                Console.WriteLine("Invalid Input!\n");
            }
        }
        static void checkOut() {
            viewCart();
            Console.WriteLine("Please Proceed To Payment .. Thank You For Shopping With Us!\n");
            Products.Clear();
        }
        static void undoLastAction() {
            var (code, productTitle) = actions.Peek();
            if(code == 1) {
                Console.WriteLine($"Your last action was adding the item: {productTitle} to your cart");
                removeExistProductFromCart(productTitle);
            } else {
                Console.WriteLine($"Your last action was deleting the item: {productTitle} from your cart");
                addExistProductToCart(productTitle);
            }
        }

        // The following two methods is used to add/remove item that's known to be in the cart.
        static void removeExistProductFromCart(string productTitle) {
            Products.Remove(productTitle);
            Console.WriteLine("Product Deleted Successfully From Your Cart!\n");
        }
        static void addExistProductToCart(string productTitle) {
            Products.Add(productTitle);
            Console.WriteLine("Product Added To Your Cart Successfully!\n");
        }
    }
}
