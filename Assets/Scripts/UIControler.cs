using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIControler : MonoBehaviour
{
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    public IEnumerator UIDisplay(string text)
    {
        textMesh.text = text;
        yield return new WaitForSeconds(10);
        textMesh.text = "";
    }
}
