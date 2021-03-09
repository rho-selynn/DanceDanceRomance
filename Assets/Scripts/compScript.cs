using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compScript : MonoBehaviour
{
    [SerializeField]
    private GameObject WhiteMale, BlackMale, WhiteFemale, BlackFemale;

    private bool compSet = true;
    private string compType;
    private DanceManager compPerson;

    // Start is called before the first frame update
    void Start()
    {
        WhiteMale.SetActive(false);
        BlackMale.SetActive(false);
        WhiteMale.SetActive(false);
        BlackFemale.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!compSet)
        {
            if (compType == "WM")
            {
                WhiteMale.SetActive(true);
                compPerson = WhiteMale.GetComponent<DanceManager>();
            }
            else if (compType == "BM")
            {
                BlackMale.SetActive(true);
                compPerson = BlackMale.GetComponent<DanceManager>();
            }
            else if (compType == "WF")
            {
                WhiteFemale.SetActive(true);
                compPerson = WhiteFemale.GetComponent<DanceManager>();
            }
            else if (compType == "BF")
            {
                BlackFemale.SetActive(true);
                compPerson = BlackFemale.GetComponent<DanceManager>();
            }
            compSet = true;
        }
    }
    public void CompSet(string CompType)
    {
        // the CompType is given by the game manager.
        compType = CompType;
        // This will trigger the right model to be active.
        compSet = false;
    }
    public void StartDancing(int DanceChoice)
    {
        compPerson.StartDancing(DanceChoice);
    }
    public void StopDance() 
    {
        compPerson.StopDance();
    }
}
