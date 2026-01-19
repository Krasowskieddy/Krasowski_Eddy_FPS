using UnityEngine;

public class cemera : MonoBehaviour
{
    public float mousey = 1000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float yRot =(Input.GetAxis("Mouse Y") * mousey * Time.deltaTime);
        transform.Rotate(-yRot, 0, 0);
    }
}
