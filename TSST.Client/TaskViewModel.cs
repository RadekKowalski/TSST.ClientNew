using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSST.Client
{

    public enum TaskState { ToDo, InProgress, Complete }
    public class TaskViewModel
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime CompleteDate { get; set; }

        public TaskState State { get; set; }

        public int UserId { get; set; }

        public ICollection<FileViewModel> Files { get; set; }


        public TaskViewModel()
        {
            Id = 1;
            CreationDate = DateTime.Now;
            CompleteDate = DateTime.Now;
            State = TaskState.ToDo;
            Files = new List<FileViewModel>();
        }
        public TaskViewModel(string Title, string Description, DateTime CreationDate, int UserId):this()
        {
            this.Title = Title;
            this.Description = Description;
            this.CreationDate = CreationDate;
            this.UserId = UserId;
        }
    }
}
