namespace cs341_ktsao5_hwk6
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
            this.stationBox = new System.Windows.Forms.ListBox();
            this.stopBox = new System.Windows.Forms.ListBox();
            this.lineBox = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weekday = new System.Windows.Forms.Label();
            this.sat = new System.Windows.Forms.Label();
            this.sunholiday = new System.Windows.Forms.Label();
            this.handicap = new System.Windows.Forms.Label();
            this.riderBox = new System.Windows.Forms.TextBox();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.percBox = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weekBox = new System.Windows.Forms.TextBox();
            this.satBox = new System.Windows.Forms.TextBox();
            this.sunBox = new System.Windows.Forms.TextBox();
            this.handicapBox = new System.Windows.Forms.TextBox();
            this.directBox = new System.Windows.Forms.TextBox();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.StationNum = new System.Windows.Forms.Label();
            this.txtDatabaseFilename = new System.Windows.Forms.TextBox();
            this.userInput = new System.Windows.Forms.TextBox();
            this.findByName = new System.Windows.Forms.Button();
            this.weeklyButton = new System.Windows.Forms.Button();
            this.satButton = new System.Windows.Forms.Button();
            this.shButton = new System.Windows.Forms.Button();
            this.flipADA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stationBox
            // 
            this.stationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationBox.FormattingEnabled = true;
            this.stationBox.ItemHeight = 20;
            this.stationBox.Location = new System.Drawing.Point(12, 12);
            this.stationBox.Name = "stationBox";
            this.stationBox.Size = new System.Drawing.Size(257, 384);
            this.stationBox.TabIndex = 0;
            this.stationBox.SelectedIndexChanged += new System.EventHandler(this.stationBox_SelectedIndexChanged);
            // 
            // stopBox
            // 
            this.stopBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBox.FormattingEnabled = true;
            this.stopBox.ItemHeight = 20;
            this.stopBox.Location = new System.Drawing.Point(537, 214);
            this.stopBox.Name = "stopBox";
            this.stopBox.Size = new System.Drawing.Size(244, 224);
            this.stopBox.TabIndex = 1;
            this.stopBox.SelectedIndexChanged += new System.EventHandler(this.stopBox_SelectedIndexChanged);
            // 
            // lineBox
            // 
            this.lineBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBox.FormattingEnabled = true;
            this.lineBox.ItemHeight = 20;
            this.lineBox.Location = new System.Drawing.Point(791, 354);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(193, 84);
            this.lineBox.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(281, 405);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 39);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Load All Stations";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Top 10 Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Ridership:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(533, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Avg Ridership:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "% Ridership:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stops at this station:";
            // 
            // weekday
            // 
            this.weekday.AutoSize = true;
            this.weekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekday.Location = new System.Drawing.Point(787, 12);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(79, 20);
            this.weekday.TabIndex = 9;
            this.weekday.Text = "Weekday:";
            // 
            // sat
            // 
            this.sat.AutoSize = true;
            this.sat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sat.Location = new System.Drawing.Point(787, 68);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(77, 20);
            this.sat.TabIndex = 10;
            this.sat.Text = "Saturday:";
            // 
            // sunholiday
            // 
            this.sunholiday.AutoSize = true;
            this.sunholiday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunholiday.Location = new System.Drawing.Point(787, 123);
            this.sunholiday.Name = "sunholiday";
            this.sunholiday.Size = new System.Drawing.Size(98, 20);
            this.sunholiday.TabIndex = 11;
            this.sunholiday.Text = "Sun/Holiday:";
            // 
            // handicap
            // 
            this.handicap.AutoSize = true;
            this.handicap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handicap.Location = new System.Drawing.Point(787, 175);
            this.handicap.Name = "handicap";
            this.handicap.Size = new System.Drawing.Size(164, 20);
            this.handicap.TabIndex = 12;
            this.handicap.Text = "Handicap accessible?";
            // 
            // riderBox
            // 
            this.riderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riderBox.Location = new System.Drawing.Point(537, 35);
            this.riderBox.Name = "riderBox";
            this.riderBox.ReadOnly = true;
            this.riderBox.Size = new System.Drawing.Size(243, 26);
            this.riderBox.TabIndex = 13;
            // 
            // avgBox
            // 
            this.avgBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgBox.Location = new System.Drawing.Point(537, 91);
            this.avgBox.Name = "avgBox";
            this.avgBox.ReadOnly = true;
            this.avgBox.Size = new System.Drawing.Size(243, 26);
            this.avgBox.TabIndex = 14;
            // 
            // percBox
            // 
            this.percBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percBox.Location = new System.Drawing.Point(537, 146);
            this.percBox.Name = "percBox";
            this.percBox.ReadOnly = true;
            this.percBox.Size = new System.Drawing.Size(243, 26);
            this.percBox.TabIndex = 15;
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direction.Location = new System.Drawing.Point(787, 225);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(136, 20);
            this.direction.TabIndex = 16;
            this.direction.Text = "Direction of travel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(787, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(787, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lines:";
            // 
            // weekBox
            // 
            this.weekBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekBox.Location = new System.Drawing.Point(791, 35);
            this.weekBox.Name = "weekBox";
            this.weekBox.ReadOnly = true;
            this.weekBox.Size = new System.Drawing.Size(192, 26);
            this.weekBox.TabIndex = 19;
            // 
            // satBox
            // 
            this.satBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satBox.Location = new System.Drawing.Point(791, 91);
            this.satBox.Name = "satBox";
            this.satBox.ReadOnly = true;
            this.satBox.Size = new System.Drawing.Size(192, 26);
            this.satBox.TabIndex = 20;
            // 
            // sunBox
            // 
            this.sunBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunBox.Location = new System.Drawing.Point(791, 146);
            this.sunBox.Name = "sunBox";
            this.sunBox.ReadOnly = true;
            this.sunBox.Size = new System.Drawing.Size(192, 26);
            this.sunBox.TabIndex = 21;
            // 
            // handicapBox
            // 
            this.handicapBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handicapBox.Location = new System.Drawing.Point(917, 198);
            this.handicapBox.Name = "handicapBox";
            this.handicapBox.ReadOnly = true;
            this.handicapBox.Size = new System.Drawing.Size(66, 26);
            this.handicapBox.TabIndex = 22;
            // 
            // directBox
            // 
            this.directBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directBox.Location = new System.Drawing.Point(917, 248);
            this.directBox.Name = "directBox";
            this.directBox.ReadOnly = true;
            this.directBox.Size = new System.Drawing.Size(66, 26);
            this.directBox.TabIndex = 23;
            // 
            // locationBox
            // 
            this.locationBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.Location = new System.Drawing.Point(790, 302);
            this.locationBox.Name = "locationBox";
            this.locationBox.ReadOnly = true;
            this.locationBox.Size = new System.Drawing.Size(193, 26);
            this.locationBox.TabIndex = 24;
            // 
            // StationNum
            // 
            this.StationNum.AutoSize = true;
            this.StationNum.Location = new System.Drawing.Point(12, 399);
            this.StationNum.Name = "StationNum";
            this.StationNum.Size = new System.Drawing.Size(98, 13);
            this.StationNum.TabIndex = 25;
            this.StationNum.Text = "Number of stations:";
            // 
            // txtDatabaseFilename
            // 
            this.txtDatabaseFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseFilename.Location = new System.Drawing.Point(12, 418);
            this.txtDatabaseFilename.Name = "txtDatabaseFilename";
            this.txtDatabaseFilename.Size = new System.Drawing.Size(239, 26);
            this.txtDatabaseFilename.TabIndex = 26;
            this.txtDatabaseFilename.Text = "|DataDirectory|\\CTA.mdf";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.Location = new System.Drawing.Point(281, 12);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(250, 26);
            this.userInput.TabIndex = 27;
            // 
            // findByName
            // 
            this.findByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findByName.Location = new System.Drawing.Point(281, 50);
            this.findByName.Name = "findByName";
            this.findByName.Size = new System.Drawing.Size(250, 38);
            this.findByName.TabIndex = 28;
            this.findByName.Text = "Find Station";
            this.findByName.UseVisualStyleBackColor = true;
            this.findByName.Click += new System.EventHandler(this.findByName_Click);
            // 
            // weeklyButton
            // 
            this.weeklyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyButton.Location = new System.Drawing.Point(281, 134);
            this.weeklyButton.Name = "weeklyButton";
            this.weeklyButton.Size = new System.Drawing.Size(250, 38);
            this.weeklyButton.TabIndex = 29;
            this.weeklyButton.Text = "Top 10 Weekly";
            this.weeklyButton.UseVisualStyleBackColor = true;
            this.weeklyButton.Click += new System.EventHandler(this.weeklyButton_Click);
            // 
            // satButton
            // 
            this.satButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satButton.Location = new System.Drawing.Point(281, 178);
            this.satButton.Name = "satButton";
            this.satButton.Size = new System.Drawing.Size(250, 38);
            this.satButton.TabIndex = 30;
            this.satButton.Text = "Top 10 Saturday";
            this.satButton.UseVisualStyleBackColor = true;
            this.satButton.Click += new System.EventHandler(this.satButton_Click);
            // 
            // shButton
            // 
            this.shButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shButton.Location = new System.Drawing.Point(281, 225);
            this.shButton.Name = "shButton";
            this.shButton.Size = new System.Drawing.Size(250, 38);
            this.shButton.TabIndex = 31;
            this.shButton.Text = "Top 10 Sunday/Holiday";
            this.shButton.UseVisualStyleBackColor = true;
            this.shButton.Click += new System.EventHandler(this.shButton_Click);
            // 
            // flipADA
            // 
            this.flipADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipADA.Location = new System.Drawing.Point(789, 198);
            this.flipADA.Name = "flipADA";
            this.flipADA.Size = new System.Drawing.Size(122, 26);
            this.flipADA.TabIndex = 32;
            this.flipADA.Text = "Change";
            this.flipADA.UseVisualStyleBackColor = true;
            this.flipADA.Click += new System.EventHandler(this.flipADA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flipADA);
            this.Controls.Add(this.shButton);
            this.Controls.Add(this.satButton);
            this.Controls.Add(this.weeklyButton);
            this.Controls.Add(this.findByName);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.txtDatabaseFilename);
            this.Controls.Add(this.StationNum);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.directBox);
            this.Controls.Add(this.handicapBox);
            this.Controls.Add(this.sunBox);
            this.Controls.Add(this.satBox);
            this.Controls.Add(this.weekBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.percBox);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.riderBox);
            this.Controls.Add(this.handicap);
            this.Controls.Add(this.sunholiday);
            this.Controls.Add(this.sat);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.stopBox);
            this.Controls.Add(this.stationBox);
            this.Name = "Form1";
            this.Text = "CTA Ridership Analysis / Kevin Tsao / ktsao5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stationBox;
        private System.Windows.Forms.ListBox stopBox;
        private System.Windows.Forms.ListBox lineBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label weekday;
        private System.Windows.Forms.Label sat;
        private System.Windows.Forms.Label sunholiday;
        private System.Windows.Forms.Label handicap;
        private System.Windows.Forms.TextBox riderBox;
        private System.Windows.Forms.TextBox avgBox;
        private System.Windows.Forms.TextBox percBox;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox weekBox;
        private System.Windows.Forms.TextBox satBox;
        private System.Windows.Forms.TextBox sunBox;
        private System.Windows.Forms.TextBox handicapBox;
        private System.Windows.Forms.TextBox directBox;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label StationNum;
        private System.Windows.Forms.TextBox txtDatabaseFilename;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button findByName;
        private System.Windows.Forms.Button weeklyButton;
        private System.Windows.Forms.Button satButton;
        private System.Windows.Forms.Button shButton;
        private System.Windows.Forms.Button flipADA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

