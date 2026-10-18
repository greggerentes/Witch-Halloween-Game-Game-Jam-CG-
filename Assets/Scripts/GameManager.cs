using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public int herbCount = 0;
    
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Awake()
    {
        Instance = this;
    }
    
    public void AddHerb()
    {
        herbCount++;
    }
}
