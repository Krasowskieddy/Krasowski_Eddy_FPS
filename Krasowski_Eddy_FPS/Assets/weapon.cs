using UnityEngine;

public class weapon : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            {

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                Debug.Log("objet touché");
                if (hit.transform.gameObject.name=("target box"))
                {

                }
            }
        }
    }
}
