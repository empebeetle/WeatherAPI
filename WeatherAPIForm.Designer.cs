namespace WeatherAPI
{
    partial class WeatherAPIForm
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
            this.btnGetWeatherXML = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGetWeatherJSON = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtFeelsLike = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.txtClouds = new System.Windows.Forms.TextBox();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetWeatherXML
            // 
            this.btnGetWeatherXML.BackColor = System.Drawing.Color.LightBlue;
            this.btnGetWeatherXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetWeatherXML.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeatherXML.ForeColor = System.Drawing.Color.Purple;
            this.btnGetWeatherXML.Location = new System.Drawing.Point(93, 35);
            this.btnGetWeatherXML.Name = "btnGetWeatherXML";
            this.btnGetWeatherXML.Size = new System.Drawing.Size(446, 42);
            this.btnGetWeatherXML.TabIndex = 0;
            this.btnGetWeatherXML.Text = "Get Weather (XML)";
            this.btnGetWeatherXML.UseVisualStyleBackColor = false;
            this.btnGetWeatherXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Thistle;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Location = new System.Drawing.Point(464, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnGetWeatherJSON
            // 
            this.btnGetWeatherJSON.BackColor = System.Drawing.Color.LightBlue;
            this.btnGetWeatherJSON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetWeatherJSON.Font = new System.Drawing.Font("Engravers MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetWeatherJSON.ForeColor = System.Drawing.Color.Purple;
            this.btnGetWeatherJSON.Location = new System.Drawing.Point(93, 92);
            this.btnGetWeatherJSON.Name = "btnGetWeatherJSON";
            this.btnGetWeatherJSON.Size = new System.Drawing.Size(446, 42);
            this.btnGetWeatherJSON.TabIndex = 3;
            this.btnGetWeatherJSON.Text = "Get Weather (JSON)";
            this.btnGetWeatherJSON.UseVisualStyleBackColor = false;
            this.btnGetWeatherJSON.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.LightBlue;
            this.txtZip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZip.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtZip.Location = new System.Drawing.Point(93, 198);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(446, 20);
            this.txtZip.TabIndex = 4;
            this.txtZip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.LightBlue;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(93, 270);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(446, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtLatitude
            // 
            this.txtLatitude.BackColor = System.Drawing.Color.LightBlue;
            this.txtLatitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLatitude.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(93, 342);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(220, 20);
            this.txtLatitude.TabIndex = 6;
            // 
            // txtLongitude
            // 
            this.txtLongitude.BackColor = System.Drawing.Color.LightBlue;
            this.txtLongitude.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLongitude.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(319, 342);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(220, 20);
            this.txtLongitude.TabIndex = 7;
            this.txtLongitude.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtTemperature
            // 
            this.txtTemperature.BackColor = System.Drawing.Color.LightBlue;
            this.txtTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTemperature.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtTemperature.Enabled = false;
            this.txtTemperature.Location = new System.Drawing.Point(93, 415);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(107, 20);
            this.txtTemperature.TabIndex = 8;
            // 
            // txtFeelsLike
            // 
            this.txtFeelsLike.BackColor = System.Drawing.Color.LightBlue;
            this.txtFeelsLike.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeelsLike.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtFeelsLike.Enabled = false;
            this.txtFeelsLike.Location = new System.Drawing.Point(432, 415);
            this.txtFeelsLike.Name = "txtFeelsLike";
            this.txtFeelsLike.Size = new System.Drawing.Size(107, 20);
            this.txtFeelsLike.TabIndex = 9;
            // 
            // txtLow
            // 
            this.txtLow.BackColor = System.Drawing.Color.LightBlue;
            this.txtLow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLow.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtLow.Enabled = false;
            this.txtLow.Location = new System.Drawing.Point(206, 415);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(107, 20);
            this.txtLow.TabIndex = 10;
            // 
            // txtHigh
            // 
            this.txtHigh.BackColor = System.Drawing.Color.LightBlue;
            this.txtHigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHigh.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtHigh.Enabled = false;
            this.txtHigh.Location = new System.Drawing.Point(319, 415);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(107, 20);
            this.txtHigh.TabIndex = 11;
            // 
            // txtClouds
            // 
            this.txtClouds.BackColor = System.Drawing.Color.LightBlue;
            this.txtClouds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClouds.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtClouds.Enabled = false;
            this.txtClouds.Location = new System.Drawing.Point(319, 488);
            this.txtClouds.Name = "txtClouds";
            this.txtClouds.Size = new System.Drawing.Size(220, 20);
            this.txtClouds.TabIndex = 13;
            // 
            // txtWind
            // 
            this.txtWind.BackColor = System.Drawing.Color.LightBlue;
            this.txtWind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWind.Cursor = System.Windows.Forms.Cursors.Cross;
            this.txtWind.Enabled = false;
            this.txtWind.Location = new System.Drawing.Point(93, 488);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(220, 20);
            this.txtWind.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(93, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter a Zip Code:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(93, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(93, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Latitute";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(319, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Longitude";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(93, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(203, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Low";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(319, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "High";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(429, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Feels Like";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(93, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Wind";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Californian FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Purple;
            this.label10.Location = new System.Drawing.Point(319, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Clouds";
            // 
            // WeatherAPIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(622, 590);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClouds);
            this.Controls.Add(this.txtWind);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtFeelsLike);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnGetWeatherJSON);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGetWeatherXML);
            this.Name = "WeatherAPIForm";
            this.Text = "Weather API Application";
            this.Load += new System.EventHandler(this.WeatherAPIForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWeatherXML;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnGetWeatherJSON;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtFeelsLike;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.TextBox txtClouds;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

