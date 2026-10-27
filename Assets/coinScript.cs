using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
int rotateSpeed = 2;
AudioSource coinCollect;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);

    }

    void OnTriggerEnter()
    {
        // coinCollect.play();
        Destroy(gameObject);
    }
}
 
