using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoCadeado : MonoBehaviour
{
    private GamerManager _gameManager;
    private InteracaoObjetos _interacaoObjetos;

    public GameObject[] ponteiroInformacao;
    public GameObject[] infoCadeadoPainelMissoes;
    public GameObject[] infoCadeadoMissoesIncompletas;
   

    public GameObject[] informacao;


    public   bool verificarInformacaoAberto;
    public   bool verificarInformacaoFechada;
    public   bool isMensagemInformacao;
    public  bool isCadeadoInfo;

    public bool isLerInformacao;

    public GameObject painelDesafio;

    void Start()
    {
        foreach (GameObject objetos in ponteiroInformacao)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in infoCadeadoMissoesIncompletas)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in infoCadeadoPainelMissoes)
        {
            objetos.SetActive(false);
        }

        foreach (GameObject objetos in informacao)
        {
            objetos.SetActive(false);
        }

       

        _gameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

        _interacaoObjetos = FindObjectOfType(typeof(InteracaoObjetos)) as InteracaoObjetos;

        isLerInformacao = false;

        _gameManager.painelDesafio.SetActive(false);

        painelDesafio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCadeadoInfo)
        {
            if (Input.GetButtonDown("Fire1") && _interacaoObjetos.isInfoAberto == true)
            {
                isMensagemInformacao = !isMensagemInformacao;
            }

        }

        if (isMensagemInformacao && verificarInformacaoAberto == false)
        {
            infoCadeadoPainelMissoes[0].SetActive(true);

            verificarInformacaoAberto = true;

            verificarInformacaoFechada = true;

            isLerInformacao = false;

        }
        else if (isMensagemInformacao == false && verificarInformacaoFechada == true)
        {
            isLerInformacao = true;

            infoCadeadoPainelMissoes[0].SetActive(false);

            for (int i = 0; i <= 2; i++)
            {
                ponteiroInformacao[i].SetActive(true);
            }


            verificarInformacaoFechada = true;
        }
        if (isMensagemInformacao && _gameManager.quantDesafios01 < 2 && verificarInformacaoAberto == true)
        {
            infoCadeadoMissoesIncompletas[0].SetActive(true);
            isLerInformacao = false;

        }

        else if (isMensagemInformacao == false && _gameManager.quantDesafios01 < 2)
        {
            infoCadeadoMissoesIncompletas[0].SetActive(false);

            isLerInformacao = true;

        }

        if (isMensagemInformacao && _gameManager.quantDesafios01 == 3) {

            // _gameManager.painelDesafio.SetActive(true);
            painelDesafio.SetActive(true);
        }
        else if (isMensagemInformacao==false && _gameManager.quantDesafios01 == 3) {

            //_gameManager.painelDesafio.SetActive(false);
            painelDesafio.SetActive(false);
        }





    }
    private void OnMouseDown()
    {
        isCadeadoInfo = true;
    }

    private void OnMouseExit()
    {
        isCadeadoInfo = false;
    }


    public void missao() {
        
    }

}
