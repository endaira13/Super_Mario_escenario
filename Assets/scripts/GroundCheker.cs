using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    player _player;
    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<player>();
    }

    // Update is called once per frame
    void OnTriggerStay2D(Collider2D col)
    {
       _player.isGrounded = true;
       _player._animator.SetBool("Jumping", false);
    }

    void OnTriggerExit2D(Collider2D col)
    {
        _player.isGrounded = false;
    }
}
