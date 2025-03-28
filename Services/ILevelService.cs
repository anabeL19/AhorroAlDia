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

    public interface ILevelService
    {
        Task<LevelResponseV1[]> GetLevels();
    }

}
