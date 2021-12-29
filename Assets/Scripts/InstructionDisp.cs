using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionDisp : MonoBehaviour
{
    [SerializeField]
    private Text directionsText;
    private GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Head");
        directionsText.gameObject.transform.parent.parent.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public IEnumerator TextDisplay(string text)
    {
        directionsText.gameObject.transform.parent.parent.gameObject.SetActive(true);
        directionsText.text = text;
        yield return new WaitForSeconds(10f);
        directionsText.gameObject.transform.parent.parent.gameObject.SetActive(false);
    }

    private void Update()
    {
        //endText.gameObject.transform.parent.parent.gameObject.transform.position = player.transform.position + player.transform.forward * 3 + player.transform.up *2;
        directionsText.gameObject.transform.parent.parent.gameObject.transform.position = new Vector3(player.transform.forward.x * 3 + player.transform.position.x, 1f, player.transform.forward.z * 3 + player.transform.position.z);
        directionsText.gameObject.transform.parent.parent.gameObject.transform.rotation = Quaternion.Euler(player.transform.rotation.eulerAngles.x, player.transform.rotation.eulerAngles.y + 180, 0);
    }
}
