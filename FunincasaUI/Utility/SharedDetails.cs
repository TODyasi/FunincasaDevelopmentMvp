namespace FunincasaUI.Utility
{
    public class SharedDetails
    {
        public static string RecipeAPIBase{get; set;}
        public static string AuthenticationAPIBase {get; set;}


        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public const string Status_Pending = "Pending";
        public const string Status_Approved = "Approved";

        public enum ContentType
        {
            Json,
            MultipartFormData,
        }
    }
}
