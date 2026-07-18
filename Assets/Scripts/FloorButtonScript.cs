using UnityEngine;

public class FloorButtonScript : MonoBehaviour
{
    public bool IsOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(collision.TryGetComponent<Input>(out Input input))
        //{

        //}

        //if(collision.gameObject.name == "Player")
        //{

        //}

        if(collision.gameObject.tag == "Player")
        {
            IsOn = true;
            Debug.Log(IsOn);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            IsOn = false;
            Debug.Log(IsOn);
        }
    }
}
