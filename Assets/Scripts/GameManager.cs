using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private DanceManager teacher1, teacher2;

    public float teachingTime;
    public float turnLength;
    //public TimeManager teachingTimer;
    public CurtainManager curtain;
    public compScript compObject;
    public LightManager practiceLight;
    public FollowContestant spotLight;
    //public Instructions2 display2;
    public InstructionDisp display;


    public int DanceChoice;

    public string CompType;

    private AudioSource danceMusic;
    private AudioSource crowdCheer;
    private AudioSource crowdBoo;

    void Start()
    {
        danceMusic = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        crowdCheer = GameObject.FindGameObjectWithTag("Cheer").GetComponent<AudioSource>();
        crowdBoo = GameObject.FindGameObjectWithTag("Boo").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            StartCoroutine(TeacherPart());
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DanceChoice = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DanceChoice = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DanceChoice = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            DanceChoice = 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            DanceChoice = 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            DanceChoice = 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            DanceChoice = 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            DanceChoice = 8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            DanceChoice = 9;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DanceChoice = 10;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Q = White male
            compObject.CompSet("WM");
            CompType = "white male";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            //W = Black male
            compObject.CompSet("BM");
            CompType = "Black Male";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            //E = White Female
            compObject.CompSet("WF");
            CompType = "White feamle";
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            //R = Black Female
            compObject.CompSet("BF");
            CompType = "Black Female";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {   // restart the scene
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            crowdBoo.Play();
        }
    }


    IEnumerator TeacherPart()
    {

        //set the instructions on the first disp:
        //StartCoroutine(teachingTimer.StartInstructins());
        StartCoroutine(display.TextDisplay("Learn the dance as best you can."));

        // this is just to set the spot light to off to start
        spotLight.ToggleActivation();

        yield return new WaitForSeconds(7);

        //start animation of teacher teaching
        //teacher1.StartDancing(DanceChoice);
        teacher2.StartDancing(DanceChoice);

        //start music
        danceMusic.Play();

        yield return new WaitForSeconds(teachingTime);

        //practice light off
        practiceLight.Toggle();

        //trigger the curtain.
        curtain.toggle();

        //music pause
        danceMusic.Stop();

        //teacher animation stop
        //teacher1.StopDance();
        teacher2.StopDance();

        //UI
        //StartCoroutine(Uidisplay.UIDisplay("Times Up, wait for your turn to dance."));

        //StartCoroutine(teachingTimer.EndInstructions());
        StartCoroutine(display.TextDisplay("Turn around and wait for your turn to dance"));
        yield return new WaitForSeconds(7);

        StartCoroutine(Part2());
    }

    IEnumerator Part2()
    {
        //music start
        danceMusic.Play();

        //instructions2 Not your turn:
        //StartCoroutine(display2.NotYourTurnDisp(turnLength));
        StartCoroutine(display.TextDisplay("It is not your turn yet."));

        //spotlight on 
        spotLight.ToggleActivation();

        //crowd
        crowdCheer.Play();

        yield return new WaitForSeconds(2f);

        //competatur animation starts
        compObject.StartDancing(DanceChoice);

        yield return new WaitForSeconds(turnLength);

        //competatur animation stops
        compObject.StopDance();

        yield return new WaitForSeconds(2f);

        //music off
        danceMusic.Stop();

        yield return new WaitForSeconds(2f);

        //stop crowd sound
        crowdCheer.Stop();

        //light change 
        spotLight.ToggleLocation();

        yield return new WaitForSeconds(2f);
        //UI
        //StartCoroutine(Uidisplay.UIDisplay("It is your turn to dance"));

        //start music 
        danceMusic.Play();

        //instructions 2 your turn now:
        //StartCoroutine(display2.YourTurnDisp(turnLength));
        StartCoroutine(display.TextDisplay("It is now your turn to dance.\n \nParticipant 2: please refer to the sheet to control audience reactions"));

        yield return new WaitForSeconds(turnLength);

        //spotlight goes off.
        spotLight.ToggleActivation();

        //music goes off
        danceMusic.Stop();

        //UI
        StartCoroutine(display.TextDisplay("The round is now over."));

        yield return new WaitForSeconds(1F);

        //trigger the curtain.
        curtain.toggle();

        yield return new WaitForSeconds(5F);
        //reloads the scene
        SceneManager.LoadScene(0);
    }
}
