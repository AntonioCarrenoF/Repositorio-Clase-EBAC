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

    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 0;
    ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSinSigno = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
