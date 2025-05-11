using UnityEngine;

public class MakePrefab : MonoBehaviour
{
    public GameObject prefab;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instance = Instantiate(prefab);
        }
    }
}
