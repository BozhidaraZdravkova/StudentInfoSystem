using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;



namespace WpfExample
{
    class MainWindowViewModel
    {

        private ICommand hiButtonCommand;
        private ICommand toggleExecuteCommand
        { get; set; }
        private bool canExecute = true;
       // public event PropertyChangedEventHandler PropertyChanged;
        public string HiButtonContent
        {
            get { return "click to hi"; }

        }
       /* private string TextBoxContent;
        public string _TextBoxContent
        {
            get { return TextBoxContent; }
            set
            {
                TextBoxContent = value;
                PropChanged("_TextBoxContent");
            }
        }*/
        public bool CanExecute
        {
            get { return this.canExecute; }
            set
            {
                if (this.canExecute == value)
                { return; }
                this.canExecute = value;
            }
        }
        public ICommand ToggleExecuteCommand
        {
            get
            { return toggleExecuteCommand; }
            set
            { toggleExecuteCommand = value; }
        }
        public ICommand HiButtonCommand
        {
            get
            { return hiButtonCommand; }
            set
            { hiButtonCommand = value; }
        }
        public MainWindowViewModel()
        {
            HiButtonCommand = new RelayCommand(ShowMessage, param => this.canExecute);
            toggleExecuteCommand = new RelayCommand(ChangeCanExecute);
        }
       public void ShowMessage(object obj)
        {
            //it is good we do this with binding to some control 
            //System.Windows.MessageBox.Show(obj.ToString());
        }
        public void ChangeCanExecute(object obj)
        {
            canExecute = !canExecute;
        }
      /*  public void PropChanged(String propertyName)
        {

            if (PropertyChanged != null)
            {

                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }*/

    }
}
