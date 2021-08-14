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

        gameObject.transform.position += new Vector3(Poz.x, Poz.y, 0) * Time.deltaTime;

        //if (Poz.x > 0.01)
        //{
        //    gameObject.transform.position += new Vector3(speed, 0, 0);
        //}
        //if (Poz.x > 0.01)
        //{
        //    gameObject.transform.position += new Vector3(-speed, 0, 0);
        //}
        //if (Poz.y > 0.01)
        //{
        //    gameObject.transform.position += new Vector3(0, speed, 0);
        //}
        //if (Poz.y < 0.01)
        //{
        //    gameObject.transform.position += new Vector3(0, -speed, 0);
        //}

        if (anim.GetBool("Sleeping") && Poz.sqrMagnitude > 0.01)
        {
            anim.SetBool("Sleeping", false);
        }
        anim.SetFloat("Horizontal", Poz.x);
        anim.SetFloat("Vertical", Poz.y);
        anim.SetFloat("speed", Poz.sqrMagnitude);
    }
}
