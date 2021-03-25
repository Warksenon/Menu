using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pizza
{

    public class SaveFiles : ISaveHistory
    {
        const string _path = @"c:\SQL\Konsola\sqlite\Historia zamówień.txt";

        private void SaveListOrder(List<Order> listOrder)
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

        private void Save(Order order)
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

        public void SaveHistoryOrders(List<Order> listOrder)
        {
            throw new NotImplementedException();
        }
    }
}

