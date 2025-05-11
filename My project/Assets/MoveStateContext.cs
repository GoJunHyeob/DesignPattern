using UnityEngine;

public class MoveStateContext : MonoBehaviour
{
    public Move move;

    public IState curstate;

    private void Start()
    {
        curstate = new StateStop();
        Debug.Log("Player의 처음 상태는 ");
        curstate.SayNowState(this, move);
    }
    
    public void Operate()
    {
        curstate.Execute(this, move);
    }

    public void SetState(IState newState)
    {
        curstate = newState;
    }
}
