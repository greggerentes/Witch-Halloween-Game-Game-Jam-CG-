using UnityEngine;

public class Customer : MonoBehaviour
{
    [SerializeField] private GameObject skeleton;

    float timer = 0f;
    float spawnTime = 5f;
    
    void Start()
    {
        
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawnTime)
        {
            skeleton.SetActive(true);
        }
    }
}
