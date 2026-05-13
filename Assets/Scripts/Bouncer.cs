using UnityEngine;

public class Bouncer : MonoBehaviour



{    
    public float speed = 0.2f;
    // the min and max for ball postioning
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPostion = transform.position;
        newPostion.x += speed;
        transform.position = newPostion;
        newPostion.y += speed;
        transform.position = newPostion;


        //yMax
        if (newPostion.y > xMax)
        {
            //OPTION 1:
            speed *= -1f;

            //OPTION 2:
            //speed = -speed;

        }
        //yMin
        if (newPostion.y < xMin)
        {
            speed *= 1f;
        }
        //xMax
        if (newPostion.x > xMax)
        {
            //OPTION 1:
            speed *= -1f;

            //OPTION 2:
            //speed = -speed;
        }

        //xMin 
        if (newPostion.x < xMin)
        {
            speed *= 1f;

        }
    }
}
