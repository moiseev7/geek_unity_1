using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    public static PlayerSingleton Instance;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

}
