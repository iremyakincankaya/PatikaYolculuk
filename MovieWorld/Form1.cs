
using Npgsql;
using System.Diagnostics;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class Form1 : Form
    {

        string cs = "Host=localhost;Port=5433;Username=postgres;Password=postgre;Database=hafta7db";
        NpgsqlConnection con;
        List<Movie> movie = new List<Movie>();
        Movie selectedMovie;
        public Form1()
        {
            con = new NpgsqlConnection(cs);
            con.Open();
            InitializeComponent();
            DisplayMovies();
        }

        private void DisplayMovies()
        {

            var cmd = new NpgsqlCommand("Select * From movies", con);
            var dr = cmd.ExecuteReader();

            movie = new List<Movie>();
            while (dr.Read())
            {
                movie.Add(new Movie()
                {
                    Id = (string)dr["id"],
                    Title = (string)dr["title"],
                    Year = (int)dr["year"],
                    Duration = (string)dr["duration"],
                    Rating = (decimal)dr["rating"],
                    Description = (string)dr["description"]

                });
            }
            dr.Close();

            gridViewMovies.DataSource = movie;
            gridViewMovies.Columns[0].Visible = false;
            gridViewMovies.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void gridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow seciliSatir = gridViewMovies.SelectedRows[0];


        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Seçilen hücrenin indeksini al
            if (gridViewMovies.SelectedRows.Count > 0)
            {
                var selectedRow = gridViewMovies.SelectedRows[0];
                string title = selectedRow.Cells[1].Value.ToString();
                string rating = selectedRow.Cells[4].Value.ToString();
                string description = selectedRow.Cells[5].Value.ToString();
                selectedMovie= (Movie)selectedRow.DataBoundItem;
                labelMovieTable.Text = title;
                labelIMDB.Text = rating + " / 10.0";
                labelDescription.Text = description;
            }
        }

        private void buttonURL_Click(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/58024/open-a-url-from-windows-forms
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.imdb.com/title/" + selectedMovie.Id,
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
