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
            //Debug.Log(diasSemana[i]);
        }

        //int[,] miMatriz = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; //arreglo multidimensional
        //for (int j=0; j<miMatriz.GetLength(0); j++)
        //{
        //    for (int k=0;k<miMatriz.GetLength(1); k++)
        //    {
        //        Debug.Log(miMatriz[j, k]);
        //    }
        //}


        //int[][] miArregloJagged = new int[][] //arreglo jagged
        //{
        //    new int[]{1,2,3},
        //    new int[]{4,5},
        //    new int[]{6,7,8,9},
        //};
        //miArregloJagged[1] = new int[] {10, 11, 12, 13 };  //modificacion a arreglo anterior de 4,5
        //Debug.Log(miArregloJagged[0][1]);
        //for(int x=0; x<miArregloJagged.Length; x++)
        //{
        //    for (int y = 0; y < miArregloJagged[x].Length; y++)
        //    {
        //        Debug.Log(miArregloJagged[x][y]);
        //    }
        //}

        foreach (int i in miArreglo)  //foreach se recomienda unicamente para lectura y consultar, ya que no permite modificar valores
        {
            Debug.Log(i);
        }

        foreach(string dias in diasSemana)
        {
            Debug.Log(dias);
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
