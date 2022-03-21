using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTarget : MonoBehaviour
{
    private Renderer Rrenderer;
    public bool onobject;
    public bool playerCut;
    // Start is called before the first frame update
    void Start()
    {
        Rrenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ////UNCOMMENT BELOW IF YOU WANT ON CLICK CUTTING
        // if(onobject==true && Input.GetButtonDown("Fire1"))
        // {
        //     Destroy(gameObject);
        //     playerCut=true;
        // }
        // else
        // {
        //     playerCut=false;
        // }
    }

    private void OnMouseEnter()
    {
        Rrenderer.material.color = Color.red;
        onobject=true;
        Destroy(gameObject); //COMMENT THIS IF YOU WANT ON CLICK CUTTING
        //Debug.Log("mouse enter");
    }

    private void OnMouseExit()
    {
        Rrenderer.material.color = Color.white;
        //Debug.Log("mouse exit");
        onobject=false;
    }

}
