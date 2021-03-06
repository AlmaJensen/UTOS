﻿using FreshMvvm;
using PropertyChanged;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UTOS.DataModels;
using UTOS.Services;
using Xamarin.Forms;
using System.Linq;
using UTOS.Helpers;
using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.ComponentModel;

namespace UTOS.PageModels
{
    [ImplementPropertyChanged]
    public class AllSessionsPageModel : FreshBasePageModel, INotifyPropertyChanged
    {
        private IDataManager dataManager;
        private List<SessionDM> completeList = new List<SessionDM>();
        ScheduleHelper helper = new ScheduleHelper();

        public List<string> Days { get; set; }
        public List<string> Tracks { get; set; }

        private string _selectedTrack;

        public string SelectedTrack
        {
            get { return _selectedTrack; }
            set {
                _selectedTrack = value;
                FilterSessions();
            }
        }

        private string _selectedDay;

        public string SelectedDay
        {
            get { return _selectedDay; }
            set {
                _selectedDay = value;
                FilterSessions();
            }
        }

        private void FilterSessions()
        {
            var sessions = completeList;
            if (!string.IsNullOrEmpty(SelectedDay))
                sessions = helper.FilterSessionsByDay(SelectedDay, sessions).ToList();
            if (!string.IsNullOrEmpty(SelectedTrack))
                sessions = helper.FilterSessionsByTrack(SelectedTrack, sessions).ToList();
            if (!string.IsNullOrEmpty(SearchText))
                sessions = helper.FilterSessionsBySearch(SearchText, sessions).ToList();
            Sessions.Clear();
            var sorted = helper.SessionGrooper(sessions);
            foreach (var s in sorted)
                Sessions.Add(s);
        }

        public AllSessionsPageModel(IDataManager dataService)
        {
            dataManager = dataService;
        }

        public override void Init(object initData)
        {
            base.Init(initData);
            LoadCollection();
        }

        private async void LoadCollection()
        {
            var talks = await dataManager.GetAllSessions();
            Sessions = new ObservableCollection<GroupingModel>(helper.SessionGrooper(talks));
            completeList = talks.ToList();
            Days = helper.GetDaysFromSchedule(talks).ToList();
            Tracks = helper.GetTracksFromSchedule(talks).ToList();
        }

        SessionDM _selectedEntry;
        public SessionDM SelectedEntry
        {
            get
            {
                return _selectedEntry;
            }
            set
            {
                _selectedEntry = value;
                if (value != null)
                    EntrySelected.Execute(value);
                _selectedEntry = null;
            }
        }

        public Command<SessionDM> EntrySelected
        {
            get
            {
                return new Command<SessionDM>(async (talk) => {
                    await CoreMethods.PushPageModel<TalkDetailPageModel>(talk);
                });
            }
        }
        public string SearchText { get; set; }
        public Command SearchCommand
        {
            get
            {
                return new Command<SessionDM>((sender) => {
                    FilterSessions();
                });
            }
        }

        public Command ResetCommand
        {
            get
            {
                return new Command((sender) => {
                    SelectedDay = null;
                    SelectedTrack = null;
                    SearchText = null;
                    Sessions.Clear();
                    var sorted = helper.SessionGrooper(completeList);
                    foreach (var s in sorted)
                        Sessions.Add(s);
                });
            }
        }
        public ObservableCollection<GroupingModel> Sessions { get; set; } = new ObservableCollection<GroupingModel>();
    }
}
