using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    //Prefabs
    public GameObject mColorObjectPrefab;

    private RuntimePreferences mRuntimePreferences;

    // Use this for initialization
    void Start()
    {
        mRuntimePreferences = GetComponent<RuntimePreferences>();
        SpawnTestBalls();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnTestBalls()
    {
        
    }
}

