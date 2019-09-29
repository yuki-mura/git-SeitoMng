using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeitoMng.ViewModels
{
    public class ViewModelMain
    {
        public ObservableCollection<ViewModelSeito> Seitos{ get; }
            = new ObservableCollection<ViewModelSeito>();
    }
}
