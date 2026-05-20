using UnityEngine;
using UnityEngine.InputSystem;

public class CursuerFollower : MonoBehaviour
{ // public camera makes it so the currosr doesnt just go out of bounds and confoim the postion of screen space

    public Camera gameCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()


    { // to always make sure that the postion placment of the mouse is always storing the value
        Vector3 currentMousePotion = Mouse.current.position.ReadValue();
       
        // to ensure that the object following the mouse is always in world space
        Vector3 worldMousePostion = gameCamera.ScreenToWorldPoint(currentMousePotion);

        // this is for accounting that the cameras distance from the screen doesn't break.  
        worldMousePostion.z = 0f;

        // change postion of the object to be with the mouse
        transform.position = worldMousePostion;
    }
}
