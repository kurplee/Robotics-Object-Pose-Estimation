using UnityEngine.Perception.Randomization.Scenarios;

public class PoseEstimationScenarioConstants : ScenarioConstants
{
    public int totalFrames = 1000;
}
public class PoseEstimationScenario : Scenario<PoseEstimationScenarioConstants>
{
    public bool automaticIteration = false;
    
    bool shouldIterate = false; 

    public void Move()
    {
        shouldIterate = true;
    }

    protected override void IncrementIteration()
    {
        base.IncrementIteration();
        shouldIterate = false;
    }

    public override bool isIterationComplete => automaticIteration || shouldIterate;
    public override bool isScenarioComplete => currentIteration >= constants.totalFrames;
}

