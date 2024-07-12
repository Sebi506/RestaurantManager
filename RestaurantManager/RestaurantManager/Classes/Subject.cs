using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Classes
{
    internal class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyAll(object sender, EventArgs e,string tableName)
        {
            foreach (var observer in observers)
            {
                observer.OnDataChanged(sender, e);
            }
            ShowNotification(tableName + " a fost modificata!");
        }
        protected void ShowNotification(string message)
        {
            MessageBox.Show(message, "Notificare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
