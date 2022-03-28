using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    public Material FailureMaterial;
    private int _enemyCollisionCount = 0;
    [SerializeField]
    private int _health = 5;
    

    /// <summary>
    /// How meny enemies hit the game object
    /// <summary>
    public int EnemyCount 
    {
        get { return _enemyCollisionCount; }
        set { _enemyCollisionCount = value; }
    }
    private void Update()
    {
        if (_enemyCollisionCount >= _health)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer)
            {
                renderer.material = FailureMaterial;
            }
        }
    }
}
