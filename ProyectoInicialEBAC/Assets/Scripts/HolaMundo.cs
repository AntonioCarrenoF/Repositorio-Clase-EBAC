using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Algo paso");
        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola Desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola Desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola Desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Objeto Ha Sido Habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El Objeto Ha Sido Inhabilitado");
    }
}
