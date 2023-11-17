namespace Gestor_De_Biblioteca_T3
{
    partial class FormAgregarBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.descInput = new System.Windows.Forms.TextBox();
            this.authorInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerAddBook = new System.Windows.Forms.DateTimePicker();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.coverInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.genderInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Libro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleInput
            // 
            this.titleInput.Location = new System.Drawing.Point(29, 99);
            this.titleInput.Name = "titleInput";
            this.titleInput.Size = new System.Drawing.Size(287, 20);
            this.titleInput.TabIndex = 3;
            // 
            // descInput
            // 
            this.descInput.Location = new System.Drawing.Point(28, 143);
            this.descInput.Name = "descInput";
            this.descInput.Size = new System.Drawing.Size(287, 20);
            this.descInput.TabIndex = 4;
            this.descInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(29, 189);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(287, 20);
            this.authorInput.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Titulo:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Publicacion";
            // 
            // dateTimePickerAddBook
            // 
            this.dateTimePickerAddBook.Location = new System.Drawing.Point(26, 366);
            this.dateTimePickerAddBook.Name = "dateTimePickerAddBook";
            this.dateTimePickerAddBook.Size = new System.Drawing.Size(288, 20);
            this.dateTimePickerAddBook.TabIndex = 11;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(86, 392);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(166, 46);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Agregar";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Portada";
            // 
            // coverInput
            // 
            this.coverInput.Location = new System.Drawing.Point(29, 244);
            this.coverInput.Name = "coverInput";
            this.coverInput.Size = new System.Drawing.Size(287, 20);
            this.coverInput.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Género";
            // 
            // genderInput
            // 
            this.genderInput.Location = new System.Drawing.Point(28, 293);
            this.genderInput.Name = "genderInput";
            this.genderInput.Size = new System.Drawing.Size(287, 20);
            this.genderInput.TabIndex = 15;
            // 
            // FormAgregarBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.genderInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.coverInput);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dateTimePickerAddBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.descInput);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarBook";
            this.Text = "FormAgregarBook";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coverInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox genderInput;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.TextBox descInput;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddBook;
        private System.Windows.Forms.Button btnAddBook;
    }
}