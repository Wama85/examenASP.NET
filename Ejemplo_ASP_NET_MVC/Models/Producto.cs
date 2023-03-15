namespace Ejemplo_ASP_NET_MVC.Models
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }//Para el ejemplo de carrito, se ignora este atributo
    }
}
