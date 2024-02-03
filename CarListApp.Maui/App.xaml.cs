﻿using CarListApp.Maui.Models;
using CarListApp.Maui.Services;

namespace CarListApp.Maui
{
    public partial class App : Application
    {
        public static UserInfo UserInfo;

        public static CarService CarService { get; private set; }
        

        public App(CarService carService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            CarService = carService;
        }
    }
}
