namespace Odev_1
{
    partial class frm_Star
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
            this.lst_actor = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_writer = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lst_director = new System.Windows.Forms.ListBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pct_poster = new System.Windows.Forms.PictureBox();
            this.txt_born = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelKnownFor = new System.Windows.Forms.Panel();
            this.lbl_lnk_seeall = new System.Windows.Forms.LinkLabel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_poster)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panelKnownFor);
            this.groupBox1.Controls.Add(this.lbl_lnk_seeall);
            this.groupBox1.Controls.Add(this.panelImage);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lst_actor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lst_writer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lst_director);
            this.groupBox1.Controls.Add(this.lbl_name);
            this.groupBox1.Controls.Add(this.pct_poster);
            this.groupBox1.Controls.Add(this.txt_born);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_desc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1477, 741);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1086, 471);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Actor";
            // 
            // lst_actor
            // 
            this.lst_actor.FormattingEnabled = true;
            this.lst_actor.Location = new System.Drawing.Point(1086, 495);
            this.lst_actor.Margin = new System.Windows.Forms.Padding(2);
            this.lst_actor.Name = "lst_actor";
            this.lst_actor.Size = new System.Drawing.Size(354, 186);
            this.lst_actor.TabIndex = 45;
            this.lst_actor.SelectedIndexChanged += new System.EventHandler(this.lst_actor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1086, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Writer";
            // 
            // lst_writer
            // 
            this.lst_writer.FormattingEnabled = true;
            this.lst_writer.Location = new System.Drawing.Point(1086, 272);
            this.lst_writer.Margin = new System.Windows.Forms.Padding(2);
            this.lst_writer.Name = "lst_writer";
            this.lst_writer.Size = new System.Drawing.Size(354, 173);
            this.lst_writer.TabIndex = 43;
            this.lst_writer.SelectedIndexChanged += new System.EventHandler(this.lst_writer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1086, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Director";
            // 
            // lst_director
            // 
            this.lst_director.FormattingEnabled = true;
            this.lst_director.Location = new System.Drawing.Point(1086, 52);
            this.lst_director.Margin = new System.Windows.Forms.Padding(2);
            this.lst_director.Name = "lst_director";
            this.lst_director.Size = new System.Drawing.Size(354, 173);
            this.lst_director.TabIndex = 41;
            this.lst_director.SelectedIndexChanged += new System.EventHandler(this.lst_director_SelectedIndexChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(34, 18);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_name.TabIndex = 40;
            // 
            // pct_poster
            // 
            this.pct_poster.Location = new System.Drawing.Point(39, 52);
            this.pct_poster.Name = "pct_poster";
            this.pct_poster.Size = new System.Drawing.Size(221, 305);
            this.pct_poster.TabIndex = 36;
            this.pct_poster.TabStop = false;
            // 
            // txt_born
            // 
            this.txt_born.Location = new System.Drawing.Point(374, 213);
            this.txt_born.Name = "txt_born";
            this.txt_born.Size = new System.Drawing.Size(240, 20);
            this.txt_born.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Born";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(372, 52);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(679, 126);
            this.txt_desc.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(372, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(384, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 63;
            this.label3.Text = "Known For";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(375, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "Photos";
            // 
            // panelKnownFor
            // 
            this.panelKnownFor.Location = new System.Drawing.Point(385, 526);
            this.panelKnownFor.Name = "panelKnownFor";
            this.panelKnownFor.Size = new System.Drawing.Size(676, 154);
            this.panelKnownFor.TabIndex = 62;
            // 
            // lbl_lnk_seeall
            // 
            this.lbl_lnk_seeall.AutoSize = true;
            this.lbl_lnk_seeall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lnk_seeall.Location = new System.Drawing.Point(389, 473);
            this.lbl_lnk_seeall.Name = "lbl_lnk_seeall";
            this.lbl_lnk_seeall.Size = new System.Drawing.Size(51, 16);
            this.lbl_lnk_seeall.TabIndex = 61;
            this.lbl_lnk_seeall.TabStop = true;
            this.lbl_lnk_seeall.Text = "See All";
            // 
            // panelImage
            // 
            this.panelImage.Location = new System.Drawing.Point(376, 291);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(675, 154);
            this.panelImage.TabIndex = 60;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(986, 686);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 58;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // frm_Star
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 762);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Star";
            this.Text = "frm_Star";
            this.Load += new System.EventHandler(this.frm_Star_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pct_poster;
        private System.Windows.Forms.TextBox txt_born;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lst_actor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lst_writer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lst_director;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelKnownFor;
        private System.Windows.Forms.LinkLabel lbl_lnk_seeall;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Button btn_back;
    }
}