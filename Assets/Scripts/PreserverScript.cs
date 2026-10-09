using UnityEngine;

public class TextPreserver : MonoBehaviour
{
    private static TextPreserver textPreserverInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (textPreserverInstance != null && textPreserverInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        textPreserverInstance = this;

        DontDestroyOnLoad(this.gameObject);

       

    }

    
}

