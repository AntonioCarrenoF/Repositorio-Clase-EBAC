using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorFixedUpdate2 : MonoBehaviour
{
    public ColorFixedUpdate Capsula;
    public ColorFixedUpdate1 Capsula1;
    public bool variable1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        variable1 = Capsula.variable1 && Capsula1.variable1;
        if (variable1 == true)
        {
            Color c = Color.white;
            GetComponent<MeshRenderer>().material.color = c;
            Debug.Log(variable1);
        }
        else
        {
            Color c = Color.black;
            GetComponent<MeshRenderer>().material.color = c;
            Debug.Log(variable1);
        }



        //Color c = new Color(Random.value, Random.value, Random.value);
        //GetComponent<MeshRenderer>().material.color = c;
    }
}
