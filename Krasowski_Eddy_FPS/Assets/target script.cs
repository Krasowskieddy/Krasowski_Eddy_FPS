using UnityEngine;

public class targetscript : MonoBehaviour
{
    public GameObject target;
    bool isShoot;
    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 10);

        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            Debug.Log("le raycast touche un object !");
            isShoot = true;
        }
    }
}
