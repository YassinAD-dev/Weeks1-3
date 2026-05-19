using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed;
    //zMax
    //zMin
    public float zMax;
    public float zMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRoatation = transform.eulerAngles;

        currentRoatation.z += speed*Time.deltaTime;
        

        transform.eulerAngles = currentRoatation;

        currentRoatation.z += speed;
        transform.eulerAngles = currentRoatation;


        //zMax
        if (currentRoatation.z > zMax)
        {
            Debug.Log("Crossing the upper threshold currentZ[" + currentRoatation.z.ToString() + "] zMax[" + zMax.ToString() + "]"); speed = -speed;
        }
        if (currentRoatation.y < zMin)
        {
            Debug.Log("crossing the low");
            speed = +speed;
        }
        
    }
}
