using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translacaoNova : MonoBehaviour
{
    public Transform pai;
    public float velocidadeTranslacao;

    private void Update()
    {
        transform.RotateAround(pai.position, transform.up, velocidadeTranslacao * Time.deltaTime);
    }


}
