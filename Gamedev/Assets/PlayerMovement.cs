using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    private float move_speed = 1.5f;

    void OnAnimatorMove()
    {
        Animator animator = GetComponent<Animator>(); 
        bool forwardpressed = Input.GetKey(KeyCode.UpArrow);
        bool fastpressed = Input.GetKey(KeyCode.Space);
        

        bool leftpressed = Input.GetKey(KeyCode.LeftArrow);
        bool righttpressed = Input.GetKey(KeyCode.RightArrow);
        

            if (animator)
            {
                if (fastpressed){
                    animator.SetBool("isrunning",true);
                }
                else{
                    animator.SetBool("isrunning",false);
                }
                if (forwardpressed){
                    animator.SetBool("iswalking",true);
                }
                else{
                    animator.SetBool("iswalking",false);
                }
                if (leftpressed){
                    animator.SetBool("leftwalk",true);
                }
                else{
                    animator.SetBool("leftwalk",false);
                }
                if (righttpressed){
                    animator.SetBool("rightwalk",true);
                }
                else{
                    animator.SetBool("rightwalk",false);
                }
                
                bool isWalking = animator.GetBool("iswalking");
                bool isRunning = animator.GetBool("isrunning");

                bool wantLeftmove = animator.GetBool("leftwalk");
                bool wantRightmove = animator.GetBool("rightwalk");

                float speed_ = animator.GetFloat("RunSpeed");
                Vector3 newPosition = transform.position;


                if(isRunning ){
                    transform.position += Time.deltaTime * 5 * move_speed * transform.forward;
                }
                if( !isRunning && isWalking){
                    transform.position += Time.deltaTime * move_speed * transform.forward;
                }
                if(leftpressed){
                    transform.RotateAround(transform.position, transform.up, -20 * Time.deltaTime);
                }
                if(righttpressed){
                    transform.RotateAround(transform.position, transform.up, 20 * Time.deltaTime);
                }
                
            }
    }
}
