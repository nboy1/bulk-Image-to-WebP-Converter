using System.Windows.Forms;

namespace Image_To_WebP_Converter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.SelectPhotosbtn = new System.Windows.Forms.Button();
            this.Selected_Photos_ListBox = new System.Windows.Forms.ListBox();
            this.Select_Logo_Button = new System.Windows.Forms.Button();
            this.Add_Logo_box = new System.Windows.Forms.CheckBox();
            this.Add_Text_box = new System.Windows.Forms.CheckBox();
            this.Set_Image_Size_box = new System.Windows.Forms.CheckBox();
            this.Select_Folder_ListBox = new System.Windows.Forms.ListBox();
            this.Convert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Select_Output = new System.Windows.Forms.Button();
            this.WidthtextBox1 = new System.Windows.Forms.TextBox();
            this.HeighttextBox2 = new System.Windows.Forms.TextBox();
            this.Add_Text_RichBox = new System.Windows.Forms.TextBox();
            this.FontSizetextBox1 = new System.Windows.Forms.TextBox();
            this.Your_Font_Size = new System.Windows.Forms.TextBox();
            this.Change_Image_W_H = new System.Windows.Forms.TextBox();
            this.Add_Your_Text_Here = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Text_Color_btn = new System.Windows.Forms.Button();
            this.top_left_radio = new System.Windows.Forms.RadioButton();
            this.top_center_radio2 = new System.Windows.Forms.RadioButton();
            this.top_right_radio3 = new System.Windows.Forms.RadioButton();
            this.right_center_radio = new System.Windows.Forms.RadioButton();
            this.center_radio = new System.Windows.Forms.RadioButton();
            this.left_center_radio = new System.Windows.Forms.RadioButton();
            this.bottom_right_radio = new System.Windows.Forms.RadioButton();
            this.bottom_center_radio = new System.Windows.Forms.RadioButton();
            this.bottomleft__radio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Logo_Height = new System.Windows.Forms.TextBox();
            this.Logo_Width = new System.Windows.Forms.TextBox();
            this.Change_LOGO_W_H_Text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_position_text = new System.Windows.Forms.TextBox();
            this.bottom_right_logo_radio = new System.Windows.Forms.RadioButton();
            this.bottom_center_logo_radio = new System.Windows.Forms.RadioButton();
            this.bottom_left_logo_radio = new System.Windows.Forms.RadioButton();
            this.right_center_logo_radio = new System.Windows.Forms.RadioButton();
            this.center_logo_radio = new System.Windows.Forms.RadioButton();
            this.center_left_logo_radio = new System.Windows.Forms.RadioButton();
            this.top_right_logo_radio = new System.Windows.Forms.RadioButton();
            this.top_center_logo_radio = new System.Windows.Forms.RadioButton();
            this.left_top_logo_radio = new System.Windows.Forms.RadioButton();
            this.Set_Image_Quality_box = new System.Windows.Forms.CheckBox();
            this.quality_textBox = new System.Windows.Forms.TextBox();
            this.Quality_value_text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(773, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(14, 14);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectPhotosbtn
            // 
            this.SelectPhotosbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.SelectPhotosbtn.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.SelectPhotosbtn.FlatAppearance.BorderSize = 2;
            this.SelectPhotosbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPhotosbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectPhotosbtn.Location = new System.Drawing.Point(41, 127);
            this.SelectPhotosbtn.Name = "SelectPhotosbtn";
            this.SelectPhotosbtn.Size = new System.Drawing.Size(190, 37);
            this.SelectPhotosbtn.TabIndex = 1;
            this.SelectPhotosbtn.Text = "Select Photos";
            this.SelectPhotosbtn.UseVisualStyleBackColor = false;
            this.SelectPhotosbtn.Click += new System.EventHandler(this.SelectPhotosbtn_Click);
            // 
            // Selected_Photos_ListBox
            // 
            this.Selected_Photos_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Selected_Photos_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Selected_Photos_ListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Selected_Photos_ListBox.FormattingEnabled = true;
            this.Selected_Photos_ListBox.Location = new System.Drawing.Point(41, 182);
            this.Selected_Photos_ListBox.Name = "Selected_Photos_ListBox";
            this.Selected_Photos_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Selected_Photos_ListBox.Size = new System.Drawing.Size(147, 26);
            this.Selected_Photos_ListBox.TabIndex = 2;
            this.Selected_Photos_ListBox.SelectedIndexChanged += new System.EventHandler(this.Selected_Photos_ListBox_SelectedIndexChanged);
            // 
            // Select_Logo_Button
            // 
            this.Select_Logo_Button.BackColor = System.Drawing.Color.DarkCyan;
            this.Select_Logo_Button.Location = new System.Drawing.Point(597, 48);
            this.Select_Logo_Button.Name = "Select_Logo_Button";
            this.Select_Logo_Button.Size = new System.Drawing.Size(116, 116);
            this.Select_Logo_Button.TabIndex = 3;
            this.Select_Logo_Button.Text = "Select LOGO";
            this.Select_Logo_Button.UseVisualStyleBackColor = false;
            this.Select_Logo_Button.Click += new System.EventHandler(this.Select_Logo_Button_Click);
            // 
            // Add_Logo_box
            // 
            this.Add_Logo_box.AutoSize = true;
            this.Add_Logo_box.ForeColor = System.Drawing.Color.DarkGray;
            this.Add_Logo_box.Location = new System.Drawing.Point(41, 311);
            this.Add_Logo_box.Name = "Add_Logo_box";
            this.Add_Logo_box.Size = new System.Drawing.Size(127, 17);
            this.Add_Logo_box.TabIndex = 4;
            this.Add_Logo_box.Text = "Add LOGO to Images";
            this.Add_Logo_box.UseVisualStyleBackColor = true;
            this.Add_Logo_box.CheckedChanged += new System.EventHandler(this.Add_Logo_box_CheckedChanged);
            // 
            // Add_Text_box
            // 
            this.Add_Text_box.AutoSize = true;
            this.Add_Text_box.ForeColor = System.Drawing.Color.DarkGray;
            this.Add_Text_box.Location = new System.Drawing.Point(41, 338);
            this.Add_Text_box.Name = "Add_Text_box";
            this.Add_Text_box.Size = new System.Drawing.Size(118, 17);
            this.Add_Text_box.TabIndex = 5;
            this.Add_Text_box.Text = "Add Text to Images";
            this.Add_Text_box.UseVisualStyleBackColor = true;
            this.Add_Text_box.CheckedChanged += new System.EventHandler(this.Add_Text_box_CheckedChanged);
            // 
            // Set_Image_Size_box
            // 
            this.Set_Image_Size_box.AutoSize = true;
            this.Set_Image_Size_box.ForeColor = System.Drawing.Color.DarkGray;
            this.Set_Image_Size_box.Location = new System.Drawing.Point(41, 361);
            this.Set_Image_Size_box.Name = "Set_Image_Size_box";
            this.Set_Image_Size_box.Size = new System.Drawing.Size(104, 17);
            this.Set_Image_Size_box.TabIndex = 6;
            this.Set_Image_Size_box.Text = "Set Images\' Size";
            this.Set_Image_Size_box.UseVisualStyleBackColor = true;
            this.Set_Image_Size_box.CheckedChanged += new System.EventHandler(this.Set_Image_Size_box_CheckedChanged);
            // 
            // Select_Folder_ListBox
            // 
            this.Select_Folder_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Select_Folder_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Select_Folder_ListBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Select_Folder_ListBox.FormattingEnabled = true;
            this.Select_Folder_ListBox.Location = new System.Drawing.Point(41, 279);
            this.Select_Folder_ListBox.Name = "Select_Folder_ListBox";
            this.Select_Folder_ListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Select_Folder_ListBox.Size = new System.Drawing.Size(147, 26);
            this.Select_Folder_ListBox.TabIndex = 8;
            this.Select_Folder_ListBox.SelectedIndexChanged += new System.EventHandler(this.Select_Folder_ListBox_SelectedIndexChanged);
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Convert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Convert.FlatAppearance.BorderSize = 2;
            this.Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convert.ForeColor = System.Drawing.Color.Transparent;
            this.Convert.Location = new System.Drawing.Point(562, 364);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(190, 59);
            this.Convert.TabIndex = 9;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(41, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 76);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Select_Output
            // 
            this.Select_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.Select_Output.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.Select_Output.FlatAppearance.BorderSize = 2;
            this.Select_Output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Output.Location = new System.Drawing.Point(41, 236);
            this.Select_Output.Name = "Select_Output";
            this.Select_Output.Size = new System.Drawing.Size(190, 37);
            this.Select_Output.TabIndex = 11;
            this.Select_Output.Text = "Select Output Folder";
            this.Select_Output.UseVisualStyleBackColor = false;
            this.Select_Output.Click += new System.EventHandler(this.Select_Output_Click_1);
            // 
            // WidthtextBox1
            // 
            this.WidthtextBox1.BackColor = System.Drawing.Color.LightGray;
            this.WidthtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.WidthtextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.WidthtextBox1.Location = new System.Drawing.Point(449, 279);
            this.WidthtextBox1.Name = "WidthtextBox1";
            this.WidthtextBox1.Size = new System.Drawing.Size(100, 26);
            this.WidthtextBox1.TabIndex = 15;
            this.WidthtextBox1.Text = "512";
            this.WidthtextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WidthtextBox1.TextChanged += new System.EventHandler(this.WidthtextBox1_TextChanged);
            // 
            // HeighttextBox2
            // 
            this.HeighttextBox2.BackColor = System.Drawing.Color.LightGray;
            this.HeighttextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeighttextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HeighttextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.HeighttextBox2.Location = new System.Drawing.Point(552, 279);
            this.HeighttextBox2.Name = "HeighttextBox2";
            this.HeighttextBox2.Size = new System.Drawing.Size(100, 26);
            this.HeighttextBox2.TabIndex = 16;
            this.HeighttextBox2.Text = "512";
            this.HeighttextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeighttextBox2.TextChanged += new System.EventHandler(this.HeighttextBox2_TextChanged);
            // 
            // Add_Text_RichBox
            // 
            this.Add_Text_RichBox.BackColor = System.Drawing.Color.LightGray;
            this.Add_Text_RichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Add_Text_RichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_Text_RichBox.ForeColor = System.Drawing.Color.DimGray;
            this.Add_Text_RichBox.Location = new System.Drawing.Point(449, 208);
            this.Add_Text_RichBox.Name = "Add_Text_RichBox";
            this.Add_Text_RichBox.Size = new System.Drawing.Size(203, 19);
            this.Add_Text_RichBox.TabIndex = 17;
            this.Add_Text_RichBox.Text = "Add Your Text Here";
            this.Add_Text_RichBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Add_Text_RichBox.TextChanged += new System.EventHandler(this.Add_Text_RichBox_TextChanged);
            // 
            // FontSizetextBox1
            // 
            this.FontSizetextBox1.BackColor = System.Drawing.Color.LightGray;
            this.FontSizetextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontSizetextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FontSizetextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.FontSizetextBox1.Location = new System.Drawing.Point(449, 232);
            this.FontSizetextBox1.Name = "FontSizetextBox1";
            this.FontSizetextBox1.Size = new System.Drawing.Size(100, 26);
            this.FontSizetextBox1.TabIndex = 18;
            this.FontSizetextBox1.Text = "24";
            this.FontSizetextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FontSizetextBox1.TextChanged += new System.EventHandler(this.FontSizetextBox1_TextChanged);
            // 
            // Your_Font_Size
            // 
            this.Your_Font_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Your_Font_Size.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Your_Font_Size.ForeColor = System.Drawing.Color.DimGray;
            this.Your_Font_Size.Location = new System.Drawing.Point(280, 238);
            this.Your_Font_Size.Name = "Your_Font_Size";
            this.Your_Font_Size.Size = new System.Drawing.Size(163, 20);
            this.Your_Font_Size.TabIndex = 19;
            this.Your_Font_Size.Text = "Your Font Size (Digital Numbers)";
            // 
            // Change_Image_W_H
            // 
            this.Change_Image_W_H.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Change_Image_W_H.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Change_Image_W_H.ForeColor = System.Drawing.Color.DimGray;
            this.Change_Image_W_H.Location = new System.Drawing.Point(280, 285);
            this.Change_Image_W_H.Name = "Change_Image_W_H";
            this.Change_Image_W_H.Size = new System.Drawing.Size(163, 20);
            this.Change_Image_W_H.TabIndex = 19;
            this.Change_Image_W_H.Text = "Your Image Size (W) x (H)";
            this.Change_Image_W_H.TextChanged += new System.EventHandler(this.Change_Image_W_H_TextChanged);
            // 
            // Add_Your_Text_Here
            // 
            this.Add_Your_Text_Here.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Add_Your_Text_Here.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_Your_Text_Here.ForeColor = System.Drawing.Color.DimGray;
            this.Add_Your_Text_Here.Location = new System.Drawing.Point(280, 207);
            this.Add_Your_Text_Here.Name = "Add_Your_Text_Here";
            this.Add_Your_Text_Here.Size = new System.Drawing.Size(163, 20);
            this.Add_Your_Text_Here.TabIndex = 19;
            this.Add_Your_Text_Here.Text = "Your Text";
            // 
            // Text_Color_btn
            // 
            this.Text_Color_btn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Text_Color_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Text_Color_btn.Location = new System.Drawing.Point(663, 207);
            this.Text_Color_btn.Name = "Text_Color_btn";
            this.Text_Color_btn.Size = new System.Drawing.Size(55, 51);
            this.Text_Color_btn.TabIndex = 20;
            this.Text_Color_btn.Text = "Text Color";
            this.Text_Color_btn.UseVisualStyleBackColor = false;
            this.Text_Color_btn.Click += new System.EventHandler(this.Text_Color_btn_Click);
            // 
            // top_left_radio
            // 
            this.top_left_radio.Location = new System.Drawing.Point(729, 207);
            this.top_left_radio.Name = "top_left_radio";
            this.top_left_radio.Size = new System.Drawing.Size(14, 17);
            this.top_left_radio.TabIndex = 28;
            this.top_left_radio.UseVisualStyleBackColor = true;
            this.top_left_radio.CheckedChanged += new System.EventHandler(this.top_left_radio_CheckedChanged);
            // 
            // top_center_radio2
            // 
            this.top_center_radio2.Location = new System.Drawing.Point(749, 207);
            this.top_center_radio2.Name = "top_center_radio2";
            this.top_center_radio2.Size = new System.Drawing.Size(14, 17);
            this.top_center_radio2.TabIndex = 21;
            this.top_center_radio2.UseVisualStyleBackColor = true;
            this.top_center_radio2.CheckedChanged += new System.EventHandler(this.top_center_radio2_CheckedChanged);
            // 
            // top_right_radio3
            // 
            this.top_right_radio3.Location = new System.Drawing.Point(769, 207);
            this.top_right_radio3.Name = "top_right_radio3";
            this.top_right_radio3.Size = new System.Drawing.Size(14, 17);
            this.top_right_radio3.TabIndex = 22;
            this.top_right_radio3.UseVisualStyleBackColor = true;
            this.top_right_radio3.CheckedChanged += new System.EventHandler(this.top_right_radio3_CheckedChanged);
            // 
            // right_center_radio
            // 
            this.right_center_radio.Location = new System.Drawing.Point(769, 224);
            this.right_center_radio.Name = "right_center_radio";
            this.right_center_radio.Size = new System.Drawing.Size(14, 17);
            this.right_center_radio.TabIndex = 25;
            this.right_center_radio.UseVisualStyleBackColor = true;
            this.right_center_radio.CheckedChanged += new System.EventHandler(this.right_center_radio_CheckedChanged);
            // 
            // center_radio
            // 
            this.center_radio.Location = new System.Drawing.Point(749, 224);
            this.center_radio.Name = "center_radio";
            this.center_radio.Size = new System.Drawing.Size(14, 17);
            this.center_radio.TabIndex = 0;
            this.center_radio.UseVisualStyleBackColor = true;
            this.center_radio.CheckedChanged += new System.EventHandler(this.center_radio_CheckedChanged);
            // 
            // left_center_radio
            // 
            this.left_center_radio.Location = new System.Drawing.Point(729, 224);
            this.left_center_radio.Name = "left_center_radio";
            this.left_center_radio.Size = new System.Drawing.Size(14, 17);
            this.left_center_radio.TabIndex = 23;
            this.left_center_radio.UseVisualStyleBackColor = true;
            this.left_center_radio.CheckedChanged += new System.EventHandler(this.left_center_radio_CheckedChanged);
            // 
            // bottom_right_radio
            // 
            this.bottom_right_radio.Location = new System.Drawing.Point(769, 241);
            this.bottom_right_radio.Name = "bottom_right_radio";
            this.bottom_right_radio.Size = new System.Drawing.Size(14, 17);
            this.bottom_right_radio.TabIndex = 28;
            this.bottom_right_radio.UseVisualStyleBackColor = true;
            this.bottom_right_radio.CheckedChanged += new System.EventHandler(this.bottom_right_radio_CheckedChanged);
            // 
            // bottom_center_radio
            // 
            this.bottom_center_radio.Location = new System.Drawing.Point(749, 241);
            this.bottom_center_radio.Name = "bottom_center_radio";
            this.bottom_center_radio.Size = new System.Drawing.Size(14, 17);
            this.bottom_center_radio.TabIndex = 27;
            this.bottom_center_radio.UseVisualStyleBackColor = true;
            this.bottom_center_radio.CheckedChanged += new System.EventHandler(this.bottom_center_radio_CheckedChanged);
            // 
            // bottomleft__radio
            // 
            this.bottomleft__radio.Location = new System.Drawing.Point(729, 241);
            this.bottomleft__radio.Name = "bottomleft__radio";
            this.bottomleft__radio.Size = new System.Drawing.Size(14, 17);
            this.bottomleft__radio.TabIndex = 26;
            this.bottomleft__radio.UseVisualStyleBackColor = true;
            this.bottomleft__radio.CheckedChanged += new System.EventHandler(this.bottomleft__radio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(724, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Text Position";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Logo_Height
            // 
            this.Logo_Height.BackColor = System.Drawing.Color.LightGray;
            this.Logo_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Logo_Height.ForeColor = System.Drawing.Color.DimGray;
            this.Logo_Height.Location = new System.Drawing.Point(491, 138);
            this.Logo_Height.Name = "Logo_Height";
            this.Logo_Height.Size = new System.Drawing.Size(100, 26);
            this.Logo_Height.TabIndex = 41;
            this.Logo_Height.Text = "512";
            this.Logo_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Logo_Height.TextChanged += new System.EventHandler(this.Logo_Height_TextChanged);
            // 
            // Logo_Width
            // 
            this.Logo_Width.BackColor = System.Drawing.Color.LightGray;
            this.Logo_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Logo_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Logo_Width.ForeColor = System.Drawing.Color.DimGray;
            this.Logo_Width.Location = new System.Drawing.Point(388, 138);
            this.Logo_Width.Name = "Logo_Width";
            this.Logo_Width.Size = new System.Drawing.Size(100, 26);
            this.Logo_Width.TabIndex = 40;
            this.Logo_Width.Text = "512";
            this.Logo_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Logo_Width.TextChanged += new System.EventHandler(this.Logo_Width_TextChanged);
            // 
            // Change_LOGO_W_H_Text
            // 
            this.Change_LOGO_W_H_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.Change_LOGO_W_H_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Change_LOGO_W_H_Text.ForeColor = System.Drawing.Color.DimGray;
            this.Change_LOGO_W_H_Text.Location = new System.Drawing.Point(414, 98);
            this.Change_LOGO_W_H_Text.Name = "Change_LOGO_W_H_Text";
            this.Change_LOGO_W_H_Text.Size = new System.Drawing.Size(163, 20);
            this.Change_LOGO_W_H_Text.TabIndex = 42;
            this.Change_LOGO_W_H_Text.Text = "Your LOGO Size (W) x (H)";
            this.Change_LOGO_W_H_Text.TextChanged += new System.EventHandler(this.Change_LOGO_W_H_Text_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo_position_text);
            this.panel1.Controls.Add(this.bottom_right_logo_radio);
            this.panel1.Controls.Add(this.bottom_center_logo_radio);
            this.panel1.Controls.Add(this.bottom_left_logo_radio);
            this.panel1.Controls.Add(this.right_center_logo_radio);
            this.panel1.Controls.Add(this.center_logo_radio);
            this.panel1.Controls.Add(this.center_left_logo_radio);
            this.panel1.Controls.Add(this.top_right_logo_radio);
            this.panel1.Controls.Add(this.top_center_logo_radio);
            this.panel1.Controls.Add(this.left_top_logo_radio);
            this.panel1.Location = new System.Drawing.Point(718, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(74, 76);
            this.panel1.TabIndex = 43;
            // 
            // logo_position_text
            // 
            this.logo_position_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.logo_position_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo_position_text.ForeColor = System.Drawing.Color.DimGray;
            this.logo_position_text.Location = new System.Drawing.Point(5, 0);
            this.logo_position_text.Name = "logo_position_text";
            this.logo_position_text.Size = new System.Drawing.Size(64, 20);
            this.logo_position_text.TabIndex = 49;
            this.logo_position_text.Text = "Logo Position";
            // 
            // bottom_right_logo_radio
            // 
            this.bottom_right_logo_radio.Location = new System.Drawing.Point(50, 59);
            this.bottom_right_logo_radio.Name = "bottom_right_logo_radio";
            this.bottom_right_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.bottom_right_logo_radio.TabIndex = 47;
            this.bottom_right_logo_radio.UseVisualStyleBackColor = true;
            // 
            // bottom_center_logo_radio
            // 
            this.bottom_center_logo_radio.Location = new System.Drawing.Point(30, 59);
            this.bottom_center_logo_radio.Name = "bottom_center_logo_radio";
            this.bottom_center_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.bottom_center_logo_radio.TabIndex = 46;
            this.bottom_center_logo_radio.UseVisualStyleBackColor = true;
            // 
            // bottom_left_logo_radio
            // 
            this.bottom_left_logo_radio.Location = new System.Drawing.Point(10, 59);
            this.bottom_left_logo_radio.Name = "bottom_left_logo_radio";
            this.bottom_left_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.bottom_left_logo_radio.TabIndex = 45;
            this.bottom_left_logo_radio.UseVisualStyleBackColor = true;
            // 
            // right_center_logo_radio
            // 
            this.right_center_logo_radio.Location = new System.Drawing.Point(50, 42);
            this.right_center_logo_radio.Name = "right_center_logo_radio";
            this.right_center_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.right_center_logo_radio.TabIndex = 44;
            this.right_center_logo_radio.UseVisualStyleBackColor = true;
            // 
            // center_logo_radio
            // 
            this.center_logo_radio.Location = new System.Drawing.Point(30, 42);
            this.center_logo_radio.Name = "center_logo_radio";
            this.center_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.center_logo_radio.TabIndex = 40;
            this.center_logo_radio.UseVisualStyleBackColor = true;
            // 
            // center_left_logo_radio
            // 
            this.center_left_logo_radio.Location = new System.Drawing.Point(10, 42);
            this.center_left_logo_radio.Name = "center_left_logo_radio";
            this.center_left_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.center_left_logo_radio.TabIndex = 43;
            this.center_left_logo_radio.UseVisualStyleBackColor = true;
            // 
            // top_right_logo_radio
            // 
            this.top_right_logo_radio.Location = new System.Drawing.Point(50, 25);
            this.top_right_logo_radio.Name = "top_right_logo_radio";
            this.top_right_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.top_right_logo_radio.TabIndex = 42;
            this.top_right_logo_radio.UseVisualStyleBackColor = true;
            // 
            // top_center_logo_radio
            // 
            this.top_center_logo_radio.Location = new System.Drawing.Point(30, 25);
            this.top_center_logo_radio.Name = "top_center_logo_radio";
            this.top_center_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.top_center_logo_radio.TabIndex = 41;
            this.top_center_logo_radio.UseVisualStyleBackColor = true;
            // 
            // left_top_logo_radio
            // 
            this.left_top_logo_radio.Location = new System.Drawing.Point(10, 25);
            this.left_top_logo_radio.Name = "left_top_logo_radio";
            this.left_top_logo_radio.Size = new System.Drawing.Size(14, 17);
            this.left_top_logo_radio.TabIndex = 48;
            this.left_top_logo_radio.UseVisualStyleBackColor = true;
            // 
            // Set_Image_Quality_box
            // 
            this.Set_Image_Quality_box.AutoSize = true;
            this.Set_Image_Quality_box.ForeColor = System.Drawing.Color.DarkGray;
            this.Set_Image_Quality_box.Location = new System.Drawing.Point(41, 387);
            this.Set_Image_Quality_box.Name = "Set_Image_Quality_box";
            this.Set_Image_Quality_box.Size = new System.Drawing.Size(116, 17);
            this.Set_Image_Quality_box.TabIndex = 44;
            this.Set_Image_Quality_box.Text = "Set Images\' Quality";
            this.Set_Image_Quality_box.UseVisualStyleBackColor = true;
            this.Set_Image_Quality_box.CheckedChanged += new System.EventHandler(this.Set_Image_Quality_box_CheckedChanged);
            // 
            // quality_textBox
            // 
            this.quality_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.quality_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quality_textBox.ForeColor = System.Drawing.Color.DimGray;
            this.quality_textBox.Location = new System.Drawing.Point(280, 335);
            this.quality_textBox.Name = "quality_textBox";
            this.quality_textBox.Size = new System.Drawing.Size(163, 20);
            this.quality_textBox.TabIndex = 46;
            this.quality_textBox.Text = "Image Quality  (0 to100)";
            this.quality_textBox.TextChanged += new System.EventHandler(this.quality_textBox_TextChanged);
            // 
            // Quality_value_text
            // 
            this.Quality_value_text.BackColor = System.Drawing.Color.LightGray;
            this.Quality_value_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quality_value_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Quality_value_text.ForeColor = System.Drawing.Color.DimGray;
            this.Quality_value_text.Location = new System.Drawing.Point(449, 329);
            this.Quality_value_text.Name = "Quality_value_text";
            this.Quality_value_text.Size = new System.Drawing.Size(100, 26);
            this.Quality_value_text.TabIndex = 45;
            this.Quality_value_text.Text = "100";
            this.Quality_value_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Quality_value_text.TextChanged += new System.EventHandler(this.Quality_value_text_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quality_textBox);
            this.Controls.Add(this.Quality_value_text);
            this.Controls.Add(this.Set_Image_Quality_box);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Change_LOGO_W_H_Text);
            this.Controls.Add(this.Logo_Height);
            this.Controls.Add(this.Logo_Width);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bottom_right_radio);
            this.Controls.Add(this.bottom_center_radio);
            this.Controls.Add(this.bottomleft__radio);
            this.Controls.Add(this.right_center_radio);
            this.Controls.Add(this.center_radio);
            this.Controls.Add(this.left_center_radio);
            this.Controls.Add(this.top_right_radio3);
            this.Controls.Add(this.top_center_radio2);
            this.Controls.Add(this.top_left_radio);
            this.Controls.Add(this.Text_Color_btn);
            this.Controls.Add(this.Change_Image_W_H);
            this.Controls.Add(this.Your_Font_Size);
            this.Controls.Add(this.Add_Your_Text_Here);
            this.Controls.Add(this.FontSizetextBox1);
            this.Controls.Add(this.Add_Text_RichBox);
            this.Controls.Add(this.HeighttextBox2);
            this.Controls.Add(this.WidthtextBox1);
            this.Controls.Add(this.Select_Output);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.Select_Folder_ListBox);
            this.Controls.Add(this.Set_Image_Size_box);
            this.Controls.Add(this.Add_Text_box);
            this.Controls.Add(this.Add_Logo_box);
            this.Controls.Add(this.Select_Logo_Button);
            this.Controls.Add(this.Selected_Photos_ListBox);
            this.Controls.Add(this.SelectPhotosbtn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "WebP Converter";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectPhotosbtn;
        private System.Windows.Forms.ListBox Selected_Photos_ListBox;
        private System.Windows.Forms.Button Select_Logo_Button;
        private System.Windows.Forms.CheckBox Add_Logo_box;
        private System.Windows.Forms.CheckBox Add_Text_box;
        private System.Windows.Forms.CheckBox Set_Image_Size_box;
        private System.Windows.Forms.ListBox Select_Folder_ListBox;
        //private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Select_Output;
        private TextBox WidthtextBox1;
        private TextBox HeighttextBox2;
        private TextBox Add_Text_RichBox;
        private TextBox FontSizetextBox1;
        private TextBox Your_Font_Size;
        private TextBox Change_Image_W_H;
        private TextBox Add_Your_Text_Here;
        private ColorDialog colorDialog1;
        private Button Text_Color_btn;
        private RadioButton top_left_radio;
        private RadioButton top_center_radio2;
        private RadioButton top_right_radio3;
        private RadioButton right_center_radio;
        private RadioButton center_radio;
        private RadioButton left_center_radio;
        private RadioButton bottom_right_radio;
        private RadioButton bottom_center_radio;
        private RadioButton bottomleft__radio;
        private TextBox textBox1;
        private TextBox Logo_Height;
        private TextBox Logo_Width;
        private TextBox Change_LOGO_W_H_Text;
        private Panel panel1;
        private TextBox logo_position_text;
        private RadioButton bottom_right_logo_radio;
        private RadioButton bottom_center_logo_radio;
        private RadioButton bottom_left_logo_radio;
        private RadioButton right_center_logo_radio;
        private RadioButton center_logo_radio;
        private RadioButton center_left_logo_radio;
        private RadioButton top_right_logo_radio;
        private RadioButton top_center_logo_radio;
        private RadioButton left_top_logo_radio;
        private CheckBox Set_Image_Quality_box;
        private TextBox quality_textBox;
        private TextBox Quality_value_text;
    }
}

