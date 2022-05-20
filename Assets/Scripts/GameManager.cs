using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetButton()
    {
        Instantiate(gameObject, new Vector3(1f, 0.0f, 0.0f), Quaternion.identity);
    }
}
