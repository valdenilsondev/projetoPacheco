using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sprites : MonoBehaviour {
    private ItemId _item;
    public Sprite[] totasSprites;
    public Image[] imagens;
    public Sprite[] palavras;

    public Sprite[] palavra1;

    public Sprite[] palavra2;
    public Sprite[] palavra3;
    public int i, j, k;

    public GameObject nome;

    public bool primeiraLetraPalavra01;
    public bool segundaLetraPalavra01;
    public bool terceiraLetraPalavra01;
    public bool quartaLetraPalavra01;

    public Image imagemOleo;

    public Image imagemEsgoto;

    public Image imagemObstrucao;

    public Image ImageLitrosdeAgua;

    public string nomeCompleto;

    public static bool IsAddChar = false;

    public List<Sprite> letas;

    public List<Image> imagemLista;

    public List<Image> imagemListaOleo;



    public List<int> idImagem;




    public int idCont;


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

    public bool primeiraPalavraCerta;
    public bool segundaPalavraCerta;
    public bool terceiraPalavraCerta;
    public bool quartaPalavraCerta;

    public bool iniciar;

    public GameObject painelIniciarCacaPalavras;

    public GameObject painelPulzzeCacaPalavras;

    public GameObject painelIntrucoes;

    public GameObject painelPulzze;

    public GameObject gamerOver;

    public GameObject painelCongratulations;

    public bool fecharPainel;

    private infoCadeado _infoCadeado;

    private GamerManager _GameManager;

    public GameObject[] cadeados;

    public GameObject[] oleo;

    public GameObject painelDesafio;



  


    // Start is called before the first frame update
    void Start() {
        _item = FindObjectOfType(typeof(ItemId)) as ItemId;

        _infoCadeado = FindObjectOfType(typeof(infoCadeado)) as infoCadeado;

        _GameManager = FindObjectOfType(typeof(GamerManager)) as GamerManager;

        tempoNovo = tempoAtual;

    }

    // Update is called once per frame
    void Update() {
        i = _item.i;
        j = _item.j;
        k = _item.k;

        if (primeiraPalavraCerta == true && segundaPalavraCerta == true && terceiraPalavraCerta == true && quartaPalavraCerta == true) {

            painelCongratulations.SetActive(true);

            iniciar = false;

            primeiraPalavraCerta = false;

            segundaPalavraCerta = false;

            terceiraPalavraCerta = false;

            quartaPalavraCerta = false;

        }

        if (iniciar == true) {

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
            else if (decrescimotempoMinutos < 0) {

                Minutos = 0;

                segundos = 0;

                decrescimotempoMinutos = 0;

                txtSegundos.text = segundosAtualizados.ToString("00");

                txtMinutos.text = Minutos.ToString("0");

                gamerOver.SetActive(true);

                iniciar = false;

            }

            decrescimotempoMinutos = tempoAtual - descrecimoMinutos;

        }

        if (fecharPainel == true) {

            painelCongratulations.SetActive(false);

            fecharPainel = false;

        }
    }

    public void iniciarJogo() {

        painelIniciarCacaPalavras.SetActive(false);

        iniciar = true;

    }

    public void sairCacaPalavras() {

        painelPulzzeCacaPalavras.SetActive(false);

    }

    public void sairPainelInstrucoes() {

        painelIntrucoes.SetActive(false);

    }

    public void abrirInstrucoes() {

        painelIntrucoes.SetActive(true);

    }

    public void retornarCleanCity() {

        painelPulzze.SetActive(false);
        
        _infoCadeado.ponteiroInformacao[0].SetActive(false);
        _infoCadeado.ponteiroInformacao[1].SetActive(false);
        _infoCadeado.ponteiroInformacao[2].SetActive(false);

        _GameManager.ponteiro[3].SetActive(false);
        _GameManager.ponteiro[4].SetActive(false);
        _GameManager.ponteiro[5].SetActive(false);



        _GameManager.missao.SetActive(false);

        _GameManager.missao1.SetActive(false);

        _GameManager.missao2.SetActive(true);

        _GameManager.quantDesafios01 = 0;
        _GameManager.contButoesApertados = 0;
        _GameManager.quantRespostas = 0;


    }

    public void jogarNovamente() {

        iniciar = true;

        tempoAtual = 130;

        _item.gerarAleatorio();

        tempo = false;

        descrescimoSegundo = 0;

        descrecimoMinutos = 0;

        gamerOver.SetActive(false);
    }

    public void jogarNovamenteCongratulations() {

        iniciar = true;

        tempoAtual = 130;

        _item.gerarAleatorio();

        tempo = false;

        fecharPainel = true;

        descrescimoSegundo = 0;

        descrecimoMinutos = 0;

        painelCongratulations.SetActive(false);
    }


}
