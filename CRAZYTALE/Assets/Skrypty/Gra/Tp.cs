using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tp : MonoBehaviour
{
    public static bool teleport = false;
    public string PlayerTag = "Player";
    public int Index;
    public Text ProgressText;
    public Behaviour[] ComponentsToTurnOff;

    private void Start()
    {
        if(ProgressText!=null)
        {
            ProgressText.text = "";
        }
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
        teleport = true;
        AsyncOperation operation = SceneManager.LoadSceneAsync(Index);
        if (ComponentsToTurnOff.Length != 0)
        {
            foreach (Behaviour item in ComponentsToTurnOff)
            {
                if(item != null)
                {
                    item.enabled = false;
                }
            }
        }
        if (ProgressText != null)
        {
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            ProgressText.text = "Loading scene: " + progress * 100f + "%";

            yield return null;
        }
        }
    }
}
