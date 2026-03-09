using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    public bool bOpen = false;
    public float speed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bOpen) door.transform.Translate(0, speed*Time.deltaTime, 0);
    }
}
