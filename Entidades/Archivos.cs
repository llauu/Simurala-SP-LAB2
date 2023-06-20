using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades {
    public static class Archivos<T> where T : class {
        public static List<T>? LeerArchivoJson(List<T>? lista, string rutaJSON) {
            if (File.Exists(rutaJSON)) {
                using (StreamReader sr = new StreamReader(rutaJSON)) {
                    string json_str = sr.ReadToEnd();

                    lista = JsonConvert.DeserializeObject<List<T>>(json_str);
                }
            }

            return lista;
        }

        public static bool EscribirArchivoJson(List<T>? lista, string rutaJSON) {
            bool guardado = false;

            JsonSerializerSettings configuracion = new JsonSerializerSettings();
            configuracion.Formatting = Formatting.Indented;
            configuracion.PreserveReferencesHandling = PreserveReferencesHandling.Objects;

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonConvert.SerializeObject(lista, configuracion);

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }

        public static bool DescargarRegristroPartida(Partida partida, string ruta) {
            bool descargado = false;

            if(partida is not null) {
                string registro = partida.RegistroDeJuego;

                using (StreamWriter file = new StreamWriter(ruta, false, Encoding.UTF8)) {
                    file.WriteLine(registro);
                    file.Close();

                    descargado = true;
                }
            }

            return descargado;
        }
    }
}
