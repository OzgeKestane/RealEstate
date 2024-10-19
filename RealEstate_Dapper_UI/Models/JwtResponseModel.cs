namespace RealEstate_Dapper_UI.Models
{
    public class JwtResponseModel
    {
        public string Token { get; set; } //tokenın kendisini tutacak
        public DateTime ExpireDate { get; set; } //geçerlilik süresini tutacak
    }
}
