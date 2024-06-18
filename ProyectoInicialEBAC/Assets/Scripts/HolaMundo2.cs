using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        Debug.Log("Hola Desde Void Start");
        Debug.LogWarning("Precaucion, Algo Salio Medianamente Mal");
        Debug.LogError("Error, Algo Salio Extremadamente Mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
