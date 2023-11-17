using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public partial class FormHome : Form
    {
        private User user;
        private Arbol books;
        private Book SelectedBook;

        private Lista registro;
        public FormHome()
        {
            InitializeComponent();
        }
        
        private void FormHome_Load(object sender, EventArgs e)
        {
            user = UserManager.CurrentUser;
            books = BookManager.CurrentBooks;
            registro = RegistroManager.CurrentRegister;

            tabPage1.Text = "Inicio";
            tabPage2.Text = "Reservas";
            
            userLabel.Text = user.name;
            
            books.ChargeData();
            ReserveManager.CurrentReserves.ChargeData();
            registro.ChargeData();
            
            reservesDGV.Rows.Clear();
            BooksDGV.Rows.Clear();
            registerDGV.Rows.Clear();
            books.PostOrden(books.raiz, BooksDGV);
            ReserveManager.CurrentReserves.MostrarDGV(reservesDGV);
            registro.imprimirDGV(registerDGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = BooksDGV.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string title = BooksDGV.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
            string description = BooksDGV.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            string author = BooksDGV.Rows[e.RowIndex].Cells["Autor"].Value.ToString();
            string publication = BooksDGV.Rows[e.RowIndex].Cells["Publicacion"].Value.ToString();
            string cover = BooksDGV.Rows[e.RowIndex].Cells["Cover"].Value.ToString();
            string gender = BooksDGV.Rows[e.RowIndex].Cells["Genero"].Value.ToString();

            SelectedBook = new Book(id, title, description, author, publication, cover, gender);

            // Descargar la imagen desde la URL
            try
            {
                WebClient webClient = new WebClient();
                byte[] data = webClient.DownloadData(cover);
                webClient.Dispose();

                // Crear un flujo de memoria desde los datos descargados
                using (MemoryStream stream = new MemoryStream(data))
                {
                    // Crear un objeto de imagen desde el flujo de memoria
                    Image image = Image.FromStream(stream);

                    TitleBookLabel.Text = SelectedBook.Title;
                    authorLabel.Text = SelectedBook.Author;
                    publisherLabel.Text = SelectedBook.Publication;
                    descriptionLabel.Text = SelectedBook.Description;
                    genderLabel.Text = SelectedBook.Gender;
                    bookImage.Image = image;
                    bookImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    // Asignar la imagen al PictureBox
                    bookImage.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAgregarBook formAgregarBook = new FormAgregarBook(books.size);

            DialogResult result = formAgregarBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                // El usuario hizo clic en "Aceptar" en Form2
                Book valorRetornado = formAgregarBook.book;
                books.Insert(ref books.raiz,valorRetornado);
                books.SaveInPlaneFile(valorRetornado);
                BooksDGV.Rows.Clear();
                books.PostOrden(books.raiz, BooksDGV);
                Registro log = new Registro($"Se agrego el libro: {valorRetornado.Title}");
                registro.InsertarAlFinal(log);
                registro.SaveInPlaneFile(log);
                registro.imprimirDGV(registerDGV);
            }
            else
            {
                // El usuario canceló la operación en Form2
                label1.Text = "Operación cancelada desde Form2.";
            }
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            FormReserveBook formReserveBook = new FormReserveBook(SelectedBook);
            
            DialogResult result = formReserveBook.ShowDialog();
                
            if (result == DialogResult.OK)
            {
                // El usuario hizo clic en "Aceptar" en Form2
                Reserve valorRetornado = formReserveBook.reserve;
                ReserveManager.CurrentReserves.Encolar(valorRetornado);
                reservesDGV.Rows.Clear();
                ReserveManager.CurrentReserves.MostrarDGV(reservesDGV);
                ReserveManager.CurrentReserves.SaveInPlaneFile(valorRetornado);
                Registro log = new Registro($"Se reservo un libro: {valorRetornado.book}");
                registro.InsertarAlFinal(log);
                registro.SaveInPlaneFile(log);
                registro.imprimirDGV(registerDGV);
            }
            else
            {
                // El usuario canceló la operación en Form2
                label1.Text = "Operación cancelada desde Form2.";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void searchBook_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(inputTitleSearch.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de un libro");
            }
            else
            {
                Book book = books.SearchByTitle(inputTitleSearch.Text);

                if (book == null)
                {
                    Registro log = new Registro($"Se reservo un libro: {inputTitleSearch.Text} ALERT: NO SE ENCONTRO");
                    registro.InsertarAlFinal(log);
                    registro.SaveInPlaneFile(log);
                    registro.imprimirDGV(registerDGV);
                    MessageBox.Show("No se encontro el libro");
                    return;
                }
                
                MessageBox.Show($"Se encontro el libro {book.Title}");

                // Descargar la imagen desde la URL
                try
                {
                    WebClient webClient = new WebClient();
                    byte[] data = webClient.DownloadData(book.Cover);
                    webClient.Dispose();

                    // Crear un flujo de memoria desde los datos descargados
                    using (MemoryStream stream = new MemoryStream(data))
                    {
                        // Crear un objeto de imagen desde el flujo de memoria
                        Image image = Image.FromStream(stream);

                        TitleBookLabel.Text = book.Title;
                        authorLabel.Text = book.Author;
                        publisherLabel.Text = book.Publication;
                        descriptionLabel.Text = book.Description;
                        bookImage.Image = image;
                        bookImage.SizeMode = PictureBoxSizeMode.Zoom;
                        // Asignar la imagen al PictureBox
                        bookImage.Image = image;
                        SelectedBook = book;
                    }
                    Registro log = new Registro($"Se reservo un libro: {inputTitleSearch.Text} SE ENCONTRO CORRECTAMENTE");
                    registro.InsertarAlFinal(log);
                    registro.SaveInPlaneFile(log);
                    registro.imprimirDGV(registerDGV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }
    }
}