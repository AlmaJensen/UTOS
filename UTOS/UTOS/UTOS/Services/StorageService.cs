﻿using Akavache;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTOS.DataModels;
using System.Reactive.Linq;

namespace UTOS.Services
{
    public class StorageService : IStorageService
    {
        public StorageService()
        {
            BlobCache.ApplicationName = "UTOS";
            BlobCache.EnsureInitialized();
        }
        private enum StorageKeys { UserSchedule, LastCacheDate, CompleteSchedule, UserScheduleID}
        public void UpdateCachedSessions(GeneralScheduleDM sessions)
        {
            BlobCache.LocalMachine.Invalidate(StorageKeys.CompleteSchedule.ToString());
            BlobCache.LocalMachine.InsertObject(StorageKeys.CompleteSchedule.ToString(), sessions);

        }
        public async Task<GeneralScheduleDM> GetCachedSessions()
        {
            try
            {
                var response = await BlobCache.LocalMachine.GetObject<GeneralScheduleDM>(StorageKeys.CompleteSchedule.ToString());
                return response;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
            
        }
    }
}
