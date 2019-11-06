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

namespace PokeAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void FindBTN_Click(object sender, RoutedEventArgs e)
        {
            string path = $"https://pokeapi.co/api/v2/pokemon/{pokeTXT.Text}";

            Pokemon pn = new Pokemon();

            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var poke = JsonConvert.DeserializeObject<Abilities>(content);

                    var x = JsonConvert.SerializeObject(poke);
                    foreach (var thing in poke.abilities)
                    {
                        abilitiesLB.Items.Add(pn.ability);
                    }

                }
            }
        }
    }
}
