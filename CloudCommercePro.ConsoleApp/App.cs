using CloudCommercePro.ConsoleApp.Messages;
using CloudCommercePro.Interfaces;
using CloudCommercePro.Models.DataModels;
using CloudCommercePro.Models.ViewModels;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCommercePro.ConsoleApp
{
    internal class App
    {
        private readonly IConfiguration _config;
        private readonly IContactRepository _contactRepository;
        public App(IConfiguration config, IContactRepository contactRepository)
        {
            _config = config;
            _contactRepository = contactRepository;
        }
        public void Run()
        {
            var logDirectory = _config.GetValue<string>("Runtime:LogOutputDirectory");

            // Display a greeting
            ConsoleMessages.Greeting();

            // Display Caveat
            ConsoleMessages.CaveatMessage();

            // Display Dev Messages
            ConsoleMessages.DevMessages();

            // Get the CSV
            List<DataContacts> contactViewModels = _contactRepository.Get();
            string output = JsonConvert.SerializeObject(contactViewModels);
            Console.WriteLine(output);

            Console.WriteLine("Press Enter key to close");
            Console.ReadLine();
        }
    }
}
