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
        ///FIFO = First in first out (PEPS)
        ///FILO = First in last out (UEPS)

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DemoListas() //se encapsuló en una funcion creada por mi
    {
        for (int i = 0; i < 20; i++)
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

    public void DemoHashSet()
    {
        for (int i = 0; i < 20; i++)
        {
            hashSetInts.Add(i);
        }
        if (hashSetInts.Contains(5)) //se utiliza para realizar busquedas de un elemento
        {
            hashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El Hash set no contiene este elemento");
        }
    }


    public void DemoColas()
    {
        colaStrings.Enqueue("proyectil 1");
        colaStrings.Enqueue("proyectil 2");
        colaStrings.Enqueue("proyectil 3");
        colaStrings.Enqueue("proyectil 4");
        colaStrings.Enqueue("proyectil 5");
        Debug.Log(colaStrings.Peek()); //se imprime el primer elemento de los datos
        colaStrings.Dequeue(); //se elimina el proyectil 1
        Debug.Log(colaStrings.Peek()); //se imprime el primer elemento de los datos proyectil 2
        colaStrings.Dequeue(); //se elimina el proyectil 2 y asi sucesivamente
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }
}
