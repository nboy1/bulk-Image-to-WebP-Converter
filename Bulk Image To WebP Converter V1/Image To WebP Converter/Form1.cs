using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Image_To_WebP_Converter
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        [DllImport("user32.dll")]
        private static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);

        [DllImport("user32.dll")]
        private static extern int SetScrollPos(IntPtr hWnd, int nBar, int nPos, bool bRedraw);

        private const int SB_VERT = 1;
        private ColorDialog colorDialog;
        public Form1()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;

            colorDialog = new ColorDialog();

            Add_Text_RichBox.Visible = false;
            FontSizetextBox1.Visible = false;
            Select_Logo_Button.Visible = false;
            WidthtextBox1.Visible = false;
            HeighttextBox2.Visible = false;
            Add_Your_Text_Here.Visible = false;
            Your_Font_Size.Visible = false;
            Change_Image_W_H.Visible = false;
            Text_Color_btn.Visible = false;
            textBox1.Visible = false;
            top_left_radio.Visible = false;
            top_center_radio2.Visible = false;
            top_right_radio3.Visible = false;
            left_center_radio.Visible = false;
            center_radio.Visible = false;
            right_center_radio.Visible = false;
            bottomleft__radio.Visible = false;
            bottom_center_radio.Visible = false;
            bottom_right_radio.Visible = false;

            logo_position_text.Visible = false;
            left_top_logo_radio.Visible = false;
            top_center_logo_radio.Visible = false;
            top_right_logo_radio.Visible = false;
            center_left_logo_radio.Visible = false;
            center_logo_radio.Visible = false;
            right_center_logo_radio.Visible = false;
            bottom_left_logo_radio.Visible = false;
            bottom_center_logo_radio.Visible = false;
            bottom_right_logo_radio.Visible = false;
            Logo_Height.Visible = false;
            Logo_Width.Visible = false;
            Change_LOGO_W_H_Text.Visible = false;


            quality_textBox.Visible = false;
            Quality_value_text.Visible = false;






            Set_Image_Size_box.CheckedChanged += Set_Image_Size_box_CheckedChanged1;
            Add_Logo_box.CheckedChanged += Select_Logo_Button_VisibleChanged;

            Add_Text_box.CheckedChanged += Add_Text_box_CheckedChanged;
            Selected_Photos_ListBox.MouseWheel += ImagesListBox_MouseWheel; 
            HideScrollBarTrack(Selected_Photos_ListBox); 
            this.FormBorderStyle = FormBorderStyle.None;


            SetRoundedCorners(17);

            

            MakeButtonRounded(SelectPhotosbtn, 12); 
            MakeButtonRounded(Select_Output, 12);
           


        }

       


        private void HideScrollBarTrack(ListBox listBox)
        {
            ShowScrollBar(listBox.Handle, SB_VERT, false); 
        }
        private void ImagesListBox_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollPos = GetScrollPos(Selected_Photos_ListBox.Handle, SB_VERT); 
            SetScrollPos(Selected_Photos_ListBox.Handle, SB_VERT, scrollPos, true); 

            HideScrollBarTrack(Selected_Photos_ListBox); 
        }


        private void MakeButtonRounded(Button button, int radius)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; 

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                HideScrollBarTrack(Selected_Photos_ListBox); 
                Selected_Photos_ListBox.MouseWheel += ImagesListBox_MouseWheel; 

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetRoundedCorners(int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
            this.Invalidate(); 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderThickness = 2; 
            Color borderColor = Color.Gray;

            using (Graphics g = e.Graphics)
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;


                int radius = 17;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(borderThickness / 2, borderThickness / 2, radius, radius, 180, 90);
                path.AddArc(this.Width - radius - borderThickness / 2 - 1, borderThickness / 2, radius, radius, 270, 90);
                path.AddArc(this.Width - radius - borderThickness / 2 - 1, this.Height - radius - borderThickness / 2 - 1, radius, radius, 0, 90);
                path.AddArc(borderThickness / 2, this.Height - radius - borderThickness / 2 - 1, radius, radius, 90, 90);
                path.CloseFigure();

                g.DrawPath(pen, path);
            }
        }

        private List<string> selectedFilePaths = new List<string>();

        private void SelectPhotosbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Images";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.Multiselect = true; 

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePaths.Clear(); 

                    

                    selectedFilePaths.AddRange(openFileDialog.FileNames);


                    Selected_Photos_ListBox.Items.Clear();  
                    Selected_Photos_ListBox.Items.Add($"{selectedFilePaths.Count} Images Selected"); 

                    HideScrollBarTrack(Selected_Photos_ListBox); 

                                                                 
                    if (selectedFilePaths.Count > 0)
                    {
                        using (Image image = Image.FromFile(selectedFilePaths[0]))  
                        {
                            WidthtextBox1.Text = image.Width.ToString();  
                            HeighttextBox2.Text = image.Height.ToString();  
                        }
                    }


                }

            }
        }







        private void Selected_Photos_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Logo_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Set_Image_Size_box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_Text_box_CheckedChanged(object sender, EventArgs e)
        {

            if (Add_Text_box.Checked)
            {

                Add_Text_RichBox.Visible = true;
                FontSizetextBox1.Visible = true;
                Add_Your_Text_Here.Visible = true;
                Your_Font_Size.Visible = true;
                Text_Color_btn.Visible = true;
                textBox1.Visible = true;
                top_left_radio.Visible = true;
                top_center_radio2.Visible = true;
                top_right_radio3.Visible = true;
                left_center_radio.Visible = true;
                center_radio.Visible=true;
                right_center_radio.Visible= true;
                bottomleft__radio.Visible = true;
                bottom_center_radio.Visible=true;
                bottom_right_radio.Visible=true;

                center_radio.Checked = true;
            }
            else
            {

                Add_Text_RichBox.Visible = false;
                FontSizetextBox1.Visible = false;
                Add_Your_Text_Here.Visible = false;
                Your_Font_Size.Visible = false;
                Text_Color_btn.Visible = false;
                textBox1.Visible = false;
                top_left_radio.Visible = false;
                top_center_radio2.Visible = false;
                top_right_radio3.Visible = false;
                left_center_radio.Visible = false;
                center_radio.Visible = false;
                right_center_radio.Visible = false;
                bottomleft__radio.Visible = false;
                bottom_center_radio.Visible = false;
                bottom_right_radio.Visible = false;

            }
        }
        private void Select_Logo_Button_VisibleChanged(object sender, EventArgs e)
        {
            if (Add_Logo_box.Checked)
            {
                center_logo_radio.Checked=true;

                Select_Logo_Button.Visible = true;
                Select_Logo_Button.Visible = true;
                logo_position_text.Visible = true;
                left_top_logo_radio.Visible = true;
                top_center_logo_radio.Visible = true;
                top_right_logo_radio.Visible = true;
                center_left_logo_radio.Visible = true;
                center_logo_radio.Visible = true;
                right_center_logo_radio.Visible = true;
                bottom_left_logo_radio.Visible = true;
                bottom_center_logo_radio.Visible = true;
                bottom_right_logo_radio.Visible = true;
                Logo_Height.Visible = true;
                Logo_Width.Visible = true;
                Change_LOGO_W_H_Text.Visible = true;
            }
            else
            {

                Select_Logo_Button.Visible = false;
                Select_Logo_Button.Visible = false;

                logo_position_text.Visible = false;
                left_top_logo_radio.Visible = false;
                top_center_logo_radio.Visible = false;
                top_right_logo_radio.Visible = false;
                center_left_logo_radio.Visible = false;
                center_logo_radio.Visible = false;
                right_center_logo_radio.Visible = false;
                bottom_left_logo_radio.Visible = false;
                bottom_center_logo_radio.Visible = false;
                bottom_right_logo_radio.Visible = false;
                Logo_Height.Visible = false;
                Logo_Width.Visible = false; 
                Change_LOGO_W_H_Text.Visible = false;
            }
        }
        private void Set_Image_Size_box_CheckedChanged1(object sender, EventArgs e)
        {
            if (Set_Image_Size_box.Checked)
            {

                WidthtextBox1.Visible = true;
                HeighttextBox2.Visible = true;
                Change_Image_W_H.Visible = true;
             }
            else
            {

                WidthtextBox1.Visible = false;
                HeighttextBox2.Visible = false;
                Change_Image_W_H.Visible = false;

            }
        }
        private void FontSizetextBox1_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(FontSizetextBox1.Text, out _))
            {

                FontSizetextBox1.Text = string.Empty; 

                MessageBox.Show("Please enter a valid number for the Font Size.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Output Folder"; 
                folderDialog.ShowNewFolderButton = true; 


                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; 
                    Select_Folder_ListBox.Items.Clear(); 
                    Select_Folder_ListBox.Items.Add(selectedFolder); 
                }
            }
        }


        private void Select_Folder_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Select_Folder_ListBox.SelectedItem != null)
            {
                string selectedPath = Select_Folder_ListBox.SelectedItem.ToString();

                MessageBox.Show("You selected: " + selectedPath);
            }
        }



        private void Select_Output_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Select Output Folder"; 
                folderDialog.ShowNewFolderButton = true;


                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath; 
                    Select_Folder_ListBox.Items.Clear(); 
                    Select_Folder_ListBox.Items.Add(selectedFolder); 
                }
            }
        }


        private void Convert_Click_1(object sender, EventArgs e)
        {
            if (selectedFilePaths.Count == 0)
            {
                MessageBox.Show("Please select images and an output folder.");
                return;
            }

            string outputFolder = (Select_Folder_ListBox.Items.Count > 0 && Select_Folder_ListBox.Items[0] != null)
                ? Select_Folder_ListBox.Items[0].ToString().Trim()
                : string.Empty;

            string overlayText = !string.IsNullOrWhiteSpace(Add_Text_RichBox.Text)
                ? Add_Text_RichBox.Text.Trim()
                : string.Empty;

            if (string.IsNullOrWhiteSpace(outputFolder))
            {
                MessageBox.Show("Please select an output folder.");
                return;
            }

            if (string.IsNullOrWhiteSpace(overlayText) && Add_Text_box.Checked)
            {
                MessageBox.Show("Please enter text or uncheck the option.");
                return;
            }

            if (!Add_Text_box.Checked)
            {
                overlayText = ""; 
            }

            Color textColor = Text_Color_btn.BackColor;
            int width = int.TryParse(WidthtextBox1.Text, out width) ? width : 0;
            int height = int.TryParse(HeighttextBox2.Text, out height) ? height : 0;

            bool success = false;

            foreach (string imagePath in selectedFilePaths)
            {
                try
                {
                    string originalFileName = Path.GetFileNameWithoutExtension(imagePath);
                    string outputFilePath = Path.Combine(outputFolder, originalFileName + ".webp");

                    using (var image = Image.FromFile(imagePath))
                    {
                        using (var modifiedImage = ApplyTextOverlay(image, overlayText, textColor, width, height, Set_Image_Size_box.Checked, selectedLogoPath))
                        {
                            if (Set_Image_Quality_box.Checked)
                            {

                                if (int.TryParse(Quality_value_text.Text, out int quality))
                                {

                                    if (quality < 0) quality = 0;
                                    else if (quality > 100) quality = 100;

                                    SaveAsWebP(modifiedImage, outputFilePath, quality);
                                }
                                else
                                {

                                    MessageBox.Show("Please enter a valid number for the image quality.");
                                    SaveAsWebP(modifiedImage, outputFilePath, 100); 
                                }
                            }
                            else
                            {
                                SaveAsWebP(modifiedImage, outputFilePath, 100); 
                            }


                        }
                    }

                    Console.WriteLine($"Converted: {imagePath} → {outputFilePath}");
                    success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error converting image: {ex.Message}");
                }
            }

            if (success)
            {
                MessageBox.Show("Images converted successfully!");
                Process.Start("explorer.exe", outputFolder);
            }
        }


        private Image ApplyTextOverlay(Image image, string text, Color textColor, int width, int height, bool resize, string logoPath)
        {
            int fontSize = Add_Text_box.Checked ? int.Parse(FontSizetextBox1.Text) : 24;

            if (resize)
            {
                image = new Bitmap(image, new Size(width, height));
            }

            Bitmap bitmap = new Bitmap(image);
            using (Graphics g = Graphics.FromImage(bitmap))
            {


                if (!string.IsNullOrEmpty(logoPath) && File.Exists(logoPath) && Add_Logo_box.Checked)
                {
                    using (Image logo = Image.FromFile(logoPath))
                    {

                        int logoWidth = int.TryParse(Logo_Width.Text, out int lw) && lw > 0 ? lw : bitmap.Width / 5;
                        int logoHeight = int.TryParse(Logo_Height.Text, out int lh) && lh > 0 ? lh : (int)((float)logo.Height / logo.Width * logoWidth);
                        int logoX = 0, logoY = 0; 


                        if (left_top_logo_radio.Checked) { logoX = 0; logoY = 0; }
                        else if (top_center_logo_radio.Checked) { logoX = (bitmap.Width - logoWidth) / 2; logoY = 0; }
                        else if (top_right_logo_radio.Checked) { logoX = bitmap.Width - logoWidth; logoY = 0; }
                        else if (center_left_logo_radio.Checked) { logoX = 0; logoY = (bitmap.Height - logoHeight) / 2; }
                        else if (center_logo_radio.Checked) { logoX = (bitmap.Width - logoWidth) / 2; logoY = (bitmap.Height - logoHeight) / 2; }
                        else if (right_center_logo_radio.Checked) { logoX = bitmap.Width - logoWidth; logoY = (bitmap.Height - logoHeight) / 2; }
                        else if (bottom_left_logo_radio.Checked) { logoX = 0; logoY = bitmap.Height - logoHeight; }
                        else if (bottom_center_logo_radio.Checked) { logoX = (bitmap.Width - logoWidth) / 2; logoY = bitmap.Height - logoHeight; }
                        else if (bottom_right_logo_radio.Checked) { logoX = bitmap.Width - logoWidth; logoY = bitmap.Height - logoHeight; }

                        g.DrawImage(logo, new Rectangle(logoX, logoY, logoWidth, logoHeight));
                    }
                }

                Font font = new Font("Arial", fontSize, FontStyle.Bold);
                SizeF textSize = g.MeasureString(text, font);
                float x = 0, y = 0;


                if (top_left_radio.Checked) { x = 0; y = 0; }
                else if (left_center_radio.Checked) { x = 0; y = (bitmap.Height - textSize.Height) / 2; }
                else if (bottomleft__radio.Checked) { x = 0; y = bitmap.Height - textSize.Height; }
                else if (top_center_radio2.Checked) { x = (bitmap.Width - textSize.Width) / 2; y = 0; }
                else if (center_radio.Checked) { x = (bitmap.Width - textSize.Width) / 2; y = (bitmap.Height - textSize.Height) / 2; }
                else if (bottom_center_radio.Checked) { x = (bitmap.Width - textSize.Width) / 2; y = bitmap.Height - textSize.Height; }
                else if (top_right_radio3.Checked) { x = bitmap.Width - textSize.Width; y = 0; }
                else if (right_center_radio.Checked) { x = bitmap.Width - textSize.Width; y = (bitmap.Height - textSize.Height) / 2; }
                else if (bottom_right_radio.Checked) { x = bitmap.Width - textSize.Width; y = bitmap.Height - textSize.Height; }

                using (SolidBrush brush = new SolidBrush(textColor))
                {
                    g.DrawString(text, font, brush, x, y);
                }

                
            }

            return bitmap;
        }




        private void SaveAsWebP(Image image, string outputFilePath, int quality)
        {
            using (var bitmap = new Bitmap(image))
            {
                byte[] webpBytes = Dynamicweb.WebP.Encoder.Encode(bitmap, quality); 
                File.WriteAllBytes(outputFilePath, webpBytes);
            }
        }

        private void WidthtextBox1_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(WidthtextBox1.Text, out _))
            {

                WidthtextBox1.Text = string.Empty; 
                MessageBox.Show("Please enter a valid number for the width.");
            }
        }
        private void HeighttextBox2_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(HeighttextBox2.Text, out _))
            {

                HeighttextBox2.Text = string.Empty; 
                MessageBox.Show("Please enter a valid number for the heigh.");
            }
        }
        private string selectedLogoPath = string.Empty;

        private void Select_Logo_Button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Logo Image";
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedLogoPath = openFileDialog.FileName;

                    Logo_Height.Text=Image.FromFile(selectedLogoPath).Height.ToString();
                    Logo_Width.Text = Image.FromFile(selectedLogoPath).Width.ToString();


                    Select_Logo_Button.BackgroundImage = Image.FromFile(selectedLogoPath);
                    Select_Logo_Button.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }


        private void Add_Text_RichBox_TextChanged(object sender, EventArgs e)
        {

        }



      

        private void Text_Color_btn_Click(object sender, EventArgs e)
        {

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {

                Text_Color_btn.BackColor = colorDialog.Color;
            }
        }

        private void Change_Image_W_H_TextChanged(object sender, EventArgs e)
        {

        }

        private void top_left_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void top_center_radio2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void top_right_radio3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void left_center_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void center_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void right_center_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bottomleft__radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bottom_center_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bottom_right_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logo_position_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logo_Width_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(Logo_Width.Text, out _))
            {

                Logo_Width.Text = string.Empty; 
                MessageBox.Show("Please enter a valid number for the width.");
            }
        }

        private void Logo_Height_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(Logo_Height.Text, out _))
            {

                Logo_Height.Text = string.Empty; 
                MessageBox.Show("Please enter a valid number for the height.");
            }
        }

        private void Change_LOGO_W_H_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Set_Image_Quality_box_CheckedChanged(object sender, EventArgs e)
        {
            if (Set_Image_Quality_box.Checked)
            {
                quality_textBox.Visible = true;
                Quality_value_text.Visible = true;
            }
            else
            {
                quality_textBox.Visible = false;
                Quality_value_text.Visible = false;
            }

        }

        private void quality_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quality_value_text_TextChanged(object sender, EventArgs e)
        {

        }












    }
}
