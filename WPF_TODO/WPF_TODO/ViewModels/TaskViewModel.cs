using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using WPF_TODO.Models;
using WPF_TODO.Shared;

namespace WPF_TODO.ViewModels
{
    internal sealed class TaskViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public TaskViewModel()
        {
            taskList = new ObservableCollection<TaskModel>();
            addCommand = new Command(ExecuteAdd);
            doneCommand = new Command(ExecuteDone);
            deadline = DateTime.Today;
        }

        private ObservableCollection<TaskModel> taskList;
        public ObservableCollection<TaskModel> TaskList
        {
            get { return taskList; }
            set
            {
                taskList = value;
                OnPropertyChanged(nameof(TaskList));
            }
        }

        private Command addCommand;
        public Command AddCommand
        {
            get { return addCommand; }
        }
        private Command doneCommand;
        public Command DoneCommand
        {
            get { return doneCommand; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set
            {
                deadline = value;
                OnPropertyChanged(nameof(Deadline));
            }
        }

        private void ExecuteAdd()
        {
            var task = new TaskModel();
            task.Title = title;
            task.Deadline= deadline;
            task.Done = false;
            taskList.Add(task);
        }

        private void ExecuteDone()
        {
            for (int i = taskList.Count - 1; i >= 0; i--)
            {
                if (taskList[i].Done)
                {
                    taskList.RemoveAt(i);
                }
            }
        }


    }
}
