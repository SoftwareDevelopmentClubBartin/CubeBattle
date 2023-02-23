using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameManager() { } // singleton

    public Transform Player;

    public static GameManager Instance { get; private set; }

    /// <summary>The Layers created by developer</summary>
    public enum Layers
    {
        Default = 0,
        Player = 3,
        Enemy = 6,
    }

    private void Awake()
    {
        if (!(Player))
        {
            Debug.LogError("Null object in Game Manager!");
        }
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
