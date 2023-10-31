namespace ServiciosTecnicos.Services.WebApi.Modelos
{
    public class LoginModel
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }

        public LoginModel()
        {
            this.Usuario = "";
            this.Contrasena = "";
        }
    }
}
