using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{

    // ciclo for - sabemos cuantas veces vamos a repetir el ciclo - consta de 3 partes; 1 inicializador, 2 condición, 3 modificador.
    // ciclo while - no sabemos cuantas veces vamos a repetir el ciclo
    // ciclo do while - al menos una vez si se ejecutará
    // arreglos unidimensionales [1,2,3,4,5]
    // areglos multidimensionales [0,1,2][3,4,5][6,7,8]
    // arreglos jagged [0,1,2,3,4,5][6,7,8][9,10,11,12]
    // foreach


    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        int[] miArreglo = new int[5];
        miArreglo = new int[7]; //modificacion de memoria del arreglo anterior

        string[] diasSemana = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        diasSemana = new string[] { "jueves", "viernes", "sabado", "domingo", "lunes", "martes", "miercoles" }; //siempre que modifiques algo tienes que poner el new
        for (int i = 0; i < diasSemana.Length; i++)
        {
            miArreglo[i] = i + 1;
            Debug.Log(diasSemana[i]);
        }

        //for (int i = 10; i > 1; i--) ;
        //{
        //    Debug.Log(i);
        //}

            //bool mibooleano= false;
            //while (mibooleano)
            //{
            //    contador++;
            //    Debug.Log("hola");

            //}

            //do
            //{
            //    Debug.Log("hola desde do while");
            //} while (mibooleano);

    }

    // Update is called once per frame
    void Update()
    {
        //contador++;
        //Debug.Log(contador);

    }
}
