using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BackgroundManager : MonoBehaviour
{

    [SerializeField] CinemachineVirtualCameraBase cam;
    [SerializeField] GameObject background;
    [SerializeField] GameObject foreground;

    [SerializeField] float backgroundXScale = 0;
    [SerializeField] float backgroundYScale = 0;

    [SerializeField] float foregroundXScale = 0;
    [SerializeField] float foregroundYScale = 0;

    [SerializeField] float backgroundXPosOffset = 0;
    [SerializeField] float backgroundYPosOffset = 0;

    [SerializeField] float foregroundXPosOffset = 0;
    [SerializeField] float foregroundYPosOffset = 0;

    private Material backMat;
    private Material foreMat;

    // Start is called before the first frame update
    void Start()
    {
        backMat = background.GetComponent<Renderer>().material;
        foreMat = foreground.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        background.transform.position = new Vector3(cam.transform.position.x + backgroundXPosOffset, cam.transform.position.y + backgroundYPosOffset, background.transform.position.z);
        backMat.mainTextureOffset = new Vector2(cam.transform.position.x*backgroundXScale, cam.transform.position.y* backgroundYScale);

        foreground.transform.position = new Vector3(cam.transform.position.x + foregroundXPosOffset, cam.transform.position.y + foregroundYPosOffset, foreground.transform.position.z);
        foreMat.mainTextureOffset = new Vector2(cam.transform.position.x * foregroundXScale, cam.transform.position.y * foregroundYScale);
    }
}
