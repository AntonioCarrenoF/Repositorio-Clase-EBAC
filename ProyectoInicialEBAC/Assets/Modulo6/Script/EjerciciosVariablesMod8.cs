using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{

    int miInt = 0;
    float miFloat = 1;
    float a = 20;
    float b = 8;
    float c;
    int miInt2;
    int d = 1;
    int e = 10;
    int f;
    int limiteInferior = -5;
    int limiteSuperior = 5;


    // Start is called before the first frame update
    void Start()
    {
        c = a / b;
        c = (int)c;
        Debug.Log("El valor de la operacion es " + c);

        f = Random.Range(limiteInferior, limiteSuperior);
        string miString = (f <= 0) ? "Hola" : "EBAC";
        Debug.Log(miString);
        switch (miString)
        {
            case "Hola":
                Debug.Log("La palabra seleccionada es "+miString);
                GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case "EBAC":
                Debug.Log("La palabra seleccionada es "+miString);
                GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            default:
                Debug.LogError("Palabra no valida");
                break;
        }

        float precioFloat = 10.50f;
        string precioString = precioFloat.ToString("0.0000");
        Debug.Log("El precio es de $"+precioString);

        string miNombreCompleto = "Antonio Carreño Flores";
        string miNombre = miNombreCompleto.Substring(0, 7);
        Debug.Log(miNombre);
        string miApellidoPaterno = miNombreCompleto.Substring(8, 7);
        Debug.Log(miApellidoPaterno);
        string miApellidoMaterno = miNombreCompleto.Substring(16, 6);
        Debug.Log(miApellidoMaterno);
        string[] listamiNombreCompleto = miNombreCompleto.Split(' ');
        foreach (var nombre in listamiNombreCompleto)
        {
            Debug.Log(nombre);
        }

        string valor1 = "10000";
        int valor1Numerico;
        bool valor1TryParse = int.TryParse(valor1, out valor1Numerico);
        string valor2 = "200000";
        int valor2Numerico;
        bool valor2TryParse = int.TryParse(valor2, out valor2Numerico);
        int g = valor2Numerico / valor1Numerico;
        Debug.Log("el resultado de la operacion TryParse es "+g);

        string miOracion = "Hola Mundo, mi nombre es Antonio";
        string caracteresPares = " ";
        int longitud =miOracion.Length;
        for(int i=0; i<longitud;)
        {
            if (i % 2 == 0)
            {

            }
            else
            {
                caracteresPares += miOracion[i];
            }
            Debug.Log(caracteresPares);
        }


        string miFrase = "Oracion para EBAC";
        string miFraseCortada = miFrase.Substring(5, 12);
        Debug.Log(miFraseCortada);




    }

    // Update is called once per frame
    void Update()
    {
        miInt++;
        Debug.Log("el valor de miInt es " + miInt);
    }

    private void FixedUpdate()
    {
        miFloat *= 2;
        Debug.Log("el valor de miFloat es " + miFloat);

        miInt2= Random.Range(d, e);
        if (miInt2 % 2 == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Debug.Log("el numero " + miInt2 + " es par");
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            Debug.Log("el numero " + miInt2 + " es impar");
        }


    }
}
