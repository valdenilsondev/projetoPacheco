using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemId : MonoBehaviour {


    public int id;
    private Sprites _sprite;
    public bool isBotaoApertado;
    public Image imagem;
    public int i;
    public int j;
    public int k;
    public int cont;
    public int r;
    public int t;
    public int numero;

    public Image nome;

    public bool tocandoNovo;

   
    

    public bool isVerificarToque;

    public bool tocando;

    private void Start() {

   
        // nome.sprite = _sprite.palavra1[0];

        nome = GetComponent<Image>();

        numero = 10;

        _sprite = FindObjectOfType(typeof(Sprites)) as Sprites;


        for (i = 0; i < _sprite.imagens.Length; i++) {

            j = Random.Range(0, _sprite.totasSprites.Length);

            _sprite.imagens[i].sprite = _sprite.totasSprites[j];

        }


        for (i = 0; i < _sprite.imagens.Length; i++) {


            int k;
            int p;
            k = 0;
            r = 9;

            for (j = 0; j < _sprite.palavras.Length; j++) {

                k = j + 9;
                p = r + k;

                _sprite.imagens[p].sprite = _sprite.palavras[j];
            }

        }

        for (i = 0; i < _sprite.imagens.Length; i++) {


            for (j = 0; j < _sprite.palavra1.Length; j++) {

                _sprite.imagens[j].sprite = _sprite.palavra1[j];
            }

        }

        _sprite.imagens[17].sprite = _sprite.palavra2[0];
        _sprite.imagens[26].sprite = _sprite.palavra2[1];
        _sprite.imagens[35].sprite = _sprite.palavra2[2];
        _sprite.imagens[44].sprite = _sprite.palavra2[3];
        _sprite.imagens[53].sprite = _sprite.palavra2[4];
        _sprite.imagens[62].sprite = _sprite.palavra2[5];
        _sprite.imagens[71].sprite = _sprite.palavra2[6];
        _sprite.imagens[80].sprite = _sprite.palavra2[7];
        _sprite.imagens[89].sprite = _sprite.palavra2[8];
        _sprite.imagens[98].sprite = _sprite.palavra2[9];
        _sprite.imagens[107].sprite = _sprite.palavra2[10];
        _sprite.imagens[116].sprite = _sprite.palavra2[11];

        _sprite.imagens[27].sprite = _sprite.palavra3[0];
        _sprite.imagens[36].sprite = _sprite.palavra3[1];
        _sprite.imagens[45].sprite = _sprite.palavra3[2];
        _sprite.imagens[54].sprite = _sprite.palavra3[3];
        _sprite.imagens[63].sprite = _sprite.palavra3[4];
        _sprite.imagens[72].sprite = _sprite.palavra3[5];
        _sprite.imagens[81].sprite = _sprite.palavra3[6];
        _sprite.imagens[90].sprite = _sprite.palavra3[7];
        _sprite.imagens[99].sprite = _sprite.palavra3[8];


    }

    private void Update() {
      
        if (_sprite.nomeCompleto == "OLEO" && Sprites.IsAddChar == false) {
            _sprite.imagemOleo.color = Color.red;


        }else if(_sprite.nomeCompleto != "OLEO" && Sprites.IsAddChar == false) {

        }

        _sprite.idCont = id;

       
    }

    public void gerarAleatorio() {


        int k;
        int p;
        k = 0;

        if (r < 117) {

            r += 9;
            for (i = 0; i < _sprite.imagens.Length; i++) {

                j = Random.Range(0, _sprite.totasSprites.Length);

                _sprite.imagens[i].sprite = _sprite.totasSprites[j];

            }


            for (i = 0; i < _sprite.imagens.Length; i++) {


                for (j = 0; j < _sprite.palavras.Length; j++) {

                    k = j + 10;
                    p = r + k;

                    _sprite.imagens[p].sprite = _sprite.palavras[j];
                }
            }
        }
        else if (r >= 117) {
            r -= 108;

            for (i = 0; i < _sprite.imagens.Length; i++) {

                j = Random.Range(0, _sprite.totasSprites.Length);

                _sprite.imagens[i].sprite = _sprite.totasSprites[j];

            }


            for (i = 0; i < _sprite.imagens.Length; i++) {


                for (j = 0; j < _sprite.palavras.Length; j++) {

                    k = j + 9;
                    p = r + k;

                    _sprite.imagens[p].sprite = _sprite.palavras[j];
                }
            }

        }


        if (t < 40) {

            t += 10;
            for (i = 0; i < _sprite.imagens.Length; i++) {


                for (j = 0; j < _sprite.palavra1.Length; j++) {

                    _sprite.imagens[j + t].sprite = _sprite.palavra1[j];
                }

            }
        }
        else if (t >= 40) {

            t -= 30;

            for (i = 0; i < _sprite.imagens.Length; i++) {


                for (j = 0; j < _sprite.palavra1.Length; j++) {

                    _sprite.imagens[j + t].sprite = _sprite.palavra1[j];
                }

            }
        }


        _sprite.imagens[17].sprite = _sprite.palavra2[0];
        _sprite.imagens[26].sprite = _sprite.palavra2[1];
        _sprite.imagens[35].sprite = _sprite.palavra2[2];
        _sprite.imagens[44].sprite = _sprite.palavra2[3];
        _sprite.imagens[53].sprite = _sprite.palavra2[4];
        _sprite.imagens[62].sprite = _sprite.palavra2[5];
        _sprite.imagens[71].sprite = _sprite.palavra2[6];
        _sprite.imagens[80].sprite = _sprite.palavra2[7];
        _sprite.imagens[89].sprite = _sprite.palavra2[8];
        _sprite.imagens[98].sprite = _sprite.palavra2[9];
        _sprite.imagens[107].sprite = _sprite.palavra2[10];
        _sprite.imagens[116].sprite = _sprite.palavra2[11];

        _sprite.imagens[27].sprite = _sprite.palavra3[0];
        _sprite.imagens[36].sprite = _sprite.palavra3[1];
        _sprite.imagens[45].sprite = _sprite.palavra3[2];
        _sprite.imagens[54].sprite = _sprite.palavra3[3];
        _sprite.imagens[63].sprite = _sprite.palavra3[4];
        _sprite.imagens[72].sprite = _sprite.palavra3[5];
        _sprite.imagens[81].sprite = _sprite.palavra3[6];
        _sprite.imagens[90].sprite = _sprite.palavra3[7];
        _sprite.imagens[99].sprite = _sprite.palavra3[8];

        for (int i = 0; i < _sprite.imagens.Length; i++) {

            _sprite.imagens[i].color = Color.white;
        }

        _sprite.primeiraLetraPalavra01 = false;
        _sprite.segundaLetraPalavra01 = true;
        _sprite.terceiraLetraPalavra01 = true;
        _sprite.quartaLetraPalavra01 = true;

        _sprite.imagemOleo.color = Color.white;

        _sprite.imagemEsgoto.color = Color.white;

        _sprite.imagemObstrucao.color = Color.white;

        _sprite.ImageLitrosdeAgua.color = Color.white;

    }




    public void OnImagem() {

        // tocandoNovo = tocando;

        // imagem.color = Color.red;

        // _sprite.nomeCompleto += nome.sprite.name;

   

      
        if (Sprites.IsAddChar == true) {

           

            if (isVerificarToque == false) {



                _sprite.imagemLista.Add(_sprite.imagens[id]);
                imagem.color = Color.red;
              //  isVerificarToque = true;
               
                _sprite.nomeCompleto += nome.sprite.name;

                //  _sprite.letas.Add(_sprite.imagens[id].sprite);

                // _sprite.idImagem.Add(_sprite.idCont);

                print(id);

            }

        }


        //print(tocandoNovo);


        // print(nome.sprite.name);



    }

    public void onClickDown() {

       

        if (Sprites.IsAddChar == false) {

            _sprite.imagemLista.Add(_sprite.imagens[id]);
            //  _sprite.letas.Add(nome.sprite.name);
            imagem.color = Color.red;
            Sprites.IsAddChar = true;

            if (isVerificarToque == false) {
                


                isVerificarToque = true;
                _sprite.nomeCompleto += nome.sprite.name;

              //  _sprite.letas.Add(_sprite.imagens[id].sprite);

               
            }

        }


   
    }


    public void OnMouseUp() {

        Sprites.IsAddChar = false;

        isVerificarToque = false;


        // id = 0;

        if (_sprite.nomeCompleto == "OLEO" && Sprites.IsAddChar == false) {

            _sprite.imagemOleo.color = Color.red;


            _sprite.imagemLista.RemoveRange(0, _sprite.imagemLista.Count);


            //  _sprite.imagemLista.RemoveRange(id, 4);

            _sprite.nomeCompleto = "";

            _sprite.primeiraPalavraCerta = true;



        }
        else if (_sprite.nomeCompleto == "ESGOTO" && Sprites.IsAddChar == false) {



            _sprite.imagemEsgoto.color = Color.red;



            _sprite.imagemLista.RemoveRange(0, _sprite.imagemLista.Count);

            _sprite.nomeCompleto = "";


            _sprite.segundaPalavraCerta = true;
        }
        else if (_sprite.nomeCompleto == "OBSTRUCAO" && Sprites.IsAddChar == false) {

            _sprite.imagemObstrucao.color = Color.red;



            _sprite.imagemLista.RemoveRange(0, _sprite.imagemLista.Count);

            _sprite.nomeCompleto = "";


            _sprite.terceiraPalavraCerta = true;

        }
        else if (_sprite.nomeCompleto == "LITROSDEAGUA" && Sprites.IsAddChar == false) {

            _sprite.ImageLitrosdeAgua.color = Color.red;



            _sprite.imagemLista.RemoveRange(0, _sprite.imagemLista.Count);

            _sprite.nomeCompleto = "";

            _sprite.quartaPalavraCerta = true;
        }
        else if (_sprite.nomeCompleto != "LITROSDEAGUA" || _sprite.nomeCompleto != "OBSTRUCAO" || _sprite.nomeCompleto != "OLEO" || _sprite.nomeCompleto == "ESGOTO" && Sprites.IsAddChar == false) {


            for (int i = 0; i < _sprite.imagemLista.Count; i++) {

                _sprite.imagemLista[i].color = Color.white;

            }
            _sprite.imagemLista.RemoveRange(0, _sprite.imagemLista.Count);

            //  _sprite.letas.Clear();

            //  _sprite.imagemLista.Clear();
            // _sprite.idImagem.Clear();

            _sprite.nomeCompleto = "";
        }  
      
    }
}









