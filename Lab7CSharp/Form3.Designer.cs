namespace Lab7CSharp
{
    partial class Form3
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.circleRadius = new System.Windows.Forms.TextBox();
            this.sectorRadius = new System.Windows.Forms.TextBox();
            this.rectangleWidth = new System.Windows.Forms.TextBox();
            this.sectorStartAngle = new System.Windows.Forms.TextBox();
            this.starSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sectorSweepAngle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rectangleHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(528, 22);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(687, 568);
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // circleRadius
            // 
            this.circleRadius.Location = new System.Drawing.Point(42, 66);
            this.circleRadius.Name = "circleRadius";
            this.circleRadius.Size = new System.Drawing.Size(69, 20);
            this.circleRadius.TabIndex = 1;
            this.circleRadius.Text = "32";
            this.circleRadius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sectorRadius
            // 
            this.sectorRadius.Location = new System.Drawing.Point(42, 126);
            this.sectorRadius.Name = "sectorRadius";
            this.sectorRadius.Size = new System.Drawing.Size(69, 20);
            this.sectorRadius.TabIndex = 3;
            this.sectorRadius.Text = "30";
            // 
            // rectangleWidth
            // 
            this.rectangleWidth.Location = new System.Drawing.Point(42, 181);
            this.rectangleWidth.Name = "rectangleWidth";
            this.rectangleWidth.Size = new System.Drawing.Size(69, 20);
            this.rectangleWidth.TabIndex = 4;
            this.rectangleWidth.Text = "220";
            // 
            // sectorStartAngle
            // 
            this.sectorStartAngle.Location = new System.Drawing.Point(143, 126);
            this.sectorStartAngle.Name = "sectorStartAngle";
            this.sectorStartAngle.Size = new System.Drawing.Size(69, 20);
            this.sectorStartAngle.TabIndex = 5;
            this.sectorStartAngle.Text = "20";
            // 
            // starSize
            // 
            this.starSize.Location = new System.Drawing.Point(42, 229);
            this.starSize.Name = "starSize";
            this.starSize.Size = new System.Drawing.Size(69, 20);
            this.starSize.TabIndex = 6;
            this.starSize.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Circle radius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sector radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sector start angle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sector sweep angle";
            // 
            // sectorSweepAngle
            // 
            this.sectorSweepAngle.Location = new System.Drawing.Point(250, 126);
            this.sectorSweepAngle.Name = "sectorSweepAngle";
            this.sectorSweepAngle.Size = new System.Drawing.Size(69, 20);
            this.sectorSweepAngle.TabIndex = 16;
            this.sectorSweepAngle.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rectangle width";
            // 
            // rectangleHeight
            // 
            this.rectangleHeight.Location = new System.Drawing.Point(143, 181);
            this.rectangleHeight.Name = "rectangleHeight";
            this.rectangleHeight.Size = new System.Drawing.Size(69, 20);
            this.rectangleHeight.TabIndex = 18;
            this.rectangleHeight.Text = "138";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Rectangle height";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Star size";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Location = new System.Drawing.Point(42, 280);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(120, 100);
            this.groupBoxColor.TabIndex = 21;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Colors";
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(12, 77);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(45, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(12, 54);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(52, 17);
            this.radioButtonGreen.TabIndex = 1;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(12, 31);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(40, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // buttonPaint
            // 
            this.buttonPaint.Location = new System.Drawing.Point(64, 396);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(75, 23);
            this.buttonPaint.TabIndex = 22;
            this.buttonPaint.Text = "Paint";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(64, 425);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 660);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rectangleHeight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sectorSweepAngle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.starSize);
            this.Controls.Add(this.sectorStartAngle);
            this.Controls.Add(this.rectangleWidth);
            this.Controls.Add(this.sectorRadius);
            this.Controls.Add(this.circleRadius);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.TextBox circleRadius;
        private System.Windows.Forms.TextBox sectorRadius;
        private System.Windows.Forms.TextBox rectangleWidth;
        private System.Windows.Forms.TextBox sectorStartAngle;
        private System.Windows.Forms.TextBox starSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sectorSweepAngle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rectangleHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.Button buttonClear;
    }
}