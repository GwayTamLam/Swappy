namespace Swappy.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string CartsEndpoint = $"{Prefix}/carts";
        public static readonly string CartItemsEndpoint = $"{Prefix}/cartitems";
        public static readonly string CategoriesEndpoint = $"{Prefix}/categorys";
        public static readonly string MessagesEndpoint = $"{Prefix}/messages";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string OrderItemsEndpoint = $"{Prefix}/orderitems";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string UsersEndpoint = $"{Prefix}/users";
    }
}
