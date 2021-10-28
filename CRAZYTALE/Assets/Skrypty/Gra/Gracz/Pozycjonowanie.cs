using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozycjonowanie : MonoBehaviour
{
    [Header("Camera inputs:")]
    public bool ZaGraczem = true;
    public Transform Cam;
    public Transform LockPlus;
    public Transform LockMinus;
    public Transform Player;
    void FixedUpdate()
    {
        #region Podarzanie
        if (!ZaGraczem)
        {
            return;
        }
        if (LockPlus == null || LockMinus == null)
        {
            Ruch();
            return;
        }
        if (Player.position.x <= LockPlus.position.x && Player.position.y<=LockPlus.position.y)
        {
            if (Player.position.x >= LockMinus.position.x && Player.position.y >= LockMinus.position.y)
            {
                Ruch();
            }
        }
        #endregion
    }
    void Ruch(){
        Vector3 v = Player.position;
                v.z = -10;
                Cam.position = v;
    }
}
