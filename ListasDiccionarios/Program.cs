using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ListasDiccionarios {
    class Program {
        private static List<string> losNombres = new List<string>();
        private static Dictionary<int, string> miDiccionario = new Dictionary<int, string>();

        static void Main(string[] args) {
            LlenarLista();
            LlenarDiccionario();


            Debug.WriteLine("Valor elemento índice 2 de la lista " + losNombres[2]);

            string valorDiccionario = "";

            if(miDiccionario.TryGetValue(43,out valorDiccionario))
                Debug.WriteLine("El valor del key en el diccionario es " + valorDiccionario);
            else
                Debug.WriteLine("No existe key en el diccionario");


            Debug.WriteLine("Valor elemento índice 2 de la lista " + losNombres[2]);

            //Eliminar elementos en lista
            losNombres.RemoveAt(2);
            //Eliminar elemento en diccionario
            miDiccionario.Remove(10);



            Debug.WriteLine("\n------------Lista----------------------");
            for (int i = 0; i < losNombres.Count; i++) {
                Debug.WriteLine("Elemento índice {0} es -> {1}", i,losNombres[i]);
            }
            Debug.WriteLine("Con foreach-----------------------------");
            foreach (string item in losNombres) {
                Debug.WriteLine("Elemento en lista" + item);
            }

            Debug.WriteLine("\n------------Diccionario----------------------");
            foreach (KeyValuePair<int,string> item in miDiccionario) {
                Debug.WriteLine("Elelemnto en diccionario con clave {0} y valor {1}", item.Key, item.Value);

            }

            miDiccionario.




        }


        private static void LlenarLista(){ 
            losNombres.Add("Uno");
            losNombres.Add("Dos");
            losNombres.Add("Tres");
            losNombres.Add("Cuatro"); 
        }

        private static void LlenarDiccionario(){
            miDiccionario.Add(1,"nombre rut 1-9");
            miDiccionario.Add(10,"nombre rut 10-8");
            miDiccionario.Add(11,"nombre rut 11-6");
            miDiccionario.Add(2,"nombre rut 2-1");
        }
    }
}
