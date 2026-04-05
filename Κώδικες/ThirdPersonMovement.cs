using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Animator animator;

    public float speed = 6f;
    
    public float TurnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
  


        if(direction.magnitude >=0.1)
        {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y ;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, TurnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            float vert = Vector3.Dot(moveDir.normalized, transform.forward);
            float hor = Vector3.Dot(moveDir.normalized, transform.right);

            //Debug.Log("Vert="+vert);
            //Debug.Log("Hor="+hor);


            animator.SetFloat("vertical", vert,0.1f,Time.deltaTime);
            animator.SetFloat("horizontal", hor,0.1f, Time.deltaTime);

            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
        else
        {
            animator.SetFloat("vertical", 0f);
            animator.SetFloat("horizontal", 0f);
        }

    }
}
