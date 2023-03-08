using Livet;
using Livet.Commands;
using Livet.EventListeners;
using Livet.Messaging;
using Livet.Messaging.IO;
using Livet.Messaging.Windows;
using MyTodoApp3.Models;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyTodoApp3.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        public ObservableCollection<Todo> Todos { get; private set; } = new ObservableCollection<Todo>();
    }
}
