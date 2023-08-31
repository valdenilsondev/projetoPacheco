using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AssociarPalavras : MonoBehaviour
{

    public Button[] botao01;
    public Button[] botao02;
    public Button[] botao03;
    bool primeiraRespostaCorreta;
    bool segundaRespostaCorreta;
    bool terceiraRespostaCorreta;

    public GameObject painelCongratulations;
    public GameObject painelGameOver;
    public GameObject painelJogo;
    public GameObject painelTelaInicial;
    public GameObject painelInstrucoes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void primeiraImagemA() {
        botao01[1].interactable = false;
        botao01[2].interactable = false;
        botao01[0].image.color = Color.yellow;
        primeiraRespostaCorreta = true;
    }
    public void primeiraImagemB() {
        botao01[0].interactable = false;
        botao01[2].interactable = false;
        botao01[1].image.color = Color.yellow;
    }
    public void primeiraImagemC() {
        botao01[0].interactable = false;
        botao01[1].interactable = false;
        botao01[2].image.color = Color.yellow;
    }

    public void segundaImagemA() {
        botao02[1].interactable = false;
        botao02[2].interactable = false;
        botao02[0].image.color = Color.yellow;
    }
    public void segundaImagemB() {
        botao02[0].interactable = false;
        botao02[2].interactable = false;
        botao02[1].image.color = Color.yellow;
        segundaRespostaCorreta = true;
    }
    public void segundaImagemC() {
        botao02[0].interactable = false;
        botao02[1].interactable = false;
        botao02[2].image.color = Color.yellow;

    }


    public void terceiraImagemA() {
        botao03[1].interactable = false;
        botao03[2].interactable = false;
        botao03[0].image.color = Color.yellow;


    }
    public void terceiraImagemB() {
        botao03[0].interactable = false;
        botao03[2].interactable = false;
        botao03[1].image.color = Color.yellow;


    }
    public void terceiraImagemC() {
        botao03[0].interactable = false;
        botao03[1].interactable = false;
        botao03[2].image.color = Color.yellow;
        terceiraRespostaCorreta = true;
    }

    public void checarRespostaCorreta() {

        if(primeiraRespostaCorreta == true && segundaRespostaCorreta == true && terceiraRespostaCorreta == true) {
            painelCongratulations.SetActive(true);
        }
        else {
            painelGameOver.SetActive(true);
        }

    }

    public void iniciarJogo() {
        painelTelaInicial.SetActive(false);
    }

    public void abrirPainelInstrucoes() {
        painelInstrucoes.SetActive(true);
    }

    public void fecharPainelInstrucoes() {
        painelInstrucoes.SetActive(false);
    }

   

    public void fecharPainelTelaInicial() {
        painelTelaInicial.SetActive(false);
    }

    public void facharPainelCongratulation() {
        painelCongratulations.SetActive(false);
        for(int i = 0; i<3; i++) {
            botao01[i].interactable = true;
            botao02[i].interactable = true;
            botao03[i].interactable = true;
            botao01[i].image.color = Color.white;
            botao02[i].image.color = Color.white;
            botao03[i].image.color = Color.white;
        }
        primeiraRespostaCorreta = false;
        segundaRespostaCorreta = false;
        terceiraRespostaCorreta = false;
    }

    public void sairDesafio() {
        painelJogo.SetActive(false);
    }

    public void fecharPainelGameOver() {
        painelGameOver.SetActive(false);
    }

    public void restart() {
        for (int i = 0; i < 3; i++) {
            botao01[i].interactable = true;
            botao02[i].interactable = true;
            botao03[i].interactable = true;
            botao01[i].image.color = Color.white;
            botao02[i].image.color = Color.white;
            botao03[i].image.color = Color.white;

        }

        primeiraRespostaCorreta = false;
        segundaRespostaCorreta = false;
        terceiraRespostaCorreta = false;
    }
  

}


