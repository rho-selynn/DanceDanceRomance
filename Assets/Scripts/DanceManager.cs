using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceManager : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void StartDancing(int DanceChoice)
    {
        anim.SetInteger("choice", DanceChoice);
    }
    public void StopDance()
    {
        anim.SetInteger("choice", 0);
    }    
}
