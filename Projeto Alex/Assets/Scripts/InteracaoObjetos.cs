using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracaoObjetos : MonoBehaviour
{

    private GamerManager _gameManager;

    private infoCadeado _infoCadeado;


    public GameObject[] painelInfo;

    bool isVerificarToque;
    bool isPainel;
    bool isPrimeirDesafio;

    public bool isInfoAberto;







    // Start is called before the first frame update
    void Start()
    {
        painelInfo[0].SetActive(false);

        _gameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

        _infoCadeado = FindObjectOfType(typeof(infoCadeado)) as infoCadeado;

        isInfoAberto = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isVerificarToque)
        {
            if (Input.GetButtonDown("Fire1") && _infoCadeado.isLerInformacao)
            {
                isPainel = !isPainel;

             
            }



        }

        if (isPainel && isPrimeirDesafio == false && _infoCadeado.isLerInformacao)
        {
            _gameManager.quantDesafios01 += 1;
            painelInfo[0].SetActive(true);
            isPrimeirDesafio = true;
            isInfoAberto = true;

        }

        if (isPainel && _infoCadeado.isLerInformacao)
        {

            painelInfo[0].SetActive(true);
            isInfoAberto = false ;

        }
        else if (isPainel == false)
        {
            painelInfo[0].SetActive(false);
            isInfoAberto =true;

        }


    }

    private void OnMouseDown()
    {
        isVerificarToque = true;
    }

    private void OnMouseExit()
    {
        isVerificarToque = false;
    }
}
