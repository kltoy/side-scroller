using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
  {

    private Rigidbody2D rb2D;
    [SerializeField] private float speed;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); 
            Vector2 move = new(1 * speed * horizontal, rb2D.velocity.y);
        rb2D.velocity = move;
    }
}
