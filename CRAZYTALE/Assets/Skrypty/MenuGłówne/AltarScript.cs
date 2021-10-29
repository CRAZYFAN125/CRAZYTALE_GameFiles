using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class AltarScript : MonoBehaviour
{
    public bool showTime = false;
    public Transform tpPoint;
    public Transform player;
    public PozycjonowaniePlayera pozycjonowaniePlayera;
    public GameObject[] runy;
    public GameObject ring;
    public Light2D Lampa;
    int index=0;
    bool used = false;
    [Header("T:")]
    public float mnoznik = 0.2f;

    float time;

    // Update is called once per frame
    void Update()
    {
        if (showTime)
        {
            if (index != runy.Length)
            {
                if (time >= 5)
                {
                    runy[index].SetActive(true);
                    index++;
                    time = 0;
                    return;
                }
                else
                {
                    time += Time.deltaTime * mnoznik;
                }
            }
            else
            {
                ring.SetActive(true);
                showTime = false;
            }
        }
    }

    private void OnMouseDown()
    {
        if (used)
        {
            return;
        }
        TpPlayer();
        showTime = true;
        used = true;
    }

    void TpPlayer()
    {
        Mathf.Lerp(Lampa.intensity, 0, 5f);
        Lampa.gameObject.SetActive(false);
        pozycjonowaniePlayera.SetAnim(0, -1, 0.2f);
        pozycjonowaniePlayera.SetAnim(0, 0, 0);
        pozycjonowaniePlayera.enabled = false;
        player.position = tpPoint.position;
    }
}
