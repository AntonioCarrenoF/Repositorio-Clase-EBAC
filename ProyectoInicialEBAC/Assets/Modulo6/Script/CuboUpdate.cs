using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboUpdate : MonoBehaviour
{

    public GameObject prefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboUpdate";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
