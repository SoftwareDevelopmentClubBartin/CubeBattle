using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    Rigidbody2D rigidbody; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var a = new Vector2(5.5f, 5.6f);
        float YanalHareket = Input.GetAxisRaw("Horizontal");
        float DikeyHareket = Input.GetAxisRaw("Vertical");
    }
}
