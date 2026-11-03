using System;
using System.Collections.Specialized;
using Wisej.Web;
using TEKSOLPRIME6.Login.Pages;


namespace TEKSOLPRIME6
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">Arguments from the URL.</param>
        static void Main(NameValueCollection args)
        {
           LoginPage loginPage = new LoginPage();
           loginPage.Show();
        }
    }
}