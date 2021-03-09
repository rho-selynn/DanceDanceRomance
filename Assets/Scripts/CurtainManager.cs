using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurtainManager : MonoBehaviour
{
    public float Speed;
    public Vector3 open_pos;
    public Vector3 closed_pos;

    private Vector3 end_pos;
    private bool open = false;
    private bool moving = false;
    private bool change_pos = false;

    // Update is called once per frame
    void Update()
    {
        //this will be set to true by the game manager
        if (change_pos && !moving)
        {
            //setting the start and end positions depening on if it is open or not.
            if (open)
            {
                end_pos = closed_pos;
            }
            else
            {
                end_pos = open_pos;
            }

            // this is the bool that will keep it running after it is unclicked
            moving = true;
        }
        if (moving)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, end_pos, Speed * Time.deltaTime);
            transform.position = newPos;
            if (end_pos == transform.position)
            {
                moving = false;
                open = !open;
                change_pos = false;
            }
        }
    }
    public void toggle()
    {
        // this will trigger the curtain to move in update function.
        change_pos = true;
    }
}
