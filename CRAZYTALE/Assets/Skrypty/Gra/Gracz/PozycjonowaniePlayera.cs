using System;
using UnityEngine;

public class PozycjonowaniePlayera : MonoBehaviour
{
    public Vector2 Poz;
    public float speed;
    public Rigidbody2D PlayerRB;
    public Animator anim;
    void Update()
    {
        Poz.y = Input.GetAxisRaw("Vertical");
        Poz.x = Input.GetAxisRaw("Horizontal");


        if (Tp.teleport)
        {
            anim.SetFloat("Horizontal", 0);
            anim.SetFloat("Vertical", 0);
            anim.SetFloat("speed", 0);
            Tp.teleport = false;
            return;
        }
        anim.SetFloat("Horizontal", Poz.x);
        anim.SetFloat("Vertical", Poz.y);
        anim.SetFloat("speed", Poz.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        PlayerRB.MovePosition(PlayerRB.position + Poz * speed * Time.fixedDeltaTime);
    }
    Boolean Key(KeyCode key)
    {
        if (Input.GetKey(key))
        {
            return true;
        }
        return false;
    }
}
