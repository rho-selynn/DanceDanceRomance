using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Instructions2 : MonoBehaviour
{
    private TextMeshPro textmesh;


    // Start is called before the first frame update
    void Start()
    {
        textmesh = transform.GetComponent<TextMeshPro>();
    }


    public IEnumerator NotYourTurnDisp(float time)
    {
        textmesh.SetText("Wait for your turn.");
        yield return new WaitForSeconds(time);
        textmesh.text = " ";
    }

    public IEnumerator YourTurnDisp(float time)
    {
        textmesh.SetText("Your turn. \nDance now.");
        yield return new WaitForSeconds(time);
    }
}
