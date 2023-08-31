using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Groot() {
        SceneManager.LoadScene("Baby Groot");
    }

    public void Rocket() {
        SceneManager.LoadScene("Rocket Raccoon");
    }


    public void Quill() {
        SceneManager.LoadScene("Baby Groot Gigante");
    }
}
