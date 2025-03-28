using Android.Mtp;
using System.Net.Http.Headers;
using SmartSave.Constantes;
using SmartSave.Model.SavingsGoal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartSave.Tools.Helpers;
using Newtonsoft.Json;

namespace SmartSave.Services
{

    public class LevelService: ILevelService
    {
        private readonly AppConstants _constants;

        public LevelService(AppConstants constants)
        {
            _constants = constants;
        }

        public async Task<LevelResponseV1[]> GetLevels()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(_constants.UrlBase);
                var uri = UriHelper.CombineUri(_constants.UrlBase, $"{_constants.LevelController}");
                var response = await client.GetAsync(uri);
                var result = await response.Content.ReadAsStringAsync();
                var obj = JsonConvert.DeserializeObject<LevelResponseV1[]>(result);
                return obj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

}
