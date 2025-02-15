﻿using Caliburn.Micro;
using System;
using System.Threading.Tasks;

namespace TRMDesktopUI.ViewModels
{
    public class LoginViewModel : Screen
    {
        private IEventAggregator _events;
        private string _userName = "trm@trm.com";
        private string _password = "Qwe123.";
        private string _errorMessage;

        public LoginViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public bool IsErrorVisible
        {
            get
            {
                bool output = false;

                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UserName);
                NotifyOfPropertyChange(() => CanLogIn);
            }
        }

        public bool CanLogIn
        {
            get
            {
                bool output = false;

                if (UserName?.Length > 0 && Password?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public async Task LogIn()
        {
            try
            {
                ErrorMessage = "";

                // TODO Capture more info on User
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}