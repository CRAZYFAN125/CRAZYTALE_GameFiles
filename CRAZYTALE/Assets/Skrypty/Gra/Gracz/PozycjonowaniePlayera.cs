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
            SetAnim(0, 0, 0);
            Tp.teleport = false;
            return;
        }
        SetAnim(Poz.x,Poz.y,Poz.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        PlayerRB.MovePosition(PlayerRB.position + Poz * speed * Time.fixedDeltaTime);
    }
    public void SetAnim(float _x, float _y, float _speed)
    {
        anim.SetFloat("Horizontal", _x);
        anim.SetFloat("Vertical", _y);
        anim.SetFloat("speed", _speed);
    }
}
