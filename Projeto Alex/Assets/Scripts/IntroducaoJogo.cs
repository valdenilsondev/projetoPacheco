using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroducaoJogo : MonoBehaviour
{

    public GameObject[] passarDireita;
    public GameObject[] passarEsquerda;
    public int acrescimo;

    public GameObject painelInstrucoes;
    public GameObject painelCreditos;

    public string nomeScene;
    // Start is called before the first frame update
    void Start()
    {
        acrescimo = 0;
        passarDireita[acrescimo].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void passarDireitaImagem() {

        acrescimo += 1;
        if(acrescimo >= passarDireita.Length) {
            acrescimo = 5;
        }
        passarDireita[acrescimo].SetActive(true);


    }

    public void passarEsquerdoImagem() {

        passarDireita[acrescimo].SetActive(false);
        acrescimo -= 1;
        if (acrescimo < 1) {
            acrescimo = 1;
        }
     




    }

    public void painelInstrucoesFechar() {
        painelInstrucoes.SetActive(false);
    }

    public void painelInstrucsoAbrir() {
        painelInstrucoes.SetActive(true);
    }

    public void painelCreditosAbrir() {
        painelCreditos.SetActive(true);
    }
    public void painelCreditosFechar() {
        painelCreditos.SetActive(false);
    }

    public void iniciarJogos(string nomeCene) {

        nomeScene = nomeCene;
        SceneManager.LoadScene(nomeScene);
    }

    public void sairJogo() {
        Application.Quit();
    }
}
