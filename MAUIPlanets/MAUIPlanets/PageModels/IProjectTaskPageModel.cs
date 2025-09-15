using CommunityToolkit.Mvvm.Input;
using MAUIPlanets.Models;

namespace MAUIPlanets.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}