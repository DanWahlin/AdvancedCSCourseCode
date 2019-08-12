using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter4.Interfaces
{
    public class Employee : IComparable, IComparable<Employee>, IEquatable<Employee>,ICloneable,
        IDisposable
    {

        private string _FirstName;
        private string _Department;
        private Address _Address;
        private bool _Disposed;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }

        public Address Address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }
	
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Employee emp = obj as Employee;
            if (emp != null)
            {
                return this.FirstName.CompareTo(emp.FirstName);
            }
            throw new ApplicationException("Can only compare Employee types!");
        }
        #endregion

        #region IComparable<Employee> Members

        public int CompareTo(Employee other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        #endregion

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Employee);
        }

        #region IEquatable<Employee> Members

        public bool Equals(Employee other)
        {
            if (other == null) return false;
            return (other.Department == this.Department);
        }

        #endregion

        #region ICloneable Members

        public object Clone()
        {
            //Deep clone
            Employee emp = new Employee();
            emp.FirstName = this.FirstName;
            emp.Department = this.Department;
            Address addr = new Address();
            addr.City = this.Address.City;
            addr.State = this.Address.State;
            addr.Street = this.Address.Street;
            emp.Address = addr;
            return emp;
        }

        public override string ToString()
        {
            return String.Format(base.ToString() + " FirstName {0}, Department: {1}", this.FirstName, this.Department);
        }

        #endregion
        // Dispose(bool disposing) executes in two distinct scenarios.
        // 1. If disposing equals true, the method has been called directly
        // or indirectly by a user's code. Managed and unmanaged resources
        // can be disposed.
        // 2. If disposing equals false, the method has been called by the
        // runtime from inside the finalizer and you should not reference
        // other objects. Only unmanaged resources can be disposed.
        public void Dispose(bool disposing)
        {
            if (!this._Disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources.
                    this.Address = null;
                }

                // Call the appropriate methods to clean up
                // unmanaged resources here.
                // If disposing is false,
                // only the following code is executed.

                this._Disposed = true;
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }

        #endregion
    }
}
