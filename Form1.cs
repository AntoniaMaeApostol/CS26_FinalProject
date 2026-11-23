using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garage_Door_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            btnMapIt.Click += btnMapIt_Click;
            lstAddressSuggestions.SelectedIndexChanged +=
                lstAddressSuggestions_SelectedIndexChanged;

            httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd(
                "GarageDoorServiceManagement/1.0"
            );
        }
        //this is for the map, it will load the map when the form loads

        private static readonly HttpClient httpClient = new HttpClient();

        private List<AddressResult> addressResults = new();

        private class AddressResult
        {
            public string DisplayName { get; set; } = "";
            public string City { get; set; } = "";
            public string Province { get; set; } = "";
            public string Country { get; set; } = "";
            public string ZipCode { get; set; } = "";
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        private string GetAddressValue(JsonElement address, params string[] keys)
        {
            foreach (string key in keys)
            {
                if (address.TryGetProperty(key, out JsonElement value))
                    return value.GetString() ?? "";
            }

            return "";
        }

        // INITIALIZE MAP
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                await webViewMap.EnsureCoreWebView2Async();

                string html = """
        <!DOCTYPE html>
        <html>
        <head>
            <meta charset="utf-8">
            <meta name="viewport" content="width=device-width, initial-scale=1">

            <link href="https://unpkg.com/maplibre-gl@5.6.1/dist/maplibre-gl.css"
                  rel="stylesheet" />

            <script src="https://unpkg.com/maplibre-gl@5.6.1/dist/maplibre-gl.js"></script>

            <style>
                html, body, #map {
                    margin: 0;
                    width: 100%;
                    height: 100%;
                }
            </style>
        </head>

        <body>
            <div id="map"></div>

            <script>
                const map = new maplibregl.Map({
                    container: 'map',
                    style: 'https://tiles.openfreemap.org/styles/liberty',
                    center: [121.7740, 12.8797],
                    zoom: 5
                });

                map.addControl(new maplibregl.NavigationControl());

                let marker = null;

                window.setMapLocation = function(longitude, latitude) {
                    map.flyTo({
                        center: [longitude, latitude],
                        zoom: 16
                    });

                    if (marker) {
                        marker.remove();
                    }

                    marker = new maplibregl.Marker()
                        .setLngLat([longitude, latitude])
                        .addTo(map);
                };
            </script>
        </body>
        </html>
        """;

                webViewMap.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map initialization error: " + ex.Message);
            }
        }

        // SEARCH ADDRESS
        private async Task SearchAddressAsync()
        {
            string address = txtAddress.Text.Trim();
            string zip = txtZip.Text.Trim();

            string query = $"{address} {zip}".Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Enter an address or ZIP code.");
                return;
            }

            try
            {
                btnMapIt.Enabled = false;
                lstAddressSuggestions.Items.Clear();
                addressResults.Clear();

                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                    "GarageDoorServiceManagement/1.0"
                );

                string url =
                    "https://nominatim.openstreetmap.org/search" +
                    "?format=jsonv2&addressdetails=1&limit=5&q=" +
                    Uri.EscapeDataString(query);

                string response = await httpClient.GetStringAsync(url);

                using JsonDocument document = JsonDocument.Parse(response);

                foreach (JsonElement item in document.RootElement.EnumerateArray())
                {
                    JsonElement details = item.GetProperty("address");

                    var result = new AddressResult
                    {
                        DisplayName = item.GetProperty("display_name").GetString() ?? "",

                        City = GetAddressValue(details,
                            "city", "town", "municipality", "village"),

                        Province = GetAddressValue(details,
                            "state", "province", "region"),

                        Country = GetAddressValue(details, "country"),

                        ZipCode = GetAddressValue(details, "postcode"),

                        Latitude = double.Parse(
                            item.GetProperty("lat").GetString()!,
                            CultureInfo.InvariantCulture),

                        Longitude = double.Parse(
                            item.GetProperty("lon").GetString()!,
                            CultureInfo.InvariantCulture)
                    };

                    addressResults.Add(result);
                    lstAddressSuggestions.Items.Add(result.DisplayName);
                }

                lstAddressSuggestions.Visible = true;

                if (addressResults.Count == 0)
                {
                    MessageBox.Show("No matching addresses found.");
                }
                else if (addressResults.Count == 1)
                {
                    lstAddressSuggestions.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Address search failed: " + ex.Message);
            }
            finally
            {
                btnMapIt.Enabled = true;
            }
        }

        // MAP IT BUTTON
        private async void btnMapIt_Click(object sender, EventArgs e)
        {
            await SearchAddressAsync();
        }

        // SELECT ADDRESS RESULT
        private async void lstAddressSuggestions_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            int index = lstAddressSuggestions.SelectedIndex;

            if (index < 0 || index >= addressResults.Count)
                return;

            AddressResult selected = addressResults[index];

            txtAddress.Text = selected.DisplayName;
            txtCity.Text = selected.City;
            comboState.Text = selected.Province;
            comboCountry.Text = selected.Country;
            txtZip.Text = selected.ZipCode;

            string longitude = selected.Longitude.ToString(
                CultureInfo.InvariantCulture);

            string latitude = selected.Latitude.ToString(
                CultureInfo.InvariantCulture);

            string script = $$"""
    if (window.setMapLocation) {
        window.setMapLocation({{longitude}}, {{latitude}});
    }
    """;


            await webViewMap.ExecuteScriptAsync(script);

            lstAddressSuggestions.Visible = false;
        }


      
        private void label22_Click(object sender, EventArgs e)
        {

        }

    }
}
