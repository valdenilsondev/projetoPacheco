using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranlacao : MonoBehaviour
{

    public tranlacao objeto;
    public int velocidade;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(objeto.transform.position, objeto.transform.up, velocidade * Time.deltaTime);
    }
}
