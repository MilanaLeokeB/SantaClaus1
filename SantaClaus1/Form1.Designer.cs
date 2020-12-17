
namespace SantaClaus1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ground = new System.Windows.Forms.PictureBox();
            this.House = new System.Windows.Forms.PictureBox();
            this.Tree = new System.Windows.Forms.PictureBox();
            this.Moon = new System.Windows.Forms.PictureBox();
            this.White = new System.Windows.Forms.PictureBox();
            this.Santa = new System.Windows.Forms.PictureBox();
            this.Scorel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-28, 447);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1484, 186);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // House
            // 
            this.House.Image = ((System.Drawing.Image)(resources.GetObject("House.Image")));
            this.House.Location = new System.Drawing.Point(1036, 320);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(216, 154);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.House.TabIndex = 1;
            this.House.TabStop = false;
            // 
            // Tree
            // 
            this.Tree.Image = ((System.Drawing.Image)(resources.GetObject("Tree.Image")));
            this.Tree.Location = new System.Drawing.Point(529, 320);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(105, 174);
            this.Tree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tree.TabIndex = 2;
            this.Tree.TabStop = false;
            // 
            // Moon
            // 
            this.Moon.Image = ((System.Drawing.Image)(resources.GetObject("Moon.Image")));
            this.Moon.Location = new System.Drawing.Point(484, -18);
            this.Moon.Name = "Moon";
            this.Moon.Size = new System.Drawing.Size(179, 157);
            this.Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Moon.TabIndex = 3;
            this.Moon.TabStop = false;
            // 
            // White
            // 
            this.White.Image = ((System.Drawing.Image)(resources.GetObject("White.Image")));
            this.White.Location = new System.Drawing.Point(1104, 22);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(107, 98);
            this.White.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.White.TabIndex = 4;
            this.White.TabStop = false;
            // 
            // Santa
            // 
            this.Santa.Image = ((System.Drawing.Image)(resources.GetObject("Santa.Image")));
            this.Santa.Location = new System.Drawing.Point(46, 198);
            this.Santa.Name = "Santa";
            this.Santa.Size = new System.Drawing.Size(198, 88);
            this.Santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Santa.TabIndex = 5;
            this.Santa.TabStop = false;
            // 
            // Scorel
            // 
            this.Scorel.AutoSize = true;
            this.Scorel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Scorel.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorel.Location = new System.Drawing.Point(40, 517);
            this.Scorel.Name = "Scorel";
            this.Scorel.Size = new System.Drawing.Size(89, 31);
            this.Scorel.TabIndex = 6;
            this.Scorel.Text = "Score:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.Location = new System.Drawing.Point(698, 150);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(209, 178);
            this.Button.TabIndex = 7;
            this.Button.Text = "Play Again!";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Visible = false;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1439, 557);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Scorel);
            this.Controls.Add(this.Santa);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Moon);
            this.Controls.Add(this.Tree);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.White)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Santa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox House;
        private System.Windows.Forms.PictureBox Tree;
        private System.Windows.Forms.PictureBox Moon;
        private System.Windows.Forms.PictureBox White;
        private System.Windows.Forms.PictureBox Santa;
        private System.Windows.Forms.Label Scorel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Button;
    }
}

