using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.ViewModel
{
    internal interface IBaseViewModel
    {
        public bool IsBusy { get; }

        public bool IsInitialized { get; set; }

        Task InitializeAsync();
    }
}
