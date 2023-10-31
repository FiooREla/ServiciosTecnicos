namespace ServiciosTecnicos.Aplication.Dto
{
    public class CategoriaDto
    {
        //se ponen atributos que van a ser expuestos enla webapi, puedes quitar o agregar
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
    }
}