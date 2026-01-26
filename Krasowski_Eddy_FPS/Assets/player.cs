using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 40;
    public float jump = 10;
    public float mouseX = 10;

    public Animator myAnimator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        myAnimator.SetBool("isMoving", false);
        myAnimator.SetBool("isJumping", false);

             if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
                myAnimator.SetBool("isMoving", true);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
                myAnimator.SetBool("isMoving", true);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
                myAnimator.SetBool("isMoving", true);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
                myAnimator.SetBool("isMoving", true);
            }
            if (Input.GetKey(KeyCode.Space))
            {
                transform.Translate(Vector3.up * jump * Time.deltaTime);
                myAnimator.SetBool("isJumping", true);

             }
            float xRotation = Input.GetAxis("Mouse X") * mouseX * Time.deltaTime;

            transform.Rotate(0, xRotation, 0);
    }
    }
