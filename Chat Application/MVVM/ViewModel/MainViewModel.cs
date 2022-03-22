using Chat_Application.MVVM.Model;
using System;
using System.Collections.ObjectModel;

namespace Chat_Application.MVVM.ViewModel
{
    internal class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
            {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Allison",
                UsernameColor = "#409aff",
                ImageSource = "https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg",
                Message = "Test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            }) ; 

            for(int i=0;i<3;i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Allison",
                    UsernameColor = "#409aff",
                    ImageSource = "https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false
                });
            }
            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Bunny",
                    UsernameColor = "#409aff",
                    ImageSource = "https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg",
                    Message = "Test",
                    Time = DateTime.Now,
                    IsNativeOrigin = true

                });
            }
                    Messages.Add(new MessageModel
                    {
                        Username = "Bunny",
                        UsernameColor = "#409aff",
                        ImageSource = "https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg",
                        Message = "Last",
                        Time = DateTime.Now,
                        IsNativeOrigin = true
                    });

                for (int i = 0; i < 5; i++)
                {
                Contacts.Add(new ContactModel
                {
                    UserName = $"Allison {i}" ,
                    ImageSource = "https://t3.ftcdn.net/jpg/03/46/83/96/360_F_346839683_6nAPzbhpSkIpb8pmAwufkC7c5eD7wYws.jpg" ,
                    Messages = Messages
                });
                }
                
            }
        }
    }

