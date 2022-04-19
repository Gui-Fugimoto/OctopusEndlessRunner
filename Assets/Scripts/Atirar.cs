using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atirar : MonoBehaviour
{
    public GameObject Polvo;

    public GameObject InkShot;
    public GameObject SuperInkShot;

    public GameObject objetoMunicao;

    public Button BotaoAtirar;

    public float TempoSuperTiro;

    public GameObject CanvasAtirar;
    //public float delay = 1f;

    public float Municao;
    public float MunicaoparaTexto;
    public float MaxMunicao = 10;

    public float MunicaoGasta = 1;

    public float TempoProximoInkshot;

    public Text textoMunicao;

    public Image Tanquedetinta;

    public static float deltaTime;
    public float timer = 0f;



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

        timer += Time.deltaTime;

    }
    IEnumerator ParadeAtirar()
    {
        yield return new WaitForSeconds(TempoProximoInkshot);
        CanvasAtirar.SetActive(true);
    }

    public void atirar()
    {
        if (Municao >= 1)
        {
            Debug.Log("atirou");
            Municao -= MunicaoGasta;
            Instantiate(InkShot, Polvo.transform.localPosition, Quaternion.Euler(transform.forward));
            timer = 0f;
            CanvasAtirar.SetActive(false);
            StartCoroutine(ParadeAtirar());
        }
        if (Municao >= 1 && timer > 3f) 
        {
            Instantiate(SuperInkShot, Polvo.transform.localPosition, Quaternion.Euler(transform.forward));
            Debug.Log("SuperTiro");
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