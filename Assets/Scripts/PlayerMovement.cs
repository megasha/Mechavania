using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;
	public Animator animator;
	public Rigidbody2D m_Rigidbody2D;
	float horizontalMove = 0f;
	float verticalMove = 0f;
	public float runSpeed = 40f;
	bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		verticalMove = m_Rigidbody2D.velocity.y;
		animator.SetFloat("H_Speed", Mathf.Abs(horizontalMove));
		animator.SetFloat("V_Speed", verticalMove);

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
		Debug.Log("Current vertical velocity: " + m_Rigidbody2D.velocity.y);
		if (verticalMove < 2.5f && verticalMove > -2.5f)
		{
			animator.SetBool("IsAerial", false);
		} else
		{
			animator.SetBool("IsAerial", true);
		}
    }
	void FixedUpdate()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
		
	}
}
