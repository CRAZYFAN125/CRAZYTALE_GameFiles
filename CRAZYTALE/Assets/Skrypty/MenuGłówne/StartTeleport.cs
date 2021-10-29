using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartTeleport : MonoBehaviour
{
    public GameObject TeleportCoil;
    public int Index;
    bool TpOnline;
    void FixedUpdate()
    {
        if (gameObject.transform.localScale.x <= 0.1f&& !TpOnline) { TeleportToRuins(); TpOnline = true; }
    }
    public void TeleportToRuins()
    {
        TeleportCoil.SetActive(true);
        SceneManager.LoadSceneAsync(Index);
    }
    
}