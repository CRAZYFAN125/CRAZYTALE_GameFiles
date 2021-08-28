using System;
using UnityEngine;

public class PlayerGui:MonoBehaviour{
    [Header("Pauza:")]
    public GameObject Pauza;
    private bool isPaused = false;
    public KeyCode PauseKey = KeyCode.Escape;
    [Header("Dialog:")]
    public string Text;
    
    
    public void PauseGame(){
        isPaused = !isPaused;
        Pauza.SetActive(isPaused);
    }
    
    void Update(){
        #region PauzaKeyingCheck
        if(isPaused = false){
            PauseGame();
        }
        #endregion
        
        
    }
}