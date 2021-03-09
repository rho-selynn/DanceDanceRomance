using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudenceManager : MonoBehaviour
{
    // Start is called before the first frame update
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
