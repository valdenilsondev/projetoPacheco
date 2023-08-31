using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fecharCena : MonoBehaviour
{
    public void CasaCoberta()
    {
        SceneManager.LoadScene("ArqCasaExterno");
    }
    
    public void CasaDescoberta()
    {
        SceneManager.LoadScene("ArqCasaInterno");
    }


    public void pacheco01()
    {
        SceneManager.LoadScene("Pacheco01");
    }

    public void pacheco02()
    {
        SceneManager.LoadScene("Pacheco02");
    }

    public void SairAplicativo()
    {
        Application.Quit();
    }
}
