using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinemachineSwitcher : MonoBehaviour
{

    private Animator animator;


    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
 

     void OnTriggerEnter(Collider other) {
         if (other.tag == "Player") {
             animator.Play("2DCam");
         }
        
     }

     void OnTriggerExit(Collider other) {
         
             animator.Play("ThirdPersonCam");
         
     }
}
