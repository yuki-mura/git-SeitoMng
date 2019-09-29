using SeitoMng.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Helpers;


namespace SeitoMng.ViewModels
{
    public class ViewModelSeito
    {
        private Seito _model;

        public ViewModelSeito(Seito model = null) => model = model ?? new Seito();

        public Seito Model
        {
            get => _model;
            set
            {
                if (_model != value)
                {
                    _model = value;

                }
            }
        }

    }
}