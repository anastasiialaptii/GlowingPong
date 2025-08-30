using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bm;

    void Awake()
    {
        if(bm == null)
        {
            bm = this;
            DontDestroyOnLoad(bm);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
