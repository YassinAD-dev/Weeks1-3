using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float duration = 3.0f;
        float progress;

   public Vector3 newPostion; 




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        if (progress > duration)
        {
            newPostion.x = Random.Range(-5,5);
            newPostion.y = Random.Range(-5,5);
            transform.position = newPostion; 

            progress = 0f;

        }
    }
}
