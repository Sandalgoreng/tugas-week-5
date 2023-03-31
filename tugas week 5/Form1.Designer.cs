namespace tugas_week_5
{
    partial class Form1
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
            this.tbox_nama = new System.Windows.Forms.MaskedTextBox();
            this.tbox_harga = new System.Windows.Forms.MaskedTextBox();
            this.cbox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_stock = new System.Windows.Forms.MaskedTextBox();
            this.cbox_cat = new System.Windows.Forms.ComboBox();
            this.tbox_name = new System.Windows.Forms.MaskedTextBox();
            this.DGV_left = new System.Windows.Forms.DataGridView();
            this.DGV_right = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.but_addpro = new System.Windows.Forms.Button();
            this.but_rpro = new System.Windows.Forms.Button();
            this.but_editpro = new System.Windows.Forms.Button();
            this.but_all = new System.Windows.Forms.Button();
            this.but_filter = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.but_addcat = new System.Windows.Forms.Button();
            this.but_rcat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_nama
            // 
            this.tbox_nama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbox_nama.Location = new System.Drawing.Point(151, 435);
            this.tbox_nama.Name = "tbox_nama";
            this.tbox_nama.Size = new System.Drawing.Size(525, 22);
            this.tbox_nama.TabIndex = 0;
            // 
            // tbox_harga
            // 
            this.tbox_harga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbox_harga.Location = new System.Drawing.Point(151, 493);
            this.tbox_harga.Name = "tbox_harga";
            this.tbox_harga.Size = new System.Drawing.Size(153, 22);
            this.tbox_harga.TabIndex = 0;
            // 
            // cbox_filter
            // 
            this.cbox_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbox_filter.Enabled = false;
            this.cbox_filter.FormattingEnabled = true;
            this.cbox_filter.Location = new System.Drawing.Point(382, 40);
            this.cbox_filter.Name = "cbox_filter";
            this.cbox_filter.Size = new System.Drawing.Size(121, 24);
            this.cbox_filter.TabIndex = 1;
            this.cbox_filter.SelectionChangeCommitted += new System.EventHandler(this.cbox_filter_SelectionChangeCommitted);
            // 
            // tbox_stock
            // 
            this.tbox_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbox_stock.Location = new System.Drawing.Point(151, 521);
            this.tbox_stock.Name = "tbox_stock";
            this.tbox_stock.Size = new System.Drawing.Size(153, 22);
            this.tbox_stock.TabIndex = 0;
            this.tbox_stock.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // cbox_cat
            // 
            this.cbox_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbox_cat.FormattingEnabled = true;
            this.cbox_cat.Location = new System.Drawing.Point(151, 463);
            this.cbox_cat.Name = "cbox_cat";
            this.cbox_cat.Size = new System.Drawing.Size(153, 24);
            this.cbox_cat.TabIndex = 1;
            // 
            // tbox_name
            // 
            this.tbox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbox_name.Location = new System.Drawing.Point(860, 264);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(283, 22);
            this.tbox_name.TabIndex = 0;
            this.tbox_name.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // DGV_left
            // 
            this.DGV_left.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DGV_left.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_left.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_left.Location = new System.Drawing.Point(40, 73);
            this.DGV_left.Name = "DGV_left";
            this.DGV_left.RowHeadersWidth = 51;
            this.DGV_left.RowTemplate.Height = 24;
            this.DGV_left.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_left.Size = new System.Drawing.Size(637, 323);
            this.DGV_left.TabIndex = 2;
            this.DGV_left.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_left_CellClick);
            this.DGV_left.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_left_CellContentClick);
            // 
            // DGV_right
            // 
            this.DGV_right.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DGV_right.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_right.Location = new System.Drawing.Point(860, 86);
            this.DGV_right.Name = "DGV_right";
            this.DGV_right.RowHeadersWidth = 51;
            this.DGV_right.RowTemplate.Height = 24;
            this.DGV_right.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_right.Size = new System.Drawing.Size(335, 150);
            this.DGV_right.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(856, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(38, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(38, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(38, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(38, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "stock";
            // 
            // but_addpro
            // 
            this.but_addpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_addpro.Location = new System.Drawing.Point(374, 478);
            this.but_addpro.Name = "but_addpro";
            this.but_addpro.Size = new System.Drawing.Size(97, 66);
            this.but_addpro.TabIndex = 5;
            this.but_addpro.Text = "add product";
            this.but_addpro.UseVisualStyleBackColor = false;
            this.but_addpro.Click += new System.EventHandler(this.but_addpro_Click);
            // 
            // but_rpro
            // 
            this.but_rpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_rpro.Location = new System.Drawing.Point(580, 478);
            this.but_rpro.Name = "but_rpro";
            this.but_rpro.Size = new System.Drawing.Size(97, 66);
            this.but_rpro.TabIndex = 5;
            this.but_rpro.Text = "remove product";
            this.but_rpro.UseVisualStyleBackColor = false;
            this.but_rpro.Click += new System.EventHandler(this.but_rpro_Click);
            // 
            // but_editpro
            // 
            this.but_editpro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.but_editpro.Location = new System.Drawing.Point(477, 478);
            this.but_editpro.Name = "but_editpro";
            this.but_editpro.Size = new System.Drawing.Size(97, 66);
            this.but_editpro.TabIndex = 5;
            this.but_editpro.Text = "edit product";
            this.but_editpro.UseVisualStyleBackColor = false;
            this.but_editpro.Click += new System.EventHandler(this.but_editpro_Click);
            // 
            // but_all
            // 
            this.but_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_all.Location = new System.Drawing.Point(245, 41);
            this.but_all.Name = "but_all";
            this.but_all.Size = new System.Drawing.Size(60, 26);
            this.but_all.TabIndex = 5;
            this.but_all.Text = "all";
            this.but_all.UseVisualStyleBackColor = false;
            this.but_all.Click += new System.EventHandler(this.but_all_Click);
            // 
            // but_filter
            // 
            this.but_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.but_filter.Location = new System.Drawing.Point(311, 42);
            this.but_filter.Name = "but_filter";
            this.but_filter.Size = new System.Drawing.Size(52, 24);
            this.but_filter.TabIndex = 5;
            this.but_filter.Text = "filter:";
            this.but_filter.UseVisualStyleBackColor = false;
            this.but_filter.Click += new System.EventHandler(this.but_filter_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(807, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "nama :";
            // 
            // but_addcat
            // 
            this.but_addcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.but_addcat.Location = new System.Drawing.Point(1016, 312);
            this.but_addcat.Name = "but_addcat";
            this.but_addcat.Size = new System.Drawing.Size(127, 66);
            this.but_addcat.TabIndex = 5;
            this.but_addcat.Text = "add category";
            this.but_addcat.UseVisualStyleBackColor = false;
            this.but_addcat.Click += new System.EventHandler(this.but_addcat_Click);
            // 
            // but_rcat
            // 
            this.but_rcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_rcat.Location = new System.Drawing.Point(883, 312);
            this.but_rcat.Name = "but_rcat";
            this.but_rcat.Size = new System.Drawing.Size(127, 66);
            this.but_rcat.TabIndex = 5;
            this.but_rcat.Text = "remove category";
            this.but_rcat.UseVisualStyleBackColor = false;
            this.but_rcat.Click += new System.EventHandler(this.but_rcat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::tugas_week_5.Properties.Resources.download1;
            this.pictureBox2.Location = new System.Drawing.Point(0, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1216, 631);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::tugas_week_5.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(955, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_editpro);
            this.Controls.Add(this.but_filter);
            this.Controls.Add(this.but_all);
            this.Controls.Add(this.but_rcat);
            this.Controls.Add(this.but_addcat);
            this.Controls.Add(this.but_rpro);
            this.Controls.Add(this.but_addpro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_right);
            this.Controls.Add(this.DGV_left);
            this.Controls.Add(this.cbox_cat);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.tbox_stock);
            this.Controls.Add(this.cbox_filter);
            this.Controls.Add(this.tbox_harga);
            this.Controls.Add(this.tbox_nama);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbox_nama;
        private System.Windows.Forms.MaskedTextBox tbox_harga;
        private System.Windows.Forms.ComboBox cbox_filter;
        private System.Windows.Forms.MaskedTextBox tbox_stock;
        private System.Windows.Forms.ComboBox cbox_cat;
        private System.Windows.Forms.MaskedTextBox tbox_name;
        private System.Windows.Forms.DataGridView DGV_left;
        private System.Windows.Forms.DataGridView DGV_right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_addpro;
        private System.Windows.Forms.Button but_rpro;
        private System.Windows.Forms.Button but_editpro;
        private System.Windows.Forms.Button but_all;
        private System.Windows.Forms.Button but_filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button but_addcat;
        private System.Windows.Forms.Button but_rcat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

