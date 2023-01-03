using Core;

namespace BusinessLogic;

public interface IScenarioService
{
    Task<IEnumerable<Scenario>> GetScenarios(GameMode gameMode);
}
public class ScenarioService : IScenarioService
{
    public async Task<IEnumerable<Scenario>> GetScenarios(GameMode gameMode)
    {
        await Task.CompletedTask;
        return new List<Scenario>()
        {
            new Scenario
            {
                 Description = "All",
                 GameMode= gameMode,
                 Id = 1
            },
            new Scenario
            {
                 Description = "(C&K) The First Island",
                 GameMode= gameMode,
                 Id = 2
            }
        };
    }
}