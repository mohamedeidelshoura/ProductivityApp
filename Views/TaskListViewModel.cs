using System.Collections.ObjectModel;
using System.Windows.Input;
using ReactiveUI;

namespace ProductivityApp.Views
{
    public class TaskViewModel : ReactiveObject
    {
        private string _title;
        private bool _isCompleted;

        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        public bool IsCompleted
        {
            get => _isCompleted;
            set => this.RaiseAndSetIfChanged(ref _isCompleted, value);
        }
    }

    public class TaskListViewModel : ReactiveObject
    {
        public ObservableCollection<TaskViewModel> Tasks { get; } = new();

        public ICommand AddTaskCommand { get; }

        public TaskListViewModel()
        {
            AddTaskCommand = ReactiveCommand.Create(AddTask);
        }

        private void AddTask()
        {
            Tasks.Add(new TaskViewModel { Title = "مهمة جديدة", IsCompleted = false });
        }
    }
}
