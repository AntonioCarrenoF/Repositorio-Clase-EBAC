using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboOnDisableEnable : MonoBehaviour
{

    public GameObject prefabCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboOnEnable";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }

    private void OnDisable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboOnDisable";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }
}
