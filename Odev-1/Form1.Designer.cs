namespace Odev_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pct_poster = new System.Windows.Forms.PictureBox();
            this.lst_casts = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelImage = new System.Windows.Forms.Panel();
            this.lst_star = new System.Windows.Forms.ListBox();
            this.lst_writer = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_director = new System.Windows.Forms.ListBox();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_moviename = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lst_movies = new System.Windows.Forms.ListBox();
            this.txt_moviename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pct_poster);
            this.groupBox1.Controls.Add(this.lst_casts);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panelImage);
            this.groupBox1.Controls.Add(this.lst_star);
            this.groupBox1.Controls.Add(this.lst_writer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lst_director);
            this.groupBox1.Controls.Add(this.lbl_rating);
            this.groupBox1.Controls.Add(this.lbl_moviename);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.lst_movies);
            this.groupBox1.Controls.Add(this.txt_moviename);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1275, 702);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMDB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1021, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Casts";
            // 
            // pct_poster
            // 
            this.pct_poster.Location = new System.Drawing.Point(32, 384);
            this.pct_poster.Name = "pct_poster";
            this.pct_poster.Size = new System.Drawing.Size(246, 297);
            this.pct_poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_poster.TabIndex = 22;
            this.pct_poster.TabStop = false;
            // 
            // lst_casts
            // 
            this.lst_casts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_casts.FormattingEnabled = true;
            this.lst_casts.Location = new System.Drawing.Point(1024, 386);
            this.lst_casts.Name = "lst_casts";
            this.lst_casts.Size = new System.Drawing.Size(226, 290);
            this.lst_casts.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(323, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Photos";
            // 
            // panelImage
            // 
            this.panelImage.Location = new System.Drawing.Point(326, 386);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(675, 131);
            this.panelImage.TabIndex = 18;
            // 
            // lst_star
            // 
            this.lst_star.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_star.FormattingEnabled = true;
            this.lst_star.Location = new System.Drawing.Point(960, 90);
            this.lst_star.Name = "lst_star";
            this.lst_star.Size = new System.Drawing.Size(278, 121);
            this.lst_star.TabIndex = 17;
            this.lst_star.SelectedIndexChanged += new System.EventHandler(this.lst_star_SelectedIndexChanged);
            // 
            // lst_writer
            // 
            this.lst_writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_writer.FormattingEnabled = true;
            this.lst_writer.Location = new System.Drawing.Point(609, 90);
            this.lst_writer.Name = "lst_writer";
            this.lst_writer.Size = new System.Drawing.Size(326, 121);
            this.lst_writer.TabIndex = 16;
            this.lst_writer.SelectedIndexChanged += new System.EventHandler(this.lst_writer_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(323, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(957, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Stars";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(606, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Writers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(323, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Directors";
            // 
            // lst_director
            // 
            this.lst_director.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_director.FormattingEnabled = true;
            this.lst_director.Location = new System.Drawing.Point(326, 90);
            this.lst_director.Name = "lst_director";
            this.lst_director.Size = new System.Drawing.Size(235, 121);
            this.lst_director.TabIndex = 10;
            this.lst_director.SelectedIndexChanged += new System.EventHandler(this.lst_director_SelectedIndexChanged);
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rating.Location = new System.Drawing.Point(1086, 27);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(0, 24);
            this.lbl_rating.TabIndex = 9;
            // 
            // lbl_moviename
            // 
            this.lbl_moviename.AutoSize = true;
            this.lbl_moviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_moviename.Location = new System.Drawing.Point(322, 27);
            this.lbl_moviename.Name = "lbl_moviename";
            this.lbl_moviename.Size = new System.Drawing.Size(0, 24);
            this.lbl_moviename.TabIndex = 8;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_description.Location = new System.Drawing.Point(326, 256);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(912, 82);
            this.txt_description.TabIndex = 4;
            // 
            // lst_movies
            // 
            this.lst_movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lst_movies.FormattingEnabled = true;
            this.lst_movies.Location = new System.Drawing.Point(32, 87);
            this.lst_movies.Name = "lst_movies";
            this.lst_movies.Size = new System.Drawing.Size(246, 251);
            this.lst_movies.TabIndex = 2;
            this.lst_movies.SelectedIndexChanged += new System.EventHandler(this.lst_movies_SelectedIndexChanged);
            // 
            // txt_moviename
            // 
            this.txt_moviename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_moviename.Location = new System.Drawing.Point(108, 48);
            this.txt_moviename.Name = "txt_moviename";
            this.txt_moviename.Size = new System.Drawing.Size(170, 20);
            this.txt_moviename.TabIndex = 3;
            this.txt_moviename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_moviename_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 724);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lst_movies;
        private System.Windows.Forms.TextBox txt_moviename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_moviename;
        private System.Windows.Forms.ListBox lst_director;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_star;
        private System.Windows.Forms.ListBox lst_writer;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lst_casts;
        private System.Windows.Forms.PictureBox pct_poster;
        private System.Windows.Forms.Label label7;
    }
}