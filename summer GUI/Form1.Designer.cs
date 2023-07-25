
namespace summer_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Cat = new System.Windows.Forms.PictureBox();
            this.Dog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 38);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.comboBox1.Location = new System.Drawing.Point(78, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Cat
            // 
            this.Cat.Image = ((System.Drawing.Image)(resources.GetObject("Cat.Image")));
            this.Cat.Location = new System.Drawing.Point(415, 249);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(236, 320);
            this.Cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cat.TabIndex = 4;
            this.Cat.TabStop = false;
            this.Cat.Visible = false;
            this.Cat.Click += new System.EventHandler(this.Cat_Click);
            // 
            // Dog
            // 
            this.Dog.Image = ((System.Drawing.Image)(resources.GetObject("Dog.Image")));
            this.Dog.Location = new System.Drawing.Point(738, 249);
            this.Dog.Name = "Dog";
            this.Dog.Size = new System.Drawing.Size(246, 308);
            this.Dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog.TabIndex = 5;
            this.Dog.TabStop = false;
            this.Dog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 965);
            this.Controls.Add(this.Dog);
            this.Controls.Add(this.Cat);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Pet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox Cat;
        private System.Windows.Forms.PictureBox Dog;
    }
}

