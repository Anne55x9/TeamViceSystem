using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TeamViceSystem.Model;

namespace TeamViceSystem.Facade
{
    public class FacadeService
    {

        private const string serverUrl = "http://01vicewebservice20170511065111.azurewebsites.net";

        public static async Task<ObservableCollection<AppartmentAssignment>> GetAppartAssignOverview()
        {
            ObservableCollection<AppartmentAssignment> tempList = new ObservableCollection<AppartmentAssignment>();

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Clear();
                client.BaseAddress = new Uri(serverUrl);

                try
                {
                    HttpResponseMessage response = await client.GetAsync("api/Appartments");

                    if (response.IsSuccessStatusCode)
                    {
                        tempList = await response.Content.ReadAsAsync<ObservableCollection<AppartmentAssignment>>();
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.Write($"Exception: {e}");
                    tempList = null;

                }

                return tempList;
            }
           
        }

    }
}
