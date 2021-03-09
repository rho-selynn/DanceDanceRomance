using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookLight : MonoBehaviour
{
    //public Animator anim;
    public GameObject target;
    

    void Start()
    { 
        
    }

    /*IEnumerator LookAt(Transform objectMove, Vector3 worldPos, float duration)
    {
        Quaternion currentRot = objectMove.rotation;
        Quaternion newRot = Quaternion.LookRotation(worldPos - objectMove.position, objectMove.TransformDirection(Vector3.up));

        float counter = 0;

        while(counter < duration)
        {
            counter += Time.deltaTime;
            objectMove.rotation = Quaternion.Lerp(currentRot, newRot, counter / duration);
            yield return null;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z);
        transform.LookAt(targetPosition);
    }
}
