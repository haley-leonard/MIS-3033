using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //https://pokeapi.co/api/v2/pokemon/?offset=0&limit=964

            using (HttpClient client = new HttpClient())
            {



                string url = @"https://pokeapi.co/api/v2/pokemon/?offset=0&limit=964";

                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    //for (int i = 1; i <= 964; i++)
                    //{
                    var content = response.Content.ReadAsStringAsync().Result;
                    var stuff = JsonConvert.DeserializeObject<Results>(content);

                    foreach (var result in stuff.results)
                    {
                        pokeLST.Items.Add(result);
                    }

                    //pokeLST.Items.Add(pn.name);
                    //}
                }

            }
        }

        private void getPokemonBTN_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void getAbilities_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = ((Result)pokeLST.SelectedItem);
            using (HttpClient client = new HttpClient())
            {
             

                HttpResponseMessage response = client.GetAsync(selectedItem.url).Result;
                if (response.IsSuccessStatusCode)
            {
              
                var content = response.Content.ReadAsStringAsync().Result;
                var stuff = JsonConvert.DeserializeObject<pokemon>(content);

                
                    abilitiesTXT.Text=stuff.ToString();
                

            }
            }
        }
    }
}
