using laba_6.Classes.PC_SetUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6.Classes.Paterns
{
    internal interface IMyUnitOfWorck: IDisposable
    {
        IRepository<Configurator> Repository { get; }
        void Save();
    }
}
