using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteinferior = -5;
    int limitesuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris,
    }

    // ABC  OR AND ((A or B) and C) ((A or B) or C)
    // 111  1   1          1                1
    // 110  1   0          0                1
    // 101  1   0          1                1
    // 100  0   0          0                1
    // 011  1   0          1                1
    // 010  1   0          0                1
    // 001  0   0          0                1
    // 000  0   0          0                0

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es verdadero");
        }
        if ((variable1 || variable2) || variable3)
        {
            if (variable1)
            {
                Debug.Log("la variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadero");
        }
        if((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es verdadera");
        }
        valor1 = Random.Range(limiteinferior, limitesuperior);
        Debug.Log(valor1);
        //if(valor1<=0)
        //{
        //    Debug.Log("El valor es negativo");
        //}
        //else
        //{
        //    Debug.Log("El valor es positivo");
        //}
        string resultado = (valor1 <= 0) ? "El valor es negativo" : "El valor es positivo";
        Debug.Log(resultado);
        //switch (valor1)
        //{
        //    case (int)SeleccionColor.rojo:
        //        Debug.Log("El color seleccionado es el rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("El color seleccionado es el verde");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("El color seleccionado es el blanco");
        //        break;
        //    case (int)SeleccionColor.azul:
        //        Debug.Log("El color seleccionado es el azul");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("El color seleccionado es el gris");
        //        break;
        //    default:
        //        Debug.Log("Ese no es un color valido");
        //        break;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
