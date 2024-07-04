using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosDeCiclosYArreglos : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo1 = new int[5];
        for (int i=0; i<miArreglo1.Length; i++)
        {
            miArreglo1[i] = Random.Range(1, 5);
            Debug.Log(miArreglo1[i]);
        }
        int[] miArreglo2 = new int[5];
        for (int i=0; i<miArreglo2.Length; i++)
        {
            miArreglo2[i] = Random.Range(1,5);
            Debug.Log(miArreglo2[i]);
        }
        int[] miArreglo3 = new int[5];
        for (int i = 0; i < miArreglo3.Length; i++)
        {
            miArreglo3[i] = miArreglo1[i] + miArreglo2[i];
            Debug.Log($"La suma de {miArreglo1[i]}+ {miArreglo2[i]} es igual a {miArreglo3[i]}");
        }


        string[] miOracion = new string[5] { "Hola", "mi", "nombre", "es", "Antonio" };
        string enunciado = string.Empty;
        foreach(string palabra in miOracion)
        {
            enunciado += palabra + " ";
            Debug.Log(enunciado);
        }

        //pendiente realizar el ejercicio 3


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
