using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour
{
    public GameObject Polvo;

    public GameObject InkShot;

    public GameObject objetoMunicao;

    public Button BotaoAtirar;

    public GameObject CanvasAtirar;
    //public float delay = 1f;

    public float Municao;
    public float MunicaoparaTexto;
    public float MaxMunicao = 10;

    public float MunicaoGasta = 1;

    public Text textoMunicao;

    public Image Tanquedetinta;


    // Start is called before the first frame update
    void Start()
    {
        BotaoAtirar.onClick = new Button.ButtonClickedEvent();
        BotaoAtirar.onClick.AddListener(() => atirar());

        Municao = MaxMunicao;


    }

    // Update is called once per frame
    void Update()
    {
        textoMunicao.text = MunicaoparaTexto.ToString();
        MunicaoparaTexto = Municao * 10;

        Tanquedetinta.fillAmount = Municao / 10f;


    }
    IEnumerator ParadeAtirar()
    {
        yield return new WaitForSeconds(1);
        CanvasAtirar.SetActive(true);
    }

    public void atirar()
    {
        if (Municao >= 1)
        {
            Debug.Log("atirou");
            Municao -= MunicaoGasta;
            Instantiate(InkShot, Polvo.transform.localPosition, Quaternion.Euler(transform.forward));
            CanvasAtirar.SetActive(false);
            StartCoroutine(ParadeAtirar());
        }
        if (Municao <= 1)
        {
            CanvasAtirar.SetActive(false);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Municao"))
        {
            Debug.Log("EncostouMunicao");
            Municao = MaxMunicao;
            CanvasAtirar.SetActive(true);
            Destroy(objetoMunicao);
        }

    }

}