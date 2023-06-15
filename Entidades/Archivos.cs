using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades {
    public static class Archivos<T> where T : IPersona {
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

            using (StreamWriter sw = new StreamWriter(rutaJSON)) {
                string json_str = JsonConvert.SerializeObject(lista);

                sw.WriteLine(json_str);
                guardado = true;
            }

            return guardado;
        }
    }
}
