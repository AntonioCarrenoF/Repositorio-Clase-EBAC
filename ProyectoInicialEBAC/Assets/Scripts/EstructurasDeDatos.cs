using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();
    List<string> listaString = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>(); //lista sin repetir elementos y sin ordenar
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();


    // Start is called before the first frame update
    void Start()
    {
        for (int i=0; i < 20; i++)
        {
            //listaNumeros.Add(i); //utiliza para lista normal del 0 al 19
            listaNumeros.Add(Random.Range(0, 20)); //se utiliza para una lista aleatoria del 0 al 20
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaNumeros.Sort(); //se utiliza para ordenar la lista de numeros en orden
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }


        listaString.Add("Diego");
        listaString.Add("Sofia");
        listaString.Add("Daniel");
        listaString.Add("Javier");
        listaString.Add("Diana");
        foreach (var nombre in listaString)
        {
            Debug.Log(nombre);
        }
        listaString.Remove("Javier"); //se utiliza para eliminar elementos de una lista
        listaString.Remove("Daniel");
        listaString.RemoveAt(2); //otro ejemplo para remover a Daniel
        foreach (var nombre in listaString)
        {
            Debug.Log(nombre);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
