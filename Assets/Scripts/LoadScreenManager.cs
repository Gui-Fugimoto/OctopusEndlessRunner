using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScreenManager : MonoBehaviour
{
    public static LoadScreenManager Instance;
    [SerializeField] private GameObject _loaderCanvas;
    [SerializeField] private Image _progressBar;
    

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public async void LoadScene(string nomeCena)
    {
        var scene = SceneManager.LoadSceneAsync(nomeCena);
        scene.allowSceneActivation = false;

        _loaderCanvas.SetActive(true);
        do {
            await Task.Delay(100);

            _progressBar.fillAmount = scene.progress;
        } while (scene.progress > 0.9f);


        scene.allowSceneActivation = true;
        _loaderCanvas.SetActive(false);

    }

}
