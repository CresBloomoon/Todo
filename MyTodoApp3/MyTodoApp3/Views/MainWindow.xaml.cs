using MyTodoApp3.Models;
using MyTodoApp3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTodoApp3.Views
{
    /* 
     * If some events were receive from ViewModel, then please use PropertyChangedWeakEventListener and CollectionChangedWeakEventListener.
     * If you want to subscribe custome events, then you can use LivetWeakEventListener.
     * When window closing and any timing, Dispose method of LivetCompositeDisposable is useful to release subscribing events.
     *
     * Those events are managed using WeakEventListener, so it is not occurred memory leak, but you should release explicitly.
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var vm = new MainWindowViewModel();
            vm.Todos.Add(new Todo()
            {
                Title = "test1",
                IsDone = true,
                CreationTime = DateTime.Now
            });

            vm.Todos.Add(new Todo()
            {
                Title = "test1",
                IsDone = true,
                CreationTime = DateTime.Now
            });

            this.DataContext = vm;
        }

        /// <summary>
        /// 項目を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //選択項目がない場合は処理をしない
            if (TodoListBox.SelectedItem == null) return;
            TodoListBox.Items.Remove(TodoListBox.SelectedItem);
        }
    }
}
