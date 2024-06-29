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
        if (!int.TryParse(c.ToString(),out ValorEntero))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        Debug.Log(ValorEntero);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
