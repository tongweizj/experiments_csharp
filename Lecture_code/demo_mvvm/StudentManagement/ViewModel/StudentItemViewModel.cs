using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.ViewModel
{
    public class StudentItemViewModel : ViewModelBase
    {
        private readonly Student _model;

        public StudentItemViewModel(Student model)
        {
            _model = model;
        }

        public int Id => _model.Id;

        public string? FirstName
        {
            get => _model.FirstName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChanged();
            }
        }

        public string? LastName
        {
            get => _model.LastName;
            set
            {
                _model.LastName = value;
                RaisePropertyChanged();
            }
        }

        public string? Program
        {
            get => _model.Program;
            set
            {
                _model.Program = value;
                RaisePropertyChanged();
            }
        }
    }
}

