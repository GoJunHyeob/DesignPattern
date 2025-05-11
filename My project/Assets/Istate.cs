using UnityEngine;

public interface IState
{
    void Execute(MoveStateContext context, Move move);
    void SayNowState(MoveStateContext context, Move move);
}

public class StateRun : IState
{
    public void Execute(MoveStateContext context, Move move)
    {
        move.Stop();
        context.SetState(new StateStop());
    }

    public void SayNowState(MoveStateContext context, Move move)
    {
        move.Run();
    }
}

public class StateStop : IState
{
    public void Execute(MoveStateContext context, Move move)
    {
        move.Run();
        context.SetState(new StateRun());
    }

    public void SayNowState(MoveStateContext context, Move move)
    {
        move.Stop();
    }
}