using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Target : MonoBehaviour
    
{ // adding the animation curve to change the movment of the target, the camera to ensure that the clicking and objects are on screen word and speed to have the ability to change it
    public AnimationCurve curve;
    public Camera gameCamera;
    public float speed = 0.02f;
    // adding the custaimztiation of the x,y and the timer
    //xMax
    //xMin
    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;
    public float timer;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;

        //When assigning a value using curve evualute and timer and using deltaTime to ensure that it is closly the same on diffrent components

        timer += Time.deltaTime; 

        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;
        newPosition.y =  curve.Evaluate(timer);
        transform.position = newPosition;



        // making to ensure that  the object does not go behond the boarder 
        //yMax
        if (newPosition.y > xMax)
        {
            //OPTION 1:
            speed *= -1f;

            //OPTION 2:
            //speed = -speed;

        }
        //yMin
        if (newPosition.y < xMin)
        {
            speed *= -1f;
        }
        //xMax
        if (newPosition.x > xMax)
        {
            //OPTION 1:
            speed *= -1f;

            //OPTION 2:
            //speed = -speed;
        }

        //xMin 
        if (newPosition.x < xMin)
        {
            speed *= -1f;

        }
        {
            


        }
        if (timer >= 1f)
        {
            timer = 0f;
        }

// to always make sure that the postion placment of the target is always storing the value
Vector3 currentMousePotion = Mouse.current.position.ReadValue();

        // to ensure that the object  is always in world space when needed to be shot
        Vector3 worldMousePostion = gameCamera.ScreenToWorldPoint(currentMousePotion);

        // trying to make it so the target doesnt just dissaper by just holding the left mouse and just moving it around
        bool leftMouseIsPressed = Mouse.current.leftButton.wasPressedThisFrame;


        float dist = Vector2.Distance(transform.position, worldMousePostion);
      Vector3 other= newPosition; 
        
        // makes it so when the object is hit it will teleport 5000 pixels away from the screen play making it appear as the target responded to the click
        if (leftMouseIsPressed && dist <= 1f)

        { 
            transform.position =new Vector3 (50000,0,0) ;

            // the use of lerp to indicate point a to point b to bounce back and fourt
            Vector3 Lerp = Vector3.Lerp (transform.position, other, 0) ;


        }

    }
}
