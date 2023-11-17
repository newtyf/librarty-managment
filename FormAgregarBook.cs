using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_De_Biblioteca_T3
{
    public partial class FormAgregarBook : Form
    {
        public Book book;
        public int size;

        public FormAgregarBook(int size)
        {
            InitializeComponent();
            this.size = size;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(titleInput.Text) || String.IsNullOrEmpty(descInput.Text) || String.IsNullOrEmpty(coverInput.Text) || String.IsNullOrEmpty(genderInput.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                return;
            }

            string title = titleInput.Text;
            string desc = descInput.Text;
            string author = authorInput.Text;
            string publish = dateTimePickerAddBook.Value.Year.ToString();
            string cover = coverInput.Text;
            string gender = genderInput.Text;

            DialogResult = DialogResult.OK;
            string id = size.ToString();
            book = new Book(id,title, desc,author,publish, cover, gender);
            Close();

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
