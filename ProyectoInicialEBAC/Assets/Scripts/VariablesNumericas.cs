using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    //   128   64   32   16    8   4   2  1
    //Byte => [0 0 0 0 0 0 0 0]

    //Short => [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Int => [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //Long => [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    //Float => [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //double => [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    LayerMask myLayerMask=1>>9;//quiere decir que se mueve 9 posiciones a la derecha en los int, en nuestro ejemplo es la layer de geometrias
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongSinSigno = 0;


    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("el valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("el valor de miByte es :" + miInt);
        miByte = 200;
        miIntSinSigno = (uint)miByteConSigno;
        Debug.Log("el valor de miIntSinSigno es " + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es " + miInt);


        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);//0.5 al ser enteros, el decimal se trunca es los int

        miInt = Random.Range(a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero " + miInt +" es par");
        }
        else
        {
            Debug.Log("el numero " + miInt + " es non");
        }

    }

    // Update is called once per frame
    void Update()
    {
        //miLong /= 2;
        //miLong = miLong / 2; escribir esto es igual a la operacion linea arriba
        //Debug.Log(miLong);

    }
}
