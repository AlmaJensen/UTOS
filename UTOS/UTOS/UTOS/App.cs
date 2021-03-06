﻿using Akavache;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTOS.PageModels;
using UTOS.Services;
using Xamarin.Forms;
using Xamarin.Forms.Themes;

namespace UTOS
{
    public class App : Application
    {
        public App()
        {
            
            FreshIOC.Container.Register<IDataService, DataService>();
            FreshIOC.Container.Register<IDataManager, DataManager>();

            var masterDetail = new FreshMasterDetailNavigationContainer();
            var detail = FreshPageModelResolver.ResolvePageModel<AllSessionsPageModel>();
            masterDetail.Detail = new FreshNavigationContainer(detail);
            var master = FreshPageModelResolver.ResolvePageModel<MenuPageModel>();
            master.Title = "UTOS";
            masterDetail.Master = master;
            MainPage = masterDetail;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
