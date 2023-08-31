using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacaoNova : MonoBehaviour
{
    public float velocidadeRotacao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, velocidadeRotacao * Time.deltaTime, 0);
    }
}
