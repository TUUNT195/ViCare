//====================================================================================================
// Base code generated with Inertia: BE Gen (Build 2.5.5044.27855)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by ThienLoi at KHANHND-LAPTOP on 08/29/2014 15:43:24 
//====================================================================================================

using System;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace ViHISSrv.Entities
{
    /// <summary>
    /// Base entity class.
    /// </summary>
    [Serializable]
    [DataContract]
    public class EntityBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raise the ProperChanged event when the value in property changes.
        /// </summary>
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Displays the values of the properties for debugging purposes.
        /// </summary>
        public override string ToString()
        {
            return this.GetType().Name + ": " +
                string.Join(",", this.GetType().GetProperties()
                .Where(p => !p.PropertyType.IsGenericType && !p.PropertyType.IsArray)
                .Select(p => string.Format("{0}={1}", p.Name, p.GetValue(this, null))));
        }




    }
}
