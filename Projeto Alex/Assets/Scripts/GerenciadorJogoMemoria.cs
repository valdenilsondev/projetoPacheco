using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorJogoMemoria : MonoBehaviour {

    public GameObject painelInicial;

  
    public GameObject painelJogoMemoria;
    public GameObject painelInstrucoes;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void fecharPainelInicial() {
        painelInicial.SetActive(false);
        painelJogoMemoria.SetActive(true);
    }

    public void fecharPainelJogoMemoria() {
        painelInicial.SetActive(false);
        painelJogoMemoria.SetActive(false);
    }

    public void fecharPainelInstrucoes() {
        painelInstrucoes.SetActive(false);
    }

    public void abrirPainelInstrucoes() {
        painelInstrucoes.SetActive(true);
    }

    public void abrirPainelInicial() {
        painelInicial.SetActive(true);
    }

    public void abrirPainelJogomemoria() {
        painelJogoMemoria.SetActive(true);
    }

}
