using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EjerciciosEstructuras : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var primerEjercicio = ListaAleatoria(10, 1, 5);
        Debug.Log(string.Join(" ", primerEjercicio));

        var segundoEjercicio = arreglosEnteros(primerEjercicio.ToArray());
        Debug.Log(string.Join(" ", segundoEjercicio));

        var tercerEjercicio = nuevoHashSet(segundoEjercicio.ToList());
        Debug.Log(string.Join(" ", tercerEjercicio));

        Stack<string> pila = new Stack<string>();
        pila.Push("primero");
        pila.Push("segundo");
        pila.Push("tercero");
        pila.Push("cuarto");
        pila.Push("quinto");
        Debug.Log(string.Join(" ", pila));
        var cuartoEjercicio = nuevaCola(pila);
        while (cuartoEjercicio.Count > 0)
        {
            Debug.Log(cuartoEjercicio.Dequeue());
        }



    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<int> ListaAleatoria(int tamaño, int inferior, int superior)
    {
        List<int> aleatorio = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            aleatorio.Add(Random.Range(inferior, superior));
        }
        return aleatorio;
    }


    public int[] arreglosEnteros(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 1; j < a.Length; j++)
            {
                if (a[i] < a[j])
                {
                    int b = a[i];
                    a[i] = a[j];
                    a[j] = b;
                }
            }
        }
        return a;
    }


    public HashSet<int> nuevoHashSet(List<int> a)
    {
        HashSet<int> nuevo = new HashSet<int>();
        foreach (var hash in a)
        {
            nuevo.Add(hash);
        }
        return nuevo;
    }


    public Queue<string> nuevaCola(Stack<string> a)
    {
        Queue<string> nueva = new Queue<string>();
        while (a.Count > 0)
        {
            nueva.Enqueue(a.Peek());
            a.Pop();
        }
        return nueva;
    }
}