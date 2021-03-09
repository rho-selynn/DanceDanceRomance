using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class TimeManager : MonoBehaviour
{
    private TextMeshPro textmesh;


    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshPro>();
    }

    
    public IEnumerator StartInstructins()
    {
        textmesh.text = "Learn the dance as best as you can.";
        yield return new WaitForSeconds(7f);
        textmesh.text = " ";
    }

    public IEnumerator EndInstructions()
    {
        textmesh.text = "Time is up! \nTurn around and wait for your turn to dance.";
        yield return new WaitForSeconds(7f);
    }
}
