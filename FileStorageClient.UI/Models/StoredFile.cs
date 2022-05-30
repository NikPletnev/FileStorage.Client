using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FileStorageClient.UI.Models
{
    public class StoredFile : INotifyPropertyChanged
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        //private byte[] _data;

        //public byte[] Data
        //{
        //    get { return _data; }
        //    set
        //    {
        //        _data = value;
        //        OnPropertyChanged(nameof(Data));
        //    }
        //}

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _size;

        public int Size
        {
            get { return _size; }
            set
            {
                _size = value;
                OnPropertyChanged(nameof(Size));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
