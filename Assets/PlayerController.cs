using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerSpeed;
    CharacterController characterController;
    Vector3 movement;
    Vector3 mouse;
    public Camera cam;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {


        movement.x = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        movement.y = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        characterController.Move(movement);

        mouse.x = Input.GetAxis("Mouse X") * rotateSpeed;
        mouse.y = Input.GetAxis("Mouse Y") * rotateSpeed;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouse.y, transform.rotation.eulerAngles.z);
        cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.eulerAngles + new Vector3(-mouse.y, 0, 0));

    }
}
