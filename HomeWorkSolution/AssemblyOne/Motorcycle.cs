using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AssemblyOne
{
    public class Motorcycle
    {
        private const int StartSpeed = 0;
        protected int _deltaSpeed;
        private Color _baseColor = Color.Gray;
        private int _currentSpeed;
        private Guid _vinNumber;
        private Color _color;

        public Motorcycle(Guid vinNumber)
        {
            this._currentSpeed = StartSpeed;
            this._vinNumber = vinNumber;
            this._color = _baseColor;
            this._deltaSpeed = 5;
        }

        public Motorcycle(Guid vinNumber, Color color)
            : this(vinNumber)
        {
            this._color = color;
        }

        public void Accelerate()
        {
            this._currentSpeed += _deltaSpeed;
        }

        internal void AccelerateInternal()
        {
            this._currentSpeed += _deltaSpeed + 1;
        }

        protected internal void AccelerateProtectedInternal()
        {
            this._currentSpeed += _deltaSpeed + 1;
        }

        public void ChangeColor(Color color)
        {
            this._color = color;
        }

        public int CurrentSpeed
        {
            get { return this._currentSpeed; }
        }

        public Color CurrentColor
        {
            get { return this._color; }
        }

        public Guid VinNumber
        {
            get { return this._vinNumber; }
        }

        public void Break()
        {
            this._currentSpeed = StartSpeed;
        }

        private protected void ReverseSpeed()
        {
            _currentSpeed = _currentSpeed * - 1;
        }
    }
}
