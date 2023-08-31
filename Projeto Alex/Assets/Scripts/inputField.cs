using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class inputField : MonoBehaviour
{
   
    public TMP_InputField[] _inputField;
    public int identificadorId;
    public string palavraCompleta;
    public bool isVerificar;
    public List<int> idAtual;
    public List<string> nomeCompleto;
    public string letra;

    public GameObject painelJogo;
    public GameObject painelGameOver;
    public GameObject painelTelaInicialJogo;
    public GameObject painelCongratulations;
    public GameObject painelInstrucoes;


    public int tempoInicial;
    public int tempoAtual;
    public float segundos;
    public int Minutos;
    public int resto;
    public float descrescimoSegundo;
    public int segundosAtualizados;
    public TextMeshProUGUI txtMinutos;
    public TextMeshProUGUI txtSegundos;
    bool tempo;
    public int tempoNovo;
    public float decrescimotempoMinutos;
    public float descrecimoMinutos;

    public bool iniciarCacaPalavra;

    private infoCadeado _infoCadeado;

    private GamerManager _GameManager;


    private bool teste;
    private void Start() {
        _infoCadeado = FindObjectOfType(typeof(infoCadeado)) as infoCadeado;

        _GameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

    }

    private void Update()
    {
        letra = _inputField[identificadorId].text;


      


        if (iniciarCacaPalavra == true) {


            descrescimoSegundo += Time.deltaTime;

            descrecimoMinutos += Time.deltaTime;

            if (decrescimotempoMinutos > 0) {

                if (tempoAtual > 60 && tempo == false) {

                    resto = tempoAtual % 60;

                    Minutos = (int)(tempoAtual - resto) / 60;

                    segundos = (int)resto;

                    txtMinutos.text = Minutos.ToString();

                    txtSegundos.text = segundos.ToString();

                    tempo = true;
                }

                segundosAtualizados = (int)segundos - (int)descrescimoSegundo;

                if (segundosAtualizados <= 0) {

                    Minutos--;
                    segundos = 60;

                    descrescimoSegundo = 0;

                }

                else

                if (segundos < 0 && Minutos < 0) {

                    Minutos = 0;

                    segundos = 0;
                }

                txtSegundos.text = segundosAtualizados.ToString("00");

                txtMinutos.text = Minutos.ToString("0");

            }
            else if (decrescimotempoMinutos < 0 ) {

                Minutos = 0;

                segundos = 0;

                decrescimotempoMinutos = 0;

                txtSegundos.text = segundosAtualizados.ToString("00");

                txtMinutos.text = Minutos.ToString("0");

                painelGameOver.SetActive(true);

                iniciarCacaPalavra = false;

                

            }

            decrescimotempoMinutos = tempoAtual - descrecimoMinutos;

        }
    }



    public void inserir(string letra)
    {
       _inputField[identificadorId].text = letra;

       
    }

    public void identificador(int id)
    {
        identificadorId = id;
    }

    public void Checar()
    {

        if (_inputField[26].text == "R")
        {
         
            _inputField[26].text = "R";
            _inputField[26].image.color = Color.green;
  
        }else if (_inputField[26].text != "R")
        {
           // _inputField[26].text = "R";
            _inputField[26].image.color = Color.red;
        }

        if (_inputField[0].text == "G")
        {
            _inputField[0].image.color  = Color.green;
            _inputField[0].text = "G";
        }
        else if (_inputField[0].text != "G")
        {
           // _inputField[0].text = " ";
            _inputField[0].image.color = Color.red;
        }

        if (_inputField[1].text == "A")
        {
            _inputField[1].image.color = Color.green;
            _inputField[1].text = "A";

        }
        else if (_inputField[1].text != "A")
        {
          //  _inputField[1].text = " ";
            _inputField[1].image.color = Color.red;
        }

        if (_inputField[2].text == "S")
        {
            _inputField[2].text = "S";
            _inputField[2].image.color = Color.green;
     

        }
        else if (_inputField[2].text != "S")
        {
           // _inputField[2].text = " ";
            _inputField[2].image.color = Color.red;
        }

        if (_inputField[3].text == "M")
        {
            _inputField[3].image.color = Color.green;
            _inputField[3].text = "M";

        }
        else if (_inputField[3].text != "M")
        {
           // _inputField[3].text = " ";
            _inputField[3].image.color = Color.red;
        }

        if (_inputField[4].text == "E")
        {
            _inputField[4].image.color = Color.green;
            _inputField[4].text = "E";

        }
        else if (_inputField[4].text != "E")
        {
           // _inputField[4].text = " ";
            _inputField[4].image.color = Color.red;
        }


        if (_inputField[5].text == "T")
        {
            _inputField[5].image.color = Color.green;
            _inputField[5].text = "T";

        }
        else if (_inputField[5].text != "T")
        {
           // _inputField[5].text = " ";
            _inputField[5].image.color = Color.red;
        }


        if (_inputField[6].text == "A")
        {
            _inputField[6].image.color = Color.green;
            _inputField[6].text = "A";

        }
        else if (_inputField[6].text != "A")
        {
         //   _inputField[6].text = " ";
            _inputField[6].image.color = Color.red;
        }

        if (_inputField[7].text == "N")
        {
            _inputField[7].image.color = Color.green;
            _inputField[7].text = "N";

        }
        else if (_inputField[7].text != "N")
        {
         //   _inputField[7].text = " ";
            _inputField[7].image.color = Color.red;
        }

        if (_inputField[8].text == "O")
        {
            _inputField[8].image.color = Color.green;
            _inputField[8].text = "O";

        }
        else if (_inputField[8].text != "O")
        {
           // _inputField[8].text = " ";
            _inputField[8].image.color = Color.red;
        }



        if (_inputField[22].text == "L")
        {
            _inputField[22].image.color = Color.green;
            _inputField[22].text = "L";

        }
        else if (_inputField[22].text != "L")
        {
          //  _inputField[22].text = " ";
            _inputField[22].image.color = Color.red;
        }


        if (_inputField[21].text == "U")
        {
            _inputField[21].image.color = Color.green;
            _inputField[21].text = "U";

        }
        else if (_inputField[21].text != "U")
        {
           // _inputField[21].text = " ";
            _inputField[21].image.color = Color.red;
       }


        if (_inputField[20].text == "Z")
        {
            _inputField[20].image.color = Color.green;
            _inputField[20].text = "Z";

        }
        else if (_inputField[20].text != "Z")
        {
          //  _inputField[20].text = " ";
            _inputField[20].image.color = Color.red;
        }

        if (_inputField[2].text == "S")
        {
            _inputField[2].image.color = Color.green;
            _inputField[2].text = "S";

        }
        else if (_inputField[2].text != "S")
        {
           // _inputField[2].text = " ";
            _inputField[2].image.color = Color.red;
        }

        if (_inputField[23].text == "O")
        {
            _inputField[23].image.color = Color.green;
            _inputField[23].text = "O";

        }
        else if (_inputField[23].text != "O")
        {
          //  _inputField[23].text = " ";
            _inputField[23].image.color = Color.red;
        }


        if (_inputField[24].text == "L")
        {
            _inputField[24].image.color = Color.green;
            _inputField[24].text = "L";

        }
        else if (_inputField[24].text != "L")
        {
          //  _inputField[24].text = " ";
            _inputField[24].image.color = Color.red;
        }

        if (_inputField[25].text == "A")
        {
            _inputField[25].image.color = Color.green;
            _inputField[25].text = "A";

        }
        else if (_inputField[25].text != "A")
        {
           // _inputField[25].text = " ";
            _inputField[25].image.color = Color.red;
        }

       

        if (_inputField[18].text == "I")
        {
            _inputField[18].image.color = Color.green;
            _inputField[18].text = "I";

        }
        else if (_inputField[18].text != "I")
        {
           // _inputField[18].text = " ";
            _inputField[18].image.color = Color.red;
        }


        if (_inputField[17].text == "N") {
            _inputField[17].image.color = Color.green;
            _inputField[17].text = "N";

        }
        else if (_inputField[17].text != "N") {
            // _inputField[18].text = " ";
            _inputField[17].image.color = Color.red;
        }

        if (_inputField[16].text == "S") {
            _inputField[16].image.color = Color.green;
            _inputField[16].text = "S";

        }
        else if (_inputField[16].text != "S") {
            // _inputField[18].text = " ";
            _inputField[16].image.color = Color.red;
        }

        if (_inputField[15].text == "E") {
            _inputField[15].image.color = Color.green;
            _inputField[15].text = "E";

        }
        else if (_inputField[15].text != "E") {
            // _inputField[18].text = " ";
            _inputField[15].image.color = Color.red;
        }

        if (_inputField[14].text == "T") {
            _inputField[14].image.color = Color.green;
            _inputField[14].text = "T";

        }
        else if (_inputField[14].text != "T") {
            // _inputField[18].text = " ";
            _inputField[14].image.color = Color.red;
        }

        if (_inputField[13].text == "O") {
            _inputField[13].image.color = Color.green;
            _inputField[13].text = "O";

        }
        else if (_inputField[13].text != "O") {
            // _inputField[18].text = " ";
            _inputField[13].image.color = Color.red;
        }


        if (_inputField[12].text == "S") {
            _inputField[12].image.color = Color.green;
            _inputField[12].text = "S";

        }
        else if (_inputField[12].text != "S") {
            // _inputField[18].text = " ";
            _inputField[12].image.color = Color.red;
        }

        if (_inputField[11].text == "E") {
            _inputField[11].image.color = Color.green;
            _inputField[11].text = "E";

        }
        else if (_inputField[11].text != "E") {
            // _inputField[18].text = " ";
            _inputField[11].image.color = Color.red;
        }

        if (_inputField[10].text == "R") {
            _inputField[10].image.color = Color.green;
            _inputField[10].text = "R";

        }
        else if (_inputField[10].text != "R") {
            // _inputField[18].text = " ";
            _inputField[10].image.color = Color.red;
        }

        if (_inputField[9].text == "A") {
            _inputField[9].image.color = Color.green;
            _inputField[9].text = "A";

        }
        else if (_inputField[9].text != "A") {
            // _inputField[18].text = " ";
            _inputField[9].image.color = Color.red;
        }


        if (_inputField[19].text == "O") {
            _inputField[19].image.color = Color.green;
            _inputField[19].text = "O";

        }
        else if (_inputField[19].text != "O") {
            // _inputField[18].text = " ";
            _inputField[19].image.color = Color.red;
        }



    }

    public void fecharPainelJogo() {
        painelJogo.SetActive(false);

        _infoCadeado.ponteiroInformacao[0].SetActive(false);
        _infoCadeado.ponteiroInformacao[1].SetActive(false);
        _infoCadeado.ponteiroInformacao[2].SetActive(false);

        _GameManager.ponteiro[6].SetActive(false);
        _GameManager.ponteiro[7].SetActive(false);
        _GameManager.ponteiro[8].SetActive(false);



        _GameManager.missao.SetActive(false);


        _GameManager.missao1.SetActive(false);


        _GameManager.missao2.SetActive(false);


        _GameManager.missao3.SetActive(true);


        _GameManager.quantDesafios01 = 0;
        _GameManager.contButoesApertados = 0;
        _GameManager.quantRespostas = 0;


    }

    public void fecharPainelCongratulations() {
        painelTelaInicialJogo.SetActive(false);
    }


    public void fecharPainelGameOver() {

        iniciarCacaPalavra = true;
        painelGameOver.SetActive(false);
        tempo = false;
        tempoAtual = 130;
       
        descrescimoSegundo = 0;

        descrecimoMinutos = 0;



        

    }

    public void iniciarJogo() {

        painelTelaInicialJogo.SetActive(false);

        iniciarCacaPalavra = true;

    }

    public void iniciarInstrucoes() {
        painelInstrucoes.SetActive(true);
    }

    public void fecharPainelInstrucoes() {
        painelInstrucoes.SetActive(false);
    }
 



}
