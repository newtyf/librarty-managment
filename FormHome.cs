using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public partial class FormHome : Form
    {
        private User user;
        private Arbol books;
        private Book SelectedBook;
        public FormHome()
        {
            InitializeComponent();
        }
        
        private void FormHome_Load(object sender, EventArgs e)
        {
            user = UserManager.CurrentUser;
            books = BookManager.CurrentBooks;

            tabPage1.Text = "Inicio";
            tabPage2.Text = "Reservas";
            
            userLabel.Text = user.name;
            
            books.ChargeData();
            BooksDGV.Rows.Clear();
            books.PostOrden(books.raiz, BooksDGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = BooksDGV.Rows[e.RowIndex].Cells["id"].Value.ToString();
            string title = BooksDGV.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
            string description = BooksDGV.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
            string author = BooksDGV.Rows[e.RowIndex].Cells["Autor"].Value.ToString();
            string publication = BooksDGV.Rows[e.RowIndex].Cells["Publicacion"].Value.ToString();

            SelectedBook = new Book(id, title, description, author, publication);
            
            if (e.ColumnIndex == BooksDGV.Columns["Reservar"].Index)
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
                }
                else
                {
                    // El usuario canceló la operación en Form2
                    label1.Text = "Operación cancelada desde Form2.";
                }
            }
            else
            {
                
                TitleBookLabel.Text = SelectedBook.Title;
                authorLabel.Text = SelectedBook.Author;
                publisherLabel.Text = SelectedBook.Publication;
                descriptionLabel.Text = SelectedBook.Description;
                Image imagen = Image.FromFile(@"C:\Users\AXEL\Pictures\Por-que-Shinji-no-envejece-en-Evangelion-min.png");
                bookImage.Image = imagen;
                bookImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAgregarBook formAgregarBook = new FormAgregarBook();

            DialogResult result = formAgregarBook.ShowDialog();

            if (result == DialogResult.OK)
            {
                // El usuario hizo clic en "Aceptar" en Form2
                Book valorRetornado = formAgregarBook.book;
                books.Insert(ref books.raiz,valorRetornado);
                books.SaveInPlaneFile(valorRetornado);
                BooksDGV.Rows.Clear();
                books.PostOrden(books.raiz, BooksDGV);
            }
            else
            {
                // El usuario canceló la operación en Form2
                label1.Text = "Operación cancelada desde Form2.";
            }
        }

        private void ReserveBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}