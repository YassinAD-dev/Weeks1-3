using UnityEngine;
using UnityEngine.InputSystem;

public class ChaserMover : MonoBehaviour
{
    public Camera gameCamera; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePotion = Mouse.current.position.ReadValue();
        transform.position = currentMousePotion;

        Vector3 worldMousePostion = gameCamera.ScreenToWorldPoint(currentMousePotion);
        worldMousePostion.z = 0f;
        transform.position= worldMousePostion;
    }
}
