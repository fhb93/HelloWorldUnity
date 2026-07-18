using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private FloorButtonScript floorButtonScript;

    private Coroutine corout;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        floorButtonScript = GameObject.FindFirstObjectByType<FloorButtonScript>();
    }

    IEnumerator OpenDoor()
    {

        while(transform.position.y < 4f)
        {
            MoveUp();
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator CloseDoor()
    {

        while (transform.position.y > 1.3f)
        {
            MoveDown();
            yield return new WaitForSeconds(1f);
        }

    }

    private void Update()
    {
        if(floorButtonScript.IsOn)
        {
            StartCoroutine(OpenDoor());
        }
        else
        {
            StartCoroutine(CloseDoor());
        }
    }


    void MoveUp()
    {
        transform.position += Vector3.up * Time.deltaTime;
    }

    void MoveDown()
    {
        transform.position -= Vector3.up * Time.deltaTime;
    }
}
