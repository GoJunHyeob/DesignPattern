using UnityEngine;

public class Button : MonoBehaviour
{
    public MoveStateContext context;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
        {
            context.Operate();
        }
    }
}
