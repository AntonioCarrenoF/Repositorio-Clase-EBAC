using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
