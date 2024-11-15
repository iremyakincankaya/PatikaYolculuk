namespace MovieWorld
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gridViewMovies = new DataGridView();
            labelMovieTable = new Label();
            labelIMDB = new Label();
            labelDescription = new Label();
            buttonURL = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewMovies).BeginInit();
            SuspendLayout();
            // 
            // gridViewMovies
            // 
            gridViewMovies.AllowUserToAddRows = false;
            gridViewMovies.AllowUserToDeleteRows = false;
            gridViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewMovies.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMovies.Location = new Point(38, 12);
            gridViewMovies.Name = "gridViewMovies";
            gridViewMovies.ReadOnly = true;
            gridViewMovies.RowHeadersVisible = false;
            gridViewMovies.RowHeadersWidth = 51;
            gridViewMovies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewMovies.Size = new Size(953, 352);
            gridViewMovies.TabIndex = 0;
            gridViewMovies.CellContentClick += gridViewMovies_CellContentClick;
            // 
            // labelMovieTable
            // 
            labelMovieTable.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelMovieTable.Location = new Point(38, 382);
            labelMovieTable.Name = "labelMovieTable";
            labelMovieTable.Size = new Size(310, 192);
            labelMovieTable.TabIndex = 1;
            labelMovieTable.Text = "Movie Title";
            labelMovieTable.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelIMDB
            // 
            labelIMDB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelIMDB.Location = new Point(38, 574);
            labelIMDB.Name = "labelIMDB";
            labelIMDB.Size = new Size(176, 66);
            labelIMDB.TabIndex = 2;
            labelIMDB.Text = "IMDB";
            labelIMDB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            labelDescription.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelDescription.Location = new Point(354, 401);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(222, 239);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Description";
            labelDescription.TextAlign = ContentAlignment.BottomLeft;
            // 
            // buttonURL
            // 
            buttonURL.Location = new Point(663, 614);
            buttonURL.Name = "buttonURL";
            buttonURL.Size = new Size(273, 29);
            buttonURL.TabIndex = 4;
            buttonURL.Text = "Film IMDB Sayfasına Git";
            buttonURL.UseVisualStyleBackColor = true;
            buttonURL.Click += buttonURL_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 678);
            Controls.Add(buttonURL);
            Controls.Add(labelDescription);
            Controls.Add(labelIMDB);
            Controls.Add(labelMovieTable);
            Controls.Add(gridViewMovies);
            Name = "Form1";
            Text = "Movie World";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)gridViewMovies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridViewMovies;
        private Label labelMovieTable;
        private Label labelIMDB;
        private Label labelDescription;
        private Button buttonURL;
    }
}
