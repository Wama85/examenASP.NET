using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Ejemplo_ASP_NET_MVC.Herramientas
{
    public static class ConversorParaSesiones
    {
        //Guardar objeto C# a Json (objeto -> json)
        public static void ObjetoAjson(this ISession sesion, string llave, object valor) {
            sesion.SetString(llave,JsonConvert.SerializeObject(valor));
        }

        //Guardar Json a objeto C# (json -> objeto)
        public static T JsonAobjeto<T>(this ISession sesion, string llave) {
            string valor = sesion.GetString(llave);//  {"Id": "prod01","Nombre": "Atún","Foto": "atun.jpg"}
            return valor == null ? default(T) : JsonConvert.DeserializeObject<T>(valor);
    }
    }
}
