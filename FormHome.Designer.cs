﻿using System.ComponentModel;

namespace Gestor_De_Biblioteca_T3
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchBook = new System.Windows.Forms.Button();
            this.inputTitleSearch = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.ReserveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bookImage = new System.Windows.Forms.PictureBox();
            this.TitleBookLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.registerDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservesDGV = new System.Windows.Forms.DataGridView();
            this.idlb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbreserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbdevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(94, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvienido:";
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(169, 471);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(69, 19);
            this.userLabel.TabIndex = 1;
            // 
            // BooksDGV
            // 
            this.BooksDGV.AllowUserToAddRows = false;
            this.BooksDGV.AllowUserToDeleteRows = false;
            this.BooksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.id, this.Titulo, this.Descripcion, this.Autor, this.Publicacion, this.Cover, this.Genero, this.Reservar });
            this.BooksDGV.Location = new System.Drawing.Point(6, 41);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.ReadOnly = true;
            this.BooksDGV.Size = new System.Drawing.Size(335, 413);
            this.BooksDGV.TabIndex = 6;
            this.BooksDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 126.9036F;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Titulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.Titulo.FillWeight = 93.27411F;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Titulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.FillWeight = 93.27411F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.FillWeight = 93.27411F;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Visible = false;
            // 
            // Publicacion
            // 
            this.Publicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Publicacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Publicacion.FillWeight = 93.27411F;
            this.Publicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Publicacion.HeaderText = "Publicacion";
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.ReadOnly = true;
            this.Publicacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Publicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Cover
            // 
            this.Cover.HeaderText = "Cover";
            this.Cover.Name = "Cover";
            this.Cover.ReadOnly = true;
            this.Cover.Visible = false;
            this.Cover.Width = 60;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 67;
            // 
            // Reservar
            // 
            this.Reservar.HeaderText = "Reserva";
            this.Reservar.Name = "Reservar";
            this.Reservar.ReadOnly = true;
            this.Reservar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reservar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reservar.Text = "Reservar";
            this.Reservar.UseColumnTextForButtonValue = true;
            this.Reservar.Visible = false;
            this.Reservar.Width = 72;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(6, 460);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(85, 38);
            this.btnAddBook.TabIndex = 7;
            this.btnAddBook.Text = "agregar libro";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 531);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchBook);
            this.tabPage1.Controls.Add(this.inputTitleSearch);
            this.tabPage1.Controls.Add(this.descriptionLabel);
            this.tabPage1.Controls.Add(this.genderLabel);
            this.tabPage1.Controls.Add(this.publisherLabel);
            this.tabPage1.Controls.Add(this.authorLabel);
            this.tabPage1.Controls.Add(this.ReserveBtn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bookImage);
            this.tabPage1.Controls.Add(this.TitleBookLabel);
            this.tabPage1.Controls.Add(this.BooksDGV);
            this.tabPage1.Controls.Add(this.userLabel);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddBook);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchBook
            // 
            this.searchBook.Location = new System.Drawing.Point(281, 15);
            this.searchBook.Name = "searchBook";
            this.searchBook.Size = new System.Drawing.Size(59, 19);
            this.searchBook.TabIndex = 20;
            this.searchBook.Text = "Buscar";
            this.searchBook.UseVisualStyleBackColor = true;
            this.searchBook.Click += new System.EventHandler(this.searchBook_Click);
            // 
            // inputTitleSearch
            // 
            this.inputTitleSearch.Location = new System.Drawing.Point(7, 15);
            this.inputTitleSearch.Name = "inputTitleSearch";
            this.inputTitleSearch.Size = new System.Drawing.Size(268, 20);
            this.inputTitleSearch.TabIndex = 19;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(539, 184);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(374, 181);
            this.descriptionLabel.TabIndex = 18;
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(613, 134);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(212, 23);
            this.genderLabel.TabIndex = 17;
            this.genderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // publisherLabel
            // 
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(645, 113);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(228, 19);
            this.publisherLabel.TabIndex = 16;
            this.publisherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // authorLabel
            // 
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(603, 88);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(257, 23);
            this.authorLabel.TabIndex = 15;
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReserveBtn
            // 
            this.ReserveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveBtn.Location = new System.Drawing.Point(538, 368);
            this.ReserveBtn.Name = "ReserveBtn";
            this.ReserveBtn.Size = new System.Drawing.Size(126, 35);
            this.ReserveBtn.TabIndex = 14;
            this.ReserveBtn.Text = "Reservar";
            this.ReserveBtn.UseVisualStyleBackColor = true;
            this.ReserveBtn.Click += new System.EventHandler(this.ReserveBtn_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sinopsis:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(538, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Género:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Publicación:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autor:";
            // 
            // bookImage
            // 
            this.bookImage.Location = new System.Drawing.Point(347, 87);
            this.bookImage.Name = "bookImage";
            this.bookImage.Size = new System.Drawing.Size(181, 316);
            this.bookImage.TabIndex = 9;
            this.bookImage.TabStop = false;
            // 
            // TitleBookLabel
            // 
            this.TitleBookLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBookLabel.Location = new System.Drawing.Point(347, 42);
            this.TitleBookLabel.Name = "TitleBookLabel";
            this.TitleBookLabel.Size = new System.Drawing.Size(538, 29);
            this.TitleBookLabel.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.registerDGV);
            this.tabPage2.Controls.Add(this.reservesDGV);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // registerDGV
            // 
            this.registerDGV.AllowUserToAddRows = false;
            this.registerDGV.AllowUserToDeleteRows = false;
            this.registerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registerDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.registerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2 });
            this.registerDGV.Location = new System.Drawing.Point(468, 37);
            this.registerDGV.Name = "registerDGV";
            this.registerDGV.ReadOnly = true;
            this.registerDGV.Size = new System.Drawing.Size(445, 379);
            this.registerDGV.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Mensaje";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // reservesDGV
            // 
            this.reservesDGV.AllowUserToAddRows = false;
            this.reservesDGV.AllowUserToDeleteRows = false;
            this.reservesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.idlb, this.lbnombre, this.lbreserva, this.lbdevolucion });
            this.reservesDGV.Location = new System.Drawing.Point(7, 37);
            this.reservesDGV.Name = "reservesDGV";
            this.reservesDGV.ReadOnly = true;
            this.reservesDGV.Size = new System.Drawing.Size(443, 379);
            this.reservesDGV.TabIndex = 7;
            // 
            // idlb
            // 
            this.idlb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idlb.HeaderText = "ID";
            this.idlb.Name = "idlb";
            this.idlb.ReadOnly = true;
            this.idlb.Width = 43;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lbnombre.HeaderText = "TITULO";
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.ReadOnly = true;
            // 
            // lbreserva
            // 
            this.lbreserva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lbreserva.HeaderText = "FECHA DE RESERVA";
            this.lbreserva.Name = "lbreserva";
            this.lbreserva.ReadOnly = true;
            // 
            // lbdevolucion
            // 
            this.lbdevolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lbdevolucion.HeaderText = "FECHA DE DEVOLUCION";
            this.lbdevolucion.Name = "lbdevolucion";
            this.lbdevolucion.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(468, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registro";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reservas";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 532);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservesDGV)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;

        private System.Windows.Forms.DataGridViewTextBoxColumn Cover;

        private System.Windows.Forms.TextBox inputTitleSearch;
        private System.Windows.Forms.Button searchBook;

        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label genderLabel;

        private System.Windows.Forms.Label descriptionLabel;

        private System.Windows.Forms.Button ReserveBtn;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label TitleBookLabel;
        private System.Windows.Forms.PictureBox bookImage;

        private System.Windows.Forms.DataGridView registerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView reservesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlb;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbreserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbdevolucion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.DataGridViewButtonColumn Reservar;

        private System.Windows.Forms.Button btnAddBook;

        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewButtonColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewButtonColumn Publicacion;

        private System.Windows.Forms.DataGridView BooksDGV;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;

        #endregion
    }
}