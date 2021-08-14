using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spadanie : MonoBehaviour
{
    public Transform ObjectToCheck;
    public Transform vector2;
    public bool G³os = true;
    public GameObject @object;
    private void FixedUpdate()
    {
        if (ObjectToCheck.position.y<=-7f && G³os == true)
        {
            Instantiate(@object, new Vector3(0, 0, 0), Quaternion.identity);
            G³os = false;
        }
        if (ObjectToCheck.position.y <= vector2.position.y)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }
}
