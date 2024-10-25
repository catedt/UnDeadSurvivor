using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Player player;
    public PoolManager pool;

    public void Awake()
    {
        Instance = this;
    }
}
