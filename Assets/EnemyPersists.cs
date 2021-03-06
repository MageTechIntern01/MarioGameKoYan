using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPersists : MonoBehaviour
{

    void Start()
    {
        LevelExit.OnLevelFinished += LevelFinished;
        GameSession.OnFinalDeath += LevelFinished;
    }
    
    void OnDestroy()
    {
        LevelExit.OnLevelFinished -= LevelFinished;
        GameSession.OnFinalDeath -= LevelFinished;
    }
    void LevelFinished()
    {
        Destroy(gameObject);
    }
}
