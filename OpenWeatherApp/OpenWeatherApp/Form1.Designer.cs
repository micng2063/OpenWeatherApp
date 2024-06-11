
namespace OpenWeatherApp
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
            this.labCity = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.textSunrise = new System.Windows.Forms.Label();
            this.textSunset = new System.Windows.Forms.Label();
            this.textPressure = new System.Windows.Forms.Label();
            this.textWindspeed = new System.Windows.Forms.Label();
            this.textDetails = new System.Windows.Forms.Label();
            this.textCondition = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.BackColor = System.Drawing.Color.Transparent;
            this.labCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labCity.Location = new System.Drawing.Point(70, 309);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(46, 23);
            this.labCity.TabIndex = 0;
            this.labCity.Text = "City:";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labCondition.Location = new System.Drawing.Point(70, 353);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(83, 19);
            this.labCondition.TabIndex = 1;
            this.labCondition.Text = "Condition: ";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labDetails.Location = new System.Drawing.Point(70, 400);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(63, 19);
            this.labDetails.TabIndex = 2;
            this.labDetails.Text = "Details: ";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSunset.Location = new System.Drawing.Point(290, 400);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(63, 19);
            this.labSunset.TabIndex = 4;
            this.labSunset.Text = "Sunset: ";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSunrise.Location = new System.Drawing.Point(290, 353);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(67, 19);
            this.labSunrise.TabIndex = 3;
            this.labSunrise.Text = "Sunrise: ";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labPressure.Location = new System.Drawing.Point(519, 400);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(75, 19);
            this.labPressure.TabIndex = 6;
            this.labPressure.Text = "Pressure: ";
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labWindspeed.Location = new System.Drawing.Point(519, 353);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(90, 19);
            this.labWindspeed.TabIndex = 5;
            this.labWindspeed.Text = "Windspeed:";
            // 
            // textSunrise
            // 
            this.textSunrise.AutoSize = true;
            this.textSunrise.BackColor = System.Drawing.Color.Transparent;
            this.textSunrise.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSunrise.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textSunrise.Location = new System.Drawing.Point(363, 353);
            this.textSunrise.Name = "textSunrise";
            this.textSunrise.Size = new System.Drawing.Size(33, 19);
            this.textSunrise.TabIndex = 7;
            this.textSunrise.Text = "N/A";
            // 
            // textSunset
            // 
            this.textSunset.AutoSize = true;
            this.textSunset.BackColor = System.Drawing.Color.Transparent;
            this.textSunset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSunset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textSunset.Location = new System.Drawing.Point(363, 400);
            this.textSunset.Name = "textSunset";
            this.textSunset.Size = new System.Drawing.Size(33, 19);
            this.textSunset.TabIndex = 8;
            this.textSunset.Text = "N/A";
            // 
            // textPressure
            // 
            this.textPressure.AutoSize = true;
            this.textPressure.BackColor = System.Drawing.Color.Transparent;
            this.textPressure.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPressure.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textPressure.Location = new System.Drawing.Point(617, 400);
            this.textPressure.Name = "textPressure";
            this.textPressure.Size = new System.Drawing.Size(33, 19);
            this.textPressure.TabIndex = 10;
            this.textPressure.Text = "N/A";
            // 
            // textWindspeed
            // 
            this.textWindspeed.AutoSize = true;
            this.textWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.textWindspeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textWindspeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textWindspeed.Location = new System.Drawing.Point(617, 353);
            this.textWindspeed.Name = "textWindspeed";
            this.textWindspeed.Size = new System.Drawing.Size(33, 19);
            this.textWindspeed.TabIndex = 9;
            this.textWindspeed.Text = "N/A";
            // 
            // textDetails
            // 
            this.textDetails.AutoSize = true;
            this.textDetails.BackColor = System.Drawing.Color.Transparent;
            this.textDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textDetails.Location = new System.Drawing.Point(151, 400);
            this.textDetails.Name = "textDetails";
            this.textDetails.Size = new System.Drawing.Size(33, 19);
            this.textDetails.TabIndex = 12;
            this.textDetails.Text = "N/A";
            // 
            // textCondition
            // 
            this.textCondition.AutoSize = true;
            this.textCondition.BackColor = System.Drawing.Color.Transparent;
            this.textCondition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCondition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textCondition.Location = new System.Drawing.Point(151, 353);
            this.textCondition.Name = "textCondition";
            this.textCondition.Size = new System.Drawing.Size(33, 19);
            this.textCondition.TabIndex = 11;
            this.textCondition.Text = "N/A";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(122, 312);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(186, 20);
            this.textCity.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(321, 309);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textDetails);
            this.Controls.Add(this.textCondition);
            this.Controls.Add(this.textPressure);
            this.Controls.Add(this.textWindspeed);
            this.Controls.Add(this.textSunset);
            this.Controls.Add(this.textSunrise);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindspeed);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.labCity);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "OpenWeather";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label textSunrise;
        private System.Windows.Forms.Label textSunset;
        private System.Windows.Forms.Label textPressure;
        private System.Windows.Forms.Label textWindspeed;
        private System.Windows.Forms.Label textDetails;
        private System.Windows.Forms.Label textCondition;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Button btnSearch;
    }
}

