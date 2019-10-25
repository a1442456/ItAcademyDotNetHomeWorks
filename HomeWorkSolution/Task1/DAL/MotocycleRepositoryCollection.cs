using Loger;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DAL
{
    class MotocycleRepositoryCollection : IMotocycleRepository
    {
        IList<Motocycle> _motos;
        private LogWorker loger = new LogWorker();
        public MotocycleRepositoryCollection(IList<Motocycle> motos)
        {
            _motos = motos;
        }
        public void CreateMotocycle(Motocycle moto)
        {
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            loger.TypeInLogFile("Creating motocycle", LogStatus.INFO);
            _motos.Add(moto);
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        public void DeleteMotocycle(int id)
        {
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            loger.TypeInLogFile("Deleting motocycle", LogStatus.INFO);
            
            foreach (Motocycle moto in _motos)
            {
                if (moto.ID == id)
                    _motos.Remove(moto);
            }
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        public Motocycle GetMotocycle(int id)
        {
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            loger.TypeInLogFile("Getting motocycle", LogStatus.INFO);
            
            foreach (Motocycle moto in _motos)
            {
                if (moto.ID == id)
                {
                    loger.TypeInLogFile($"Exiting: {currentMethodName}");
                    return moto;
                }
            }
            throw new Exception("No such ID");
        }

        public void UpdateMotoCycleModel(int id, string model)
        {
            string currentMethodName = GetMethodName();
            loger.TypeInLogFile($"Entering to: {currentMethodName}");
            loger.TypeInLogFile("Updating motocycle", LogStatus.INFO);
            
            foreach (Motocycle moto in _motos)
            {
                if (moto.ID == id)
                {
                    moto.Model = model;
                }
            }
            loger.TypeInLogFile($"Exiting: {currentMethodName}");
        }

        private string GetMethodName()
        {
            StackTrace st = new StackTrace();
            StackFrame sf;
            string methodName = "Default method name";
            if (st.FrameCount != 0)
            {
                sf = st.GetFrame(1);
                methodName = sf.GetMethod().Name;
            }
            return methodName;
        }
    }
}
