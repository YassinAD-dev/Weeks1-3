using UnityEngine;
using UnityEngine.InputSystem;

public class Target : MonoBehaviour
    
{
    public AnimationCurve curve;
    public Camera gameCamera;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        
        
    }

    // Update is called once per frame
    void Update()
    {
        // to always make sure that the postion placment of the target is always storing the value
        Vector3 currentMousePotion = Mouse.current.position.ReadValue();

        // to ensure that the object  is always in world space when needed to be shot
        Vector3 worldMousePostion = gameCamera.ScreenToWorldPoint(currentMousePotion);
        

        bool leftMouseIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        // trying to make it so the target doesnt just dissaper by just holding the left mouse and just moving it around
        


    }
}
