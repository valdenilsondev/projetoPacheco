using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamerManager : MonoBehaviour {

    private GamerManager _gamerManager;
    private infoCadeado _infoCadeado;

    public Button[] botoesPerguntas;

    public int contButoesApertados;


    public int quantDesafios01;

    public GameObject painelAcerto;
    public GameObject painelErro;

    public GameObject painelPrincipal;

    public GameObject msnLimiteQuantRespostas;

    public int quantRespostas;

    public GameObject[] cadeados;

    public GameObject[] oleo;

    public GameObject painelDesafio;



    public GameObject missao;
    public GameObject missao1;
    public GameObject missao2;
    public GameObject missao3;
    public GameObject missao4;


    public GameObject[] ponteiro;




    public GameObject credtos;
    public GameObject instrucoes;

    public string nomeScena;


    private void Start() {

        painelAcerto.SetActive(false);
        painelErro.SetActive(false);
        msnLimiteQuantRespostas.SetActive(false);

        _gamerManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

        _infoCadeado = FindObjectOfType(typeof(infoCadeado)) as infoCadeado;

        _gamerManager.painelDesafio.SetActive(false);

        painelPrincipal.SetActive(false);

        missao1.SetActive(false);

        credtos.SetActive(false);
        instrucoes.SetActive(false);

       
    }



    private void Update() {
       
    }

    public void responta01() {

        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[0].interactable = false;
            contButoesApertados += 1;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }

    }
    public void responta02() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[1].interactable = false;
            contButoesApertados += 0;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }

    public void responta03() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[2].interactable = false;
            contButoesApertados += 1;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }

    public void responta04() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[3].interactable = false;
            contButoesApertados += 0;

        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }

    public void responta05() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[4].interactable = false;
        contButoesApertados += 1;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }

    }
    public void responta06() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[5].interactable = false;
        contButoesApertados += 0;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }
    public void responta07() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[6].interactable = false;
        contButoesApertados += 0;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }
    public void responta08() {
        quantRespostas += 1;
        if (quantRespostas < 5) {
            botoesPerguntas[7].interactable = false;
        contButoesApertados += 1;
        }
        else {
            msnLimiteQuantRespostas.SetActive(true);
        }
    }

    public void OK() {
        if (contButoesApertados == 4) {
            painelAcerto.SetActive(true);
            painelErro.SetActive(false);
            painelDesafio.SetActive(false);



        }
        else if (contButoesApertados != 4) {

            painelErro.SetActive(true);
            painelAcerto.SetActive(false);
            painelDesafio.SetActive(false);

        }
    }

    public void fecharPainelAcerto() {
        painelAcerto.SetActive(false);
    }

    public void fecarPainelErro() {
        painelErro.SetActive(false);
    }

    public void fecarPainelMsnQuantRespostas() {

        msnLimiteQuantRespostas.SetActive(false);
    
    }

    public void exitPainel() {
        painelPrincipal.SetActive(false);
        
        if (contButoesApertados == 4) {
            cadeados[0].SetActive(false);
            oleo[0].SetActive(false);
            _infoCadeado.ponteiroInformacao[0].SetActive(false);
            _infoCadeado.ponteiroInformacao[1].SetActive(false);
            _infoCadeado.ponteiroInformacao[2].SetActive(false);

            ponteiro[0].SetActive(false);
            ponteiro[1].SetActive(false);
            ponteiro[2].SetActive(false);

           missao.SetActive(false);

            missao1.SetActive(true);

            //painelDesafio.SetActive(false);
            
            quantDesafios01 = 0;

            contButoesApertados = 0;
            quantRespostas = 0;


        }


    }

    public void resetPainel() {

        botoesPerguntas[0].interactable = true;
        botoesPerguntas[1].interactable = true;
        botoesPerguntas[2].interactable = true;
        botoesPerguntas[3].interactable = true;
        botoesPerguntas[4].interactable = true;
        botoesPerguntas[5].interactable = true;
        botoesPerguntas[6].interactable = true;
        botoesPerguntas[7].interactable = true;
        contButoesApertados = 0;
        quantRespostas = 0;
        painelDesafio.SetActive(false);
       
       


    }


    public void ativarDesativasCreditos() {
       
            credtos.SetActive(true);
         
        
    }

    public void desativarCreditos()
    {
        credtos.SetActive(false);
    }


    public void fecharJogo()
    {
        Application.Quit();
    }

    public void instrucoesLigar() {
        instrucoes.SetActive(true);
    }

    public void fecharInstrucoes() {
        instrucoes.SetActive(false);
    }

    public void iniciarJogo(string nomeSsena) {

        nomeScena = nomeSsena;

        SceneManager.LoadScene(nomeScena);
    }

}
