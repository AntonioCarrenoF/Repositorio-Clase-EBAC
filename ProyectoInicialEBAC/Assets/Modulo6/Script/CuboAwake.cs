using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboAwake : MonoBehaviour
{

    public GameObject prefabCubo;

    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboAwake";
        tempGameObject.transform.position = Random.insideUnitSphere;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
