using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escolhaDesafio : MonoBehaviour
{

    bool isVericarToque;

    bool isMissoesFinalizadas;

    public GameObject puzzle;

    private GamerManager _gamerManager;

    private bool isPainelDesafio;
   

    void Start()
    {
        puzzle.SetActive(false);

        _gamerManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

    }

    // Update is called once per frame
    void Update()
    {
        if (isVericarToque) {
            if (Input.GetButtonDown("Fire1")) {
                isMissoesFinalizadas = !isMissoesFinalizadas;
            }
        }

        if (isMissoesFinalizadas && isPainelDesafio == false) {
            puzzle.SetActive(true);
            isPainelDesafio = true;
            
        }else if(isMissoesFinalizadas == false && isPainelDesafio == true) {
            _gamerManager.painelDesafio.SetActive(false);
            puzzle.SetActive(true);
            isPainelDesafio = false;
        }
    }


    private void OnMouseEnter() {
        isVericarToque = true;
    }

    private void OnMouseExit() {
        isVericarToque = false;
    }
}
