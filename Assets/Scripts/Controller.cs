using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpHeld = Keyboard.current.upArrowKey.isPressed;
        if(isUpHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        bool isDownHeld = Keyboard.current.downArrowKey.isPressed;
        if (isDownHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }

        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;
        if (isLeftHeld)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }
        bool isRighttHeld = Keyboard.current.rightArrowKey.isPressed;
        if (isRighttHeld)
        {
            transform.eulerAngles -= transform.forward * rotationSpeed * Time.deltaTime;
        }

    }
}
