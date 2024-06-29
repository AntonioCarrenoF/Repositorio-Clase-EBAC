using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = 'k';
        int ValorEntero = 0;
        if (!int.TryParse(c.ToString(), out ValorEntero))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        Debug.Log(ValorEntero);

        char MiCaracter;
        string MiString = "Hola desde EBAC";
        string MiSegundoString = MiString.ToUpper();
        string MiTercerString = MiString + " " + MiSegundoString;
        string ejemploEscape = "c:\\user\nAntonio\\Documentos";
        MiCaracter = MiString[13];
        string miNombre = "Antonio";
        string misApellidos = "Carreño Flores";
        string miPrimerApellido = misApellidos.Substring(0, 7);
        string salidaSuma = "Mi nombre es " + miNombre + " y mis apellidos son " + misApellidos;
        string salida = $"Mi nombre es {miNombre} y mis apellidos son {misApellidos}";
        int Longitud = MiString.Length;
        Debug.Log(salida);
        Debug.Log(miPrimerApellido);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
