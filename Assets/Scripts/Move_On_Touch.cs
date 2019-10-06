using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_On_Touch : MonoBehaviour
{
    [SerializeField]
    private Vector3 velocity;
    private bool moving;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        moving = true;
        col.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        col.collider.transform.SetParent(null);
    }

    private void FixedUpdate()
    {
        if (moving)
        {
            transform.position += (velocity * Time.deltaTime);
        }
    }
}
