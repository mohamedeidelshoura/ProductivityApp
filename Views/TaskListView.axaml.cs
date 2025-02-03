using Avalonia.Controls;
using ProductivityApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityApp.Views
{
    public partial class TaskListView : UserControl
    {
        public TaskListView()
        {
            InitializeComponent();
            this.DataContext = new TaskListViewModel(); // تأكد من تعيين الـ ViewModel هنا
        }
    }

}
