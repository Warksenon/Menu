using Newtonsoft.Json;
using Pizza.Presenters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pizza
{

    public class SaveFiles : ISaveHistory, IAddOrder
    {
        const string _path = @"c:\SQL\Konsola\sqlite\Historia zamówień.txt";
        Order order;
        List<Order> listOrder;

        public SaveFiles(Order order)
        {
            this.order = order;
        }

        public SaveFiles(List<Order> listOrder)
        {
            this.listOrder = listOrder;
        }


        private void SaveListOrder()
        {
            try
            {
                var customer = listOrder;
                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (var writer = new StreamWriter(_path, false))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zapisanie do pilku txt nie powiodło się ", "Błąd przy zapisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecordOfExceptions.Save(Convert.ToString(ex), "SaveFiles");
            }
        }

        private void Save()
        {
            try
            {
                var customer = order;
                var jsonToWrite = JsonConvert.SerializeObject(customer, Formatting.Indented);

                using (StreamWriter streamW = new StreamWriter((_path), true))
                {
                    
                    streamW.WriteLine(jsonToWrite);
                    streamW.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zapisanie do pilku txt nie powiodło się ", "Błąd przy zapisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecordOfExceptions.Save(Convert.ToString(ex), "Save");
            }
        }

        public void SaveHistoryOrders()
        {
            SaveListOrder();
        }

        public void AddOrder()
        {
            Save();
        }
    }
}

