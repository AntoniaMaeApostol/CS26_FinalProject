namespace Garage_Door_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            </script>
        </body>
        </html>
        """;

                webViewMap.NavigateToString(html);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Map error: " + ex.Message);
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
