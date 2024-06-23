using laba_6.Classes.Paterns;
using laba_6;
using Microsoft.EntityFrameworkCore;
using laba_6.Classes.PC_SetUp;

namespace SuperCat.Paterns
{
    internal class MyUnitOfWork : IMyUnitOfWorck
    {
        private readonly DbContext _context;
        public MyRepository<Configurator> userRepository;
        private bool disposed = false;

        public MyUnitOfWork(DbContext context)
        {
            _context = context;
            userRepository = new MyRepository<Configurator>(_context);
        }

        public IRepository<Configurator> Repository
        {
            get
            {
                if (userRepository == null)
                    userRepository = new MyRepository<Configurator>(_context);
                return userRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}