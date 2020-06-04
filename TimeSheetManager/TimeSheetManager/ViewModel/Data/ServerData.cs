using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeSheetManager.Model;

namespace TimeSheetManager.ViewModel.Data
{
    public class ServerData
    {
        public enum ActionType
        {
            INSERT, UPDATE, DELETE
        }
        static string url = ConfigurationManager.AppSettings["ServiceAdr"];
        public static async Task<List<Table>> GetTablesAsync()
        {

            List<Table> tables = null;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = httpClient.GetAsync(url + "GetItems").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        string tablesJson = await response.Content.ReadAsStringAsync();
                        tables = JsonConvert.DeserializeObject<List<Table>>(tablesJson);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return tables;
        }

        public static bool ModifyTable(Table Table, ActionType type)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string TableJson = JsonConvert.SerializeObject(Table);
                    StringContent data = new StringContent(TableJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = null;
                    switch (type)
                    {
                        case ActionType.INSERT:
                            response = httpClient.PostAsync(url + "Create", data).Result;
                            break;
                        case ActionType.UPDATE:
                            response = httpClient.PutAsync(url + "Update", data).Result;
                            break;
                        case ActionType.DELETE:
                            TableJson = JsonConvert.SerializeObject(Table.Id);
                            data = new StringContent(TableJson, Encoding.UTF8, "application/json");
                            response = httpClient.PutAsync(url + "Delete", data).Result;
                            break;
                    }
                    return response.IsSuccessStatusCode;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return false;
            }
        }


    }
}
