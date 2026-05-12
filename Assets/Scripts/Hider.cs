using UnityEngine;
using UnityEngine.InputSystem;

public class Hider : MonoBehaviour

{
    public float hideDistanceThreshold;


    public Vector3 hidePostion;

    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePostion = Mouse.current.position.ReadValue();
        Vector3 worldMousePostion = gameCamera.ScreenToWorldPoint(mousePostion);
        worldMousePostion.z = 0f;

        float distance;

        distance = Vector3.Distance(worldMousePostion, transform.position);
                Debug.Log(distance);
        // if the mouse is close to the object
        if (distance < hideDistanceThreshold)
        {

            transform.position = hidePostion;
        }
    }
}
