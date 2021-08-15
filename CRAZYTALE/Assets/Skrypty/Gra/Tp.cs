using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tp : MonoBehaviour
{
    public string PlayerTag = "Player";
    public int Index;
    public Text ProgressText;
    private void Start()
    {
        ProgressText.text = "";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == PlayerTag)
        {
            StartCoroutine(Odliczanie());
        }
    }
    IEnumerator Odliczanie()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(Index);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            ProgressText.text = "Loading scene: " + progress * 100f + "%";

            yield return null;
        }
    }
}
