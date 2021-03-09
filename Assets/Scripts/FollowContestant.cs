using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowContestant : MonoBehaviour
{
    public GameObject cont;
    public GameObject play1;
    public bool change;
    public bool isLookingLeft;
    private Light myLight;

    // Update is called once per frame
    void Start()
    {
        myLight = GetComponent<Light>(); 
    }

    void Update()
    {
        if (change)
        {
            if (isLookingLeft)
            {
                Vector3 targetPos = new Vector3(cont.transform.position.x, cont.transform.position.y, cont.transform.position.z);
                transform.LookAt(targetPos);
            }
            else
            {
                Vector3 targetPos = new Vector3(play1.transform.position.x, play1.transform.position.y, play1.transform.position.z);
                transform.LookAt(targetPos);
            }
            change = false;
        }
    }
    public void ToggleLocation()
    {
        change = true;
    }
    public void ToggleActivation()
    {

        myLight.enabled = !myLight.enabled;
    }
}
