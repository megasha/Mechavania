using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Camera_Event : MonoBehaviour
{
    public GameObject lookAt;
    public CinemachineVirtualCameraBase cam;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Camera_Event collided with " + col.name);
        cam.Follow = lookAt.transform;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Camera_Event is no longer colliding with " + col.name);
        cam.Follow = Player.transform;
    }
}
