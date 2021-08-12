using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.TestTools;
using TMPro;

public class Guziki : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Slider slider;
    public TextMeshProUGUI ProgressText;
    public Text text;
    public Text imie;
    public string imieSaveString = "PlayerName";
    public string[] g = new string[3];
    int j = 0;

    #region Przycisk Start
    public void StartGry(int index)
    {
        string name = imie.text;
        if (name == "" || name == null || name == " ")
        {
            name = "Player";
        }
        PlayerPrefs.SetString(imieSaveString, name);
        StartCoroutine(Loading(index));
    }
    IEnumerator Loading(int SceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(SceneIndex);
        LoadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;

            text.text = g[j];
            if (j != g.Length-1)
            {
                j++;
            }
            else
            {
                j = 0;
            }
            ProgressText.text = progress * 100f + "%";

            yield return null;
        }
    }
    #endregion

    public void ExitGame()
    {
        Application.Quit();
    }


}
