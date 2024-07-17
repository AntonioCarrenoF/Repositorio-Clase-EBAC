using System.Collections;
using System.Collections.Generic;
using System.Linq; //se agregó para poder usar funiones de extension
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
        DemoDictionary("escopeta"); //funcion para extraer del diccionario, se imprime el valor el arma
        DemoDictionary("espada");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DemoListas() //se encapsuló en una funcion creada por mi
    {

        for (int i = 0; i < 10; i++)
        {
            //listaNumeros.Add(i); //utiliza para lista normal del 0 al 19
            listaNumeros.Add(Random.Range(0, 20)); //se utiliza para una lista aleatoria del 0 al 20
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        //listaNumeros.Sort(); //se utiliza para ordenar la lista de numeros en orden
        var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();
        var listaValoresGrandes = listaNumeros.Where(p => p > 10).ToList();
        Debug.Log("lista base");
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista de numeros ordenada");
        foreach(var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista de numeros grandes");
        foreach(var numero in listaValoresGrandes)
        {
            Debug.Log(numero);
        }

        //listaString.Add("Diego");
        //listaString.Add("Sofia");
        //listaString.Add("Daniel");
        //listaString.Add("Javier");
        //listaString.Add("Diana");
        //foreach (var nombre in listaString)
        //{
        //    Debug.Log(nombre);
        //}
        //listaString.Remove("Javier"); //se utiliza para eliminar elementos de una lista
        //listaString.Remove("Daniel");
        //listaString.RemoveAt(2); //otro ejemplo para remover a Daniel
        //foreach (var nombre in listaString)
        //{
        //    Debug.Log(nombre);
        //}



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
        ///FIFO = First in first out (PEPS) se utiliza en colas
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


    public void DemoPilas()
    {
        ///FILO = First in last out (UEPS) se utiliza en pilas
        pilaStrings.Push("as");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek()); //primero saldra el rey de espadas y despues cuatro treboles y así sucesivamente
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
    }


    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderArmas.ContainsKey("rifle")) //se utiliza para corregir errores y el !para convertir en negativo
        {
            poderArmas.Add("rifle", 7.0f);
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }
        if (poderArmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("esa arma no existe");
        }
    }
}
