using System.Xml.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject door;

    private void Awake()
    {
        door.GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
            {

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                Debug.Log("test");

                if (hit.transform.gameObject.name == "target")
                {
                    GetComponent<OpenDoor>().bOpen = true;
                }
            }
        }
    }
}
